/**************************************************************************
 *                                                                        *
 *  File:        Model.cs                                                 *
 *  E-mail:      brinzapaul@gmail.com                                     *
 *  Description: The concrete model (data representation) of the image    *
 *               viewing   application.                                   *
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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageLibrary
{
    public class Model : IModel
    {
        private static readonly List<string> ImageExtensions = new List<string> { ".jpg", ".jpe", ".jpeg", ".bmp", ".png", ".gif", ".tiff", ".tif", ".ico" };
        
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

        public int CurrentImageIndex
        {
            get 
            { 
                return _imagePathsList.IndexOf(_currentImagePath); 
            }
        }

        public int CurrentCollectionSize
        {
            get
            {
                return _imagePathsList.Count; 
            }
        }

        /**
         * <summary>This function loads images from a path.</summary> 
         */
        public void LoadImagePathsFrom(string path)
        {
            List<string> filePaths = Directory.GetFiles(path).ToList();
            LoadImagePathsFrom(filePaths);
        }

        public void LoadImagePathsFrom(List<string> filePaths)
        {
            _imagePathsList = new List<string>();
            CurrentImagePath = null;

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

        /**
         * <summary>This function specifies if a path points to an image.</summary> 
         */
        public static bool IsImage(string path)
        {
            if (path == null)
            {
                return false;
            }

            try
            {
                string extension = Path.GetExtension(path);
                return ImageExtensions.Contains(extension.ToLowerInvariant());
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        /**
         * <summary>This function moves the iterator to the next image.</summary> 
         */
        public IModel MoveToNextImage()
        {
            int index = -1;
            bool found = false;

            while (index < _imagePathsList.Count && found != true)
            {
                index++;

                if (index < _imagePathsList.Count && _imagePathsList[index].Equals(_currentImagePath))
                {
                    index++;
                    index %= _imagePathsList.Count;

                    _currentImagePath = _imagePathsList[index];
                    found = true;
                }
            }

            return this;
        }

        /**
         * <summary>This function moves the iterator to the previous image.</summary> 
         */
        public IModel MoveToPreviousImage()
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

            return this;
        }
    }
}