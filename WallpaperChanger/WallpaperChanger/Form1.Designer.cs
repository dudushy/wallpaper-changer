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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBrowseFiles
            // 
            this.buttonBrowseFiles.BackColor = System.Drawing.Color.DimGray;
            this.buttonBrowseFiles.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowseFiles.ForeColor = System.Drawing.Color.MintCream;
            this.buttonBrowseFiles.Location = new System.Drawing.Point(14, 58);
            this.buttonBrowseFiles.Name = "buttonBrowseFiles";
            this.buttonBrowseFiles.Size = new System.Drawing.Size(291, 56);
            this.buttonBrowseFiles.TabIndex = 0;
            this.buttonBrowseFiles.Text = "Browse files...";
            this.buttonBrowseFiles.UseVisualStyleBackColor = false;
            this.buttonBrowseFiles.Click += new System.EventHandler(this.button1_Click);
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
            this.buttonApply.Location = new System.Drawing.Point(14, 448);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(1224, 56);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply Wallpaper";
            this.buttonApply.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1224, 322);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormWallpaperChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1250, 516);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonBrowseFiles;
        private OpenFileDialog openFileDialog1;
        private Label labelPath;
        private Button buttonApply;
        private PictureBox pictureBox1;
    }
}