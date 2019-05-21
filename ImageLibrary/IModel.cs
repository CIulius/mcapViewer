using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageLibrary
{
    public interface IModel
    {
        void MoveToNextImage();
        void MoveToPreviousImage();
        string CurrentImagePath { get; set; }
        List<string> ImagePaths { get; }
        void LoadImagePathsFrom(string path);
    }
}