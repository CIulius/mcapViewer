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

        public View()
        {
            InitializeComponent();
        }
        
        public Presenter Presenter
        {
            get
            {
                return _presenter;
            }

            set
            {
                _presenter = value;
            }
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

        /**
         * <summary>Handles the click event on the rotate anticlockwise button.</summary> 
         */
        private void RotateAntiClockwiseButton_Click(object sender, EventArgs e)
        {
            Image img = mainPictureBox.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            mainPictureBox.Image = img;
        }

        /**
         * <summary>Handles the click event on the open file menu button.</summary> 
         */
        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                string path = openFileDialog.FileName;

                throw new NotImplementedException();
            }
        }

        /**
         * <summary>Handles the click event on the open folder menu button.</summary> 
         */
        private void OpenFolderMenuItem_Click(object sender, EventArgs e)
        {
            OpenFolder();
        }


        /**
         * <summary>Handles the click event on the open file menu button. Opens the help (.chm) file.</summary> 
         */
        private void ViewHelpMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: schimba sau adauga help-ul in proiect (relativ)
            String helpPath = @"C:\Users\mircea\Desktop\HelpStudioSample.chm";
            Help.ShowHelp(this, helpPath);
        }

        /**
         * <summary>This function does the actual opening and forwarding of a request on a folder.</summary> 
         */
        private void OpenFolder()
        {
            var browserDialog = new FolderBrowserDialog();
            DialogResult dialogResult = browserDialog.ShowDialog();

            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(browserDialog.SelectedPath))
            {
                _presenter.LoadImagesFrom(browserDialog.SelectedPath);
            }
        }
    }
}
