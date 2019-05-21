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

        private IEnumerator<string> _currentImagePathEnumerator;

        private string _currentImagePath;
        private List<string> _imagePathsList;

        public Model(List<string> pathsList)
        {
            LoadImagePathsFrom(pathsList);
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

        public void LoadImagePathsFrom(string path)
        {
            List<string> filePaths = Directory.GetFiles(path).ToList();
            LoadImagePathsFrom(filePaths);
        }

        public void LoadImagePathsFrom(List<string> filePaths)
        {
            _imagePathsList = new List<string>();
            foreach (string filePath in filePaths)
            {
                if (IsImage(filePath))
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
        public bool IsImage(string path)
        {
            string extension = Path.GetExtension(path);
            return ImageExtensions.Contains(extension.ToLowerInvariant());
        }

        public void MoveToNextImage()
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

        public void MoveToPreviousImage()
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