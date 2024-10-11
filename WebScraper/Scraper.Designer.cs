namespace WebScraper;

partial class Scraper
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelNumberOfURLs = new System.Windows.Forms.Label();
            this.labelSaveResult = new System.Windows.Forms.Label();
            this.listBoxImageURLs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "https://";
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(77, 18);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(418, 27);
            this.textBoxURL.TabIndex = 1;
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(522, 16);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(100, 29);
            this.buttonExtract.TabIndex = 2;
            this.buttonExtract.Text = "Extract";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(688, 16);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 29);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save images";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelNumberOfURLs
            // 
            this.labelNumberOfURLs.AutoSize = true;
            this.labelNumberOfURLs.Location = new System.Drawing.Point(41, 414);
            this.labelNumberOfURLs.Name = "labelNumberOfURLs";
            this.labelNumberOfURLs.Size = new System.Drawing.Size(50, 20);
            this.labelNumberOfURLs.TabIndex = 4;
            this.labelNumberOfURLs.Text = "label2";
            // 
            // labelSaveResult
            // 
            this.labelSaveResult.AutoSize = true;
            this.labelSaveResult.Location = new System.Drawing.Point(458, 413);
            this.labelSaveResult.Name = "labelSaveResult";
            this.labelSaveResult.Size = new System.Drawing.Size(50, 20);
            this.labelSaveResult.TabIndex = 5;
            this.labelSaveResult.Text = "label3";
            // 
            // listBoxImageURLs
            // 
            this.listBoxImageURLs.FormattingEnabled = true;
            this.listBoxImageURLs.ItemHeight = 20;
            this.listBoxImageURLs.Location = new System.Drawing.Point(12, 72);
            this.listBoxImageURLs.Name = "listBoxImageURLs";
            this.listBoxImageURLs.Size = new System.Drawing.Size(776, 324);
            this.listBoxImageURLs.TabIndex = 6;
            // 
            // Scraper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxImageURLs);
            this.Controls.Add(this.labelSaveResult);
            this.Controls.Add(this.labelNumberOfURLs);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonExtract);
            this.Controls.Add(this.textBoxURL);
            this.Controls.Add(this.label1);
            this.Name = "Scraper";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label label1;
    private TextBox textBoxURL;
    private Button buttonExtract;
    private Button buttonSave;
    private Label labelNumberOfURLs;
    private Label labelSaveResult;
    private ListBox listBoxImageURLs;
}
