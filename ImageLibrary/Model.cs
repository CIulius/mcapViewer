using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageLibrary
{
    public class Model : IModel
    {
        private static readonly List<string> ImageExtensions = new List<string> { ".jpg", ".jpe", ".bmp", ".png", ".gif" };

        private string _currentImagePath;
        private List<string> _imagePathsList;

        public Model(List<string> pathsList)
        {
            loadImagePathsFrom(pathsList);
        }

        public Model() : this(new List<string>())
        {
        }

        public List<string> ImagePaths
        {
            get
            {
                return _imagePathsList;
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

        public void loadImagePathsFrom(string path)
        {
            List<string> filePaths = Directory.GetFiles(path).ToList();
            loadImagePathsFrom(filePaths);
        }

        public void loadImagePathsFrom(List<string> filePaths)
        {
            _imagePathsList = new List<string>();
            foreach (string filePath in filePaths)
            {
                if (isImage(filePath))
                {
                    _imagePathsList.Add(filePath);
                    if (CurrentImagePath == null)
                    {
                        CurrentImagePath = filePath;
                    }
                }
            }
        }

        // TODO: maybe move this to its own class?
        public bool isImage(string path)
        {
            string extension = Path.GetExtension(path);
            return ImageExtensions.Contains(extension.ToLowerInvariant());
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