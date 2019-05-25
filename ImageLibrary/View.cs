/**************************************************************************
 *                                                                        *
 *  File:        View.cs                                                  *
 *  E-mail:      brinzapaul@gmail.com                                     *
 *  Description: The View class is responsible with handling UI events    *
 *                      and changes.                                      *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

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

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFolder();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            _presenter.LoadAndShowPreviousImage();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            _presenter.LoadAndShowNextImage();
        }


        private void RotateClockwiseButton_Click(object sender, EventArgs e)
        {
            Image img = mainPictureBox.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            mainPictureBox.Image = img;
        }

        private void RotateAntiClockwiseButton_Click(object sender, EventArgs e)
        {
            Image img = mainPictureBox.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            mainPictureBox.Image = img;
        }

        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void OpenFolderMenuItem_Click(object sender, EventArgs e)
        {
            OpenFolder();
        }

        private void ViewHelpMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: schimba sau adauga help-ul in proiect (relativ)
            String helpPath = @"C:\Users\mircea\Desktop\HelpStudioSample.chm";
            Help.ShowHelp(this, helpPath);
        }

        private void OpenFolder()
        {
            var browserDialog = new FolderBrowserDialog();
            DialogResult result = browserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(browserDialog.SelectedPath))
            {
                _presenter.LoadImagesFrom(browserDialog.SelectedPath);
            }
        }
    }
}
