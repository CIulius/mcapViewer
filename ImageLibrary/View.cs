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
            if (path != null)
            {
                Bitmap bitmap = new Bitmap(path);
                this.imageResolutionStatusLabel.Text = String.Format("{0}x{1}", bitmap.Width, bitmap.Height);

                Size clientSize = this.mainPictureBox.ClientSize;

                this.indexStatusLabel.Text = _presenter.GetCurrentImagePositionInCollection();
                this.scaleStatusLabel.Text = String.Format("{0:0.00} %", 100.0 * clientSize.Width / bitmap.Width * clientSize.Height / bitmap.Height);
                this.imageTimestampStatusLabel.Text = File.GetCreationTime(path).ToString();

                this.mainPictureBox.Image = bitmap;
            }
            
            else
            {
                MessageBox.Show("No images were loaded!", "Invalid operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            if (img != null)
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                mainPictureBox.Image = img;
            }
            else
            {
                MessageBox.Show("No images were loaded!", "Invalid operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /**
         * <summary>Handles the click event on the rotate anticlockwise button.</summary> 
         */
        private void RotateAntiClockwiseButton_Click(object sender, EventArgs e)
        {
            Image img = mainPictureBox.Image;
            if (img !=null)
            {
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                mainPictureBox.Image = img;
            }
            else
            {
                MessageBox.Show("No images were loaded!", "Invalid operation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /**
         * <summary>Handles the click event on the open file menu button.</summary> 
         */
        private void OpenFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.JPE;*.JPEG;*.TIFF;*.TIF;*.ICO;*.GIF)|*.BMP;*.JPG;*.JPE;*.JPEG;*.TIFF;*.TIF;*.ICO;*.GIF";
            openFileDialog.FilterIndex = 1;

            DialogResult dialogResult = openFileDialog.ShowDialog();

            if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(openFileDialog.FileName))
            {
                string path = openFileDialog.FileName;
                string containingDirectory = Path.GetDirectoryName(path);

                _presenter.LoadImagesFrom(containingDirectory);
                while (!_presenter.CurrentImagePath.Equals(path))
                {
                    _presenter.LoadNextImage();
                }
                _presenter.ShowCurrentImage();
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

        private void mainPictureBox_Resize(object sender, EventArgs e)
        {
            Size clientSize = this.mainPictureBox.ClientSize;
            Image img = this.mainPictureBox.Image;
            if (img != null)
            {
                this.scaleStatusLabel.Text = String.Format("{0:0.00} %", 100.0 * clientSize.Width / img.Width * clientSize.Height / img.Height);
            }
            else
            {
                this.scaleStatusLabel.Text = "Unknown scale";
            }
        }
    }
}
