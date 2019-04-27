using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageLibrary
{
    public class Model : IModel
    {
        private string _currentImagePath;
        private List<string> _imagesList;

        public Model()
        {
            _imagesList = new List<string>();
            _currentImagePath = "";
        }

        public List<string> listOfImages
        {
            get
            {
                return _imagesList;
            }

            set
            {
                this._imagesList = value;
            }
        }

        public void showNextImage()
        {
            int index = -1;
            bool finded = false;

            while (index < _imagesList.Count && finded != true)
            {
                index++;

                if (_imagesList[index].Equals(_currentImagePath))
                {
                    index++;
                    index %= _imagesList.Count;

                    _currentImagePath = _imagesList[index];
                    finded = true;
                }
            }
        }

        public void showPreviousImage()
        {
            int index = _imagesList.Count;
            bool finded = false;

            while (index > 0 && finded != true)
            {
                index--;

                if (_imagesList[index].Equals(_currentImagePath))
                {
                    index--;
                    if (index < 0)
                    {
                        index = _imagesList.Count - 1;
                    }
                    _currentImagePath = _imagesList[index];
                    finded = true;
                }
            }
        }

        public string getCurrentImage()
        {
            return _currentImagePath;
        }

        public void setCurrentImage()
        {
            _currentImagePath = _imagesList[0];
        }
    }
}