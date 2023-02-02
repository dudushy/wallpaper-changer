using System.Runtime.InteropServices;

namespace WallpaperChanger
{
    public partial class FormWallpaperChanger : Form
    {
        public FormWallpaperChanger()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        string initialWallpaperPath = GetDesktopWallpaper();

        bool undoWallpaper = false;
        bool selectedWallpaper = false;

        static string GetDesktopWallpaper()
        {
            string wallpaper = new string('\0', 260);
            Console.WriteLine("wallpaper: ", wallpaper);

            SystemParametersInfo(0x73, (int)wallpaper.Length, wallpaper, 0);

            var result = wallpaper.Substring(0, wallpaper.IndexOf('\0'));
            Console.WriteLine("result: ", result);

            return result;
        }

        static void SetDesktopWallpaper(string path)
        {
            Console.WriteLine("path: ", path);
            SystemParametersInfo(0x14, 0, path, 0x01 | 0x02);
        }

        private void buttonBrowseFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:";
            openFileDialog1.Title = "Select image to be upload.";
            openFileDialog1.Filter = "Image Only(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            openFileDialog1.FilterIndex = 1;

            try
            {
                if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog1.FileName);
                        Console.WriteLine("path: ", path);

                        labelPath.Text = path;
                        pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("No image selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormWallpaperChanger_Load(object sender, EventArgs e)
        {
            Console.WriteLine("FormWallpaperChanger_Load");

            MessageBox.Show(GetDesktopWallpaper());

            pictureBox1.Image = new Bitmap(initialWallpaperPath);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (labelPath.Text == "--") {
                MessageBox.Show("No image selected.");

                return;
            };


            if (undoWallpaper)
            {
                SetDesktopWallpaper(initialWallpaperPath);

                undoWallpaper = false;

                buttonApply.BackColor = Color.Lime;
                buttonApply.ForeColor = Color.Black;
                buttonApply.Text = "Apply Wallpaper";

                MessageBox.Show("Wallpaper restored!");

                return;
            }

            SetDesktopWallpaper(labelPath.Text);

            undoWallpaper = true;

            buttonApply.BackColor = Color.Red;
            buttonApply.ForeColor = Color.White;
            buttonApply.Text = "Restore Wallpaper";

            MessageBox.Show("Wallpaper applied!");
        }
    }
}