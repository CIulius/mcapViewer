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

        public void loadImages(string[] files)
        {
            List<string> list = new List<string>();

            foreach (string s in files)
            {
                if (s.Split('.')[1] == "jpg")
                {
                    list.Add(s);
                }
            }
            this._model.listOfImages = list;
        }

        public void getCurrentImage()
        {
            _view.imagePath = _model.getCurrentImage();
        }
        public void setCurrentImage()
        {
            _model.setCurrentImage();
        }

        public void nextImage()
        {
            _model.showNextImage();
        }

        public void previousImage()
        {
            _model.showPreviousImage();
        }
    }
}
