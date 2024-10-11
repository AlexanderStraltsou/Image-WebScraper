using System.Net.Http;
using System.Text.RegularExpressions;

namespace WebScraper;

public partial class Scraper : Form
{
   
    private int _counter = 1;
    private string _path = "";

    HttpClient _client = new HttpClient();

    public Scraper()
    {
        InitializeComponent();
    }
        

    private async void buttonExtract_Click(object sender, EventArgs e)
    {
        listBoxImageURLs.Items.Clear();
        var url = "https://" + textBoxURL.Text;

        try
        {
            await GetWebHTML(url);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to fetch the URL: {ex.Message}");
        }

        labelNumberOfURLs.Text = $"Number of images found: {listBoxImageURLs.Items.Count}";
    }




    private async Task GetWebHTML(string url)
    {
        try
        {
            string content = await _client.GetStringAsync(url);

            Regex regex = new Regex(@"[^""'\s,]*\.(?:jpg|png)[^""'\s,]*", RegexOptions.IgnoreCase);
            

            
            MatchCollection matches = regex.Matches(content);

            foreach (Match match in matches)
            {
                string imgUrl = match.Value;

                
                if (imgUrl.StartsWith("/"))
                {
                    imgUrl = url + imgUrl;
                }

                listBoxImageURLs.Items.Add(imgUrl);
            }


            if (listBoxImageURLs.Items.Count > 0)
            {
                buttonSave.Enabled = true; 
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to retrieve webpage: {ex.Message}");
        }
    }


    private async void buttonSave_Click(object sender, EventArgs e)
    {
        List<Task<byte[]>> imageData = new List<Task<byte[]>>();
        int failedCounter = 0;

        using (var dialog = new FolderBrowserDialog())
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _path = dialog.SelectedPath;

                foreach (string url in listBoxImageURLs.Items)
                {
                    
                    string fullUrl = url.StartsWith("http") ? url : $"https://{new Uri(new Uri(textBoxURL.Text), url).ToString()}";

               
                    if (Uri.TryCreate(fullUrl, UriKind.Absolute, out Uri uriResult))
                    {
                        try
                        {
                            
                            imageData.Add(_client.GetByteArrayAsync(uriResult.AbsoluteUri));
                        }
                        catch
                        {
                            failedCounter++;
                        }
                    }
                    else
                    {
                        failedCounter++;
                    }
                }

                while (imageData.Count > 0)
                {
                    Task<byte[]> task = null;

                    try
                    {
                        using (task = await Task.WhenAny(imageData))
                        {
                            await SaveFileAsync(await task);
                        }
                    }
                    catch
                    {
                        failedCounter++;
                    }
                    finally
                    {
                        imageData.Remove(task);
                    }
                }

                labelSaveResult.Text = $"{_counter - 1} images saved to disk. {failedCounter} failed.";
                MessageBox.Show("Download completed.");
                listBoxImageURLs.Items.Clear();
            }
        }
    }

    private async Task SaveFileAsync(byte[] imageData)
    {
        
        string fileType;
        switch (imageData[0])
        {
            case 255:
                fileType = ".jpg"; break;
            case 137:
                fileType = ".png"; break;
            case 47:
                fileType = ".gif"; break;
            case 66:
                fileType = ".bmp"; break;
            default:
                throw new FileFormatException();
        }

        using (var fileStream = new FileStream(_path + $"\\image{_counter:000}" + fileType,
                                                FileMode.CreateNew))
        {
            await fileStream.WriteAsync(imageData, 0, imageData.Length);
        }
        _counter++;
    }
}
