using HtmlAgilityPack;
using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

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
        int selectedWallpaper = 0;

        static string GetDesktopWallpaper()
        {
            string wallpaper = new string('\0', 260);
            Debug.WriteLine($"wallpaper: {wallpaper}");

            SystemParametersInfo(0x73, (int)wallpaper.Length, wallpaper, 0);

            var result = wallpaper.Substring(0, wallpaper.IndexOf('\0'));
            Debug.WriteLine($"result: {result}");

            return result;
        }

        static void SetDesktopWallpaper(string path)
        {
            Debug.WriteLine($"path: {path}");
            SystemParametersInfo(0x14, 0, path, 0x01 | 0x02);
        }

        private List<string> GetImagesInHTMLString(string htmlString)
        {
            List<string> images = new List<string>();
            string pattern = @"<(img)\b[^>]*>";
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            MatchCollection matches = rgx.Matches(htmlString);

            for (int i = 0, l = matches.Count; i < l; i++)
            {
                images.Add(matches[i].Value);
            }
            return images;
        }

        Bitmap searchGoogle(string query, int index)
        {
            Debug.WriteLine($"query: {query}");

            Debug.WriteLine($"index: {index}");

            var htmlDocument = new HtmlWeb().Load("https://www.google.com/search?q=+" + query + "&tbm=isch");
            var list = GetImagesInHTMLString(htmlDocument.Text);

            Debug.WriteLine($"list: {list}");              

            var str = list[index];
            string pattern = @"(https://.*);";
            Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
            Match matches = rgx.Match(str);
            string path = matches.Groups[index].Value;

            if (path == null) return new Bitmap(Stream.Null);

            var imageStream = WebRequest.Create(path).GetResponse().GetResponseStream();

            Debug.WriteLine($"str: {str}");
            Debug.WriteLine($"imageStream: {imageStream}");                

            return new Bitmap(Image.FromStream(imageStream));
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
                        Debug.WriteLine($"path: {path}");

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
            Debug.WriteLine("FormWallpaperChanger_Load");

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

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                pictureBoxPreview1.Image = searchGoogle(textBoxSearch.Text, 0);
                pictureBoxPreview2.Image = searchGoogle(textBoxSearch.Text, 1);
                //pictureBoxPreview3.Image = searchGoogle(textBoxSearch.Text, 2);
                buttonClear.Enabled = true;
                MessageBox.Show("Pressed enter.");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            buttonClear.Enabled = false;
            pictureBoxPreview1.Image = null;
            pictureBoxPreview2.Image = null;
            pictureBoxPreview3.Image = null;
            textBoxSearch.Text = null;
        }
    }
}