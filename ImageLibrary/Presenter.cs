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

        public void loadImagesFrom(string[] files)
        {
            List<string> list = new List<string>();

            foreach (string filePath in files)
            {
                string extension = Path.GetExtension(filePath);
                if (extension.Equals(".jpg", StringComparison.CurrentCultureIgnoreCase))
                {
                    list.Add(filePath);
                    if (_model.CurrentImagePath == null)
                    {
                        _model.CurrentImagePath = filePath;
                        showCurrentImage();
                    }
                }
            }
            this._model.listOfImages = list;
        }

        public void showCurrentImage()
        {
            _view.showImage(_model.CurrentImagePath);
        }

        public void setCurrentImage(string path)
        {
            _model.CurrentImagePath = path;
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
