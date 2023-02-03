namespace WallpaperChanger
{
    partial class FormWallpaperChanger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWallpaperChanger));
            this.buttonBrowseFiles = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelPath = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPreview3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPreview2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxPreview1 = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowseFiles
            // 
            this.buttonBrowseFiles.BackColor = System.Drawing.Color.DimGray;
            this.buttonBrowseFiles.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowseFiles.ForeColor = System.Drawing.Color.MintCream;
            this.buttonBrowseFiles.Location = new System.Drawing.Point(14, 58);
            this.buttonBrowseFiles.Name = "buttonBrowseFiles";
            this.buttonBrowseFiles.Size = new System.Drawing.Size(586, 56);
            this.buttonBrowseFiles.TabIndex = 0;
            this.buttonBrowseFiles.Text = "Browse files...";
            this.buttonBrowseFiles.UseVisualStyleBackColor = false;
            this.buttonBrowseFiles.Click += new System.EventHandler(this.buttonBrowseFiles_Click);
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPath.ForeColor = System.Drawing.Color.Lime;
            this.labelPath.Location = new System.Drawing.Point(14, 22);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(24, 17);
            this.labelPath.TabIndex = 1;
            this.labelPath.Text = "--";
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.Color.Lime;
            this.buttonApply.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonApply.ForeColor = System.Drawing.Color.Black;
            this.buttonApply.Location = new System.Drawing.Point(14, 520);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(1242, 56);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply Wallpaper";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1242, 394);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxPreview3
            // 
            this.pictureBoxPreview3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPreview3.Image")));
            this.pictureBoxPreview3.Location = new System.Drawing.Point(1128, 22);
            this.pictureBoxPreview3.Name = "pictureBoxPreview3";
            this.pictureBoxPreview3.Size = new System.Drawing.Size(128, 92);
            this.pictureBoxPreview3.TabIndex = 6;
            this.pictureBoxPreview3.TabStop = false;
            // 
            // pictureBoxPreview2
            // 
            this.pictureBoxPreview2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPreview2.Image")));
            this.pictureBoxPreview2.Location = new System.Drawing.Point(994, 22);
            this.pictureBoxPreview2.Name = "pictureBoxPreview2";
            this.pictureBoxPreview2.Size = new System.Drawing.Size(128, 92);
            this.pictureBoxPreview2.TabIndex = 7;
            this.pictureBoxPreview2.TabStop = false;
            // 
            // pictureBoxPreview1
            // 
            this.pictureBoxPreview1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPreview1.Image")));
            this.pictureBoxPreview1.Location = new System.Drawing.Point(860, 22);
            this.pictureBoxPreview1.Name = "pictureBoxPreview1";
            this.pictureBoxPreview1.Size = new System.Drawing.Size(128, 92);
            this.pictureBoxPreview1.TabIndex = 8;
            this.pictureBoxPreview1.TabStop = false;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Black;
            this.textBoxSearch.ForeColor = System.Drawing.Color.Lime;
            this.textBoxSearch.Location = new System.Drawing.Point(606, 22);
            this.textBoxSearch.MaxLength = 30;
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.PlaceholderText = "Search";
            this.textBoxSearch.Size = new System.Drawing.Size(248, 23);
            this.textBoxSearch.TabIndex = 9;
            this.textBoxSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSearch_KeyDown);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.OrangeRed;
            this.buttonClear.Enabled = false;
            this.buttonClear.ForeColor = System.Drawing.Color.MintCream;
            this.buttonClear.Location = new System.Drawing.Point(606, 58);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(248, 56);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormWallpaperChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1268, 588);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.pictureBoxPreview1);
            this.Controls.Add(this.pictureBoxPreview2);
            this.Controls.Add(this.pictureBoxPreview3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.buttonBrowseFiles);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWallpaperChanger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallpaper Changer";
            this.Load += new System.EventHandler(this.FormWallpaperChanger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBrowseFiles;
        private OpenFileDialog openFileDialog1;
        private Label labelPath;
        private Button buttonApply;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxPreview3;
        private PictureBox pictureBoxPreview2;
        private PictureBox pictureBoxPreview1;
        private TextBox textBoxSearch;
        private Button buttonClear;
    }
}