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
        private List<string> _imagePathsList;

        public Model(List<string> imagePathsList)
        {
            _currentImagePath = null;
        }

        public Model() : this(new List<string>())
        {
        }

        public List<string> listOfImages
        {
            get
            {
                return _imagePathsList;
            }

            set
            {
                this._imagePathsList = value;
            }
        }

        public string CurrentImagePath
        {
            get
            {
                return _currentImagePath;
            }
            set
            {
                _currentImagePath = value;
            }
        }

        public void moveToNextImage()
        {
            int index = -1;
            bool found = false;

            while (index < _imagePathsList.Count && found != true)
            {
                index++;

                if (_imagePathsList[index].Equals(_currentImagePath))
                {
                    index++;
                    index %= _imagePathsList.Count;

                    _currentImagePath = _imagePathsList[index];
                    found = true;
                }
            }
        }

        public void moveToPreviousImage()
        {
            int index = _imagePathsList.Count;
            bool finded = false;

            while (index > 0 && finded != true)
            {
                index--;

                if (_imagePathsList[index].Equals(_currentImagePath))
                {
                    index--;
                    if (index < 0)
                    {
                        index = _imagePathsList.Count - 1;
                    }
                    _currentImagePath = _imagePathsList[index];
                    finded = true;
                }
            }
        }
    }
}