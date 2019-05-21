using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageLibrary
{
    public partial class View : Form, IView
    {
        private Presenter _presenter = null;
        private readonly Model _model;
      
        public View(Model model)
        {
            InitializeComponent();
            _model = model;
            _presenter = new Presenter(this, _model);
        }

        public void ShowImage(string path)
        {
            Bitmap bitmap = new Bitmap(path);
            this.mainPictureBox.Image = bitmap;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog();
            DialogResult result = browserDialog.ShowDialog();
            
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browserDialog.SelectedPath))
            {
                /*
                browserDialog.Sel
                List<string> files = Directory.GetFiles(browserDialog.SelectedPath).ToList();
                */
                _presenter.LoadImagesFrom(browserDialog.SelectedPath);
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            _presenter.LoadAndShowPreviousImage();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            _presenter.LoadAndShowNextImage();
        }


        private void rotateClockwiseButton_Click(object sender, EventArgs e)
        {
            Image img = mainPictureBox.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            mainPictureBox.Image = img;
        }

        private void rotateAntiClockwiseButton_Click(object sender, EventArgs e)
        {
            Image img = mainPictureBox.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            mainPictureBox.Image = img;
        }
    }
}
