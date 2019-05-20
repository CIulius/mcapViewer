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

        public void loadImagesFrom(string path)
        {
            _model.loadImagePathsFrom(path);
            showCurrentImage();
        }

        public void showCurrentImage()
        {
            _view.showImage(_model.CurrentImagePath);
        }

        public void loadAndShowNextImage()
        {
            _model.moveToNextImage();
            showCurrentImage();
        }

        public void loadAndShowPreviousImage()
        {
            _model.moveToPreviousImage();
            showCurrentImage();
        }
    }
}
