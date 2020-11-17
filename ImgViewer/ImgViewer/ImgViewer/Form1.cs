using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImgViewer {

    enum RotateDirection {
        Right,
        Left
    };
    /// <summary>
    /// Full spaghetti code. I don't know why it works.
    /// </summary>
    public partial class MainWindow : Form {
        private Bitmap main_img;
        private bool flip90;
        private bool onlyred;
        private bool onlyblue;
        private RotateDirection direction = RotateDirection.Right;
        private RotateFlipType rotation90 = RotateFlipType.RotateNoneFlipNone;

        public MainWindow() {
            InitializeComponent();
        }

        private void LoadFileButton_Click(object sender, EventArgs e) {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "BMP|*.bmp|JPEG|*.jpg;*.jpeg|PNG|*.png";
            opf.FilterIndex = 2;
            opf.ShowDialog();
            if (opf.FileName != "") {
                this.main_img = new Bitmap(Image.FromFile(opf.FileName));
                this.ImgPictureBox.Image = this.main_img;
            }
        }

        private void SaveFileButton_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP | *.bmp | JPG | *.jpg; *.jpeg | PNG | *.png";
            if (this.ImgPictureBox.Image != null)
                sfd.ShowDialog();
            else
                return;
            if (sfd.FileName != "") {
                System.IO.FileStream fs = (System.IO.FileStream)sfd.OpenFile();
                switch (sfd.FilterIndex) {
                    case 1:
                        this.ImgPictureBox.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 2:
                        this.ImgPictureBox.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 3:
                        this.ImgPictureBox.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }
                MessageBox.Show("Image saved!");
                fs.Close();
            } else {
                return;
            }
        }

        private void Invert180CheckBox_CheckedChanged(object sender, EventArgs e) {
            if (this.main_img is null)
                return;
            var img = this.ImgPictureBox.Image as Bitmap;
            img?.RotateFlip(RotateFlipType.Rotate180FlipNone);
            if (!object.ReferenceEquals(img, this.main_img)) {
                this.main_img?.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            this.ImgPictureBox.Image = img;
        }

        private void Invert90CheckBox_CheckedChanged(object sender, EventArgs e) {
            if (this.main_img is null)
                return;
            var img = this.ImgPictureBox.Image as Bitmap;
            if (this.direction == RotateDirection.Right) {
                if (!this.flip90) {
                    img?.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    this.rotation90 = RotateFlipType.Rotate90FlipNone;
                    this.ImgPictureBox.Image = img;
                    this.flip90 = true;
                } else {
                    img?.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    this.rotation90 = RotateFlipType.Rotate270FlipNone;
                    this.ImgPictureBox.Image = img;
                    this.flip90 = false;
                }
            } else {
                if (!this.flip90) {
                    img?.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    this.rotation90 = RotateFlipType.Rotate270FlipNone;
                    this.ImgPictureBox.Image = img;
                    this.flip90 = true;
                } else {
                    img?.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    this.rotation90 = RotateFlipType.Rotate90FlipNone;
                    this.ImgPictureBox.Image = img;
                    this.flip90 = false;
                }
            }
        }

        private void ReflectCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (this.main_img is null)
                return;
            this.main_img?.RotateFlip(RotateFlipType.RotateNoneFlipX);
            this.ImgPictureBox.Image = this.main_img;
        }

        private void ReflectColorsCheckBox_CheckedChanged(object sender, EventArgs e) {
            Bitmap img = this.main_img as Bitmap;
            if (img is null)
                return;
            for (int i = 0; i < img.Width; i++) {
                for (int j = 0; j < img.Height; j++) {
                    Color col = img.GetPixel(i, j);
                    Color inv = Color.FromArgb(255, (255 - col.R), (255 - col.G), (255 - col.B));
                    img.SetPixel(i, j, inv);
                }
            }
            this.ImgPictureBox.Image = img;
        }

        private void OnlyRedsCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (!this.onlyred) {
                if (this.ImgPictureBox.Image is null)
                    return;
                Bitmap img = this.ImgPictureBox.Image.Clone() as Bitmap;
                for (int i = 0; i < img.Width; i++) {
                    for (int j = 0; j < img.Height; j++) {
                        Color px = img.GetPixel(i, j);
                        if (!(px.R <= 255 && px.G <= 50 && px.B <= 50)) {
                            Color inv = Color.White;
                            img.SetPixel(i, j, inv);
                        }
                    }
                }
                this.ImgPictureBox.Image = img;
                this.onlyred = true;
            } else {
                if (this.ImgPictureBox.Image is null)
                    return;
               this.main_img?.RotateFlip(this.rotation90);
                this.ImgPictureBox.Image = this.main_img;
                this.onlyred = false;
            }  
        }

        private void OnlyBlueCheckBox_CheckedChanged(object sender, EventArgs e) {
            if (!this.onlyblue) {
                if (this.ImgPictureBox.Image is null)
                    return;
                Bitmap img = this.ImgPictureBox.Image.Clone() as Bitmap;
                for (int i = 0; i < img.Width; i++) {
                    for (int j = 0; j < img.Height; j++) {
                        Color px = img.GetPixel(i, j);
                        if(!(px.R <= 50 && px.G <= 50 && px.B <= 255)) {
                            Color inv = Color.White;
                            img.SetPixel(i, j, inv);
                        }
                    }
                }
                this.ImgPictureBox.Image = img;
                this.onlyblue = true;
            } else {
                if (this.ImgPictureBox.Image is null)
                    return;
                this.main_img?.RotateFlip(this.rotation90);
                this.ImgPictureBox.Image = this.main_img;
                this.onlyblue = false;
            }
        }

        public Color ToReds(Color c) {
            return Color.FromArgb(c.A, c.R, 0, 0);
        }

        public Color ToBlue(Color c) {
            return Color.FromArgb(c.A, 0, 0, c.B);
        }

        private void RotateButton_Click(object sender, EventArgs e) {
            switch (this.direction) {
                case RotateDirection.Left:
                    this.direction = RotateDirection.Right;
                    break;
                case RotateDirection.Right:
                    this.direction = RotateDirection.Left;
                    break;
            }
            this.RotateButton.Text = "Rotate: " + this.direction.ToString();
        }
    }
}
