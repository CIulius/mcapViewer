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
        private string _path;

        public View(Model model)
        {
            _model = model;
            InitializeComponent();
            _presenter = new Presenter(this, _model);
        }

        public string imagePath
        {
            get
            {
                return _path;
            }

            set
            {
                _path = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog();
            DialogResult result = browserDialog.ShowDialog();
            
            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browserDialog.SelectedPath))
            {
                string[] files = Directory.GetFiles(browserDialog.SelectedPath);
                _presenter.loadImages(files);
            }

            _presenter.setCurrentImage();
            _presenter.getCurrentImage();

            Bitmap image = new Bitmap(this.imagePath);
            pictureBox1.Image = image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _presenter.previousImage();
            _presenter.getCurrentImage();

            Bitmap image = new Bitmap(this.imagePath);
            pictureBox1.Image = image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _presenter.nextImage();
            _presenter.getCurrentImage();

            Bitmap image = new Bitmap(this.imagePath);
            pictureBox1.Image = image;
        }

    }
}
