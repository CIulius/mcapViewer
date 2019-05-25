/**************************************************************************
 *                                                                        *
 *  File:        Presenter.cs                                             *
 *  E-mail:      brinzapaul@gmail.com                                     *
 *  Description: This class is responsible with propagating changes       *
 *               throughout the whole system.                              *
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
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageLibrary
{
    class Presenter
    {
        private readonly IView _view;
        private IModel _model;

        public Presenter(IView view, IModel model)
        {
            this._view = view;
            this._model = model;
        }

        public void LoadImagesFrom(string path)
        {
            _model.LoadImagePathsFrom(path);
            ShowCurrentImage();
        }

        public void LoadAndShowNextImage()
        {
            _model.MoveToNextImage();
            ShowCurrentImage();
        }

        public void LoadAndShowPreviousImage()
        {
            _model.MoveToPreviousImage();
            ShowCurrentImage();
        }
        
        public void ShowCurrentImage()
        {
            _view.ShowImage(_model.CurrentImagePath);
        }
    }
}
