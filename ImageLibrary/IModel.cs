/**************************************************************************
 *                                                                        *
 *  File:        IModel.cs                                                 *
 *  E-mail:      brinzapaul@gmail.com                                     *
 *  Description: The abstract model (data representation) of the image    *
 *               viewing application.                                     *
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
        int CurrentImageIndex { get; }
        int CurrentCollectionSize { get; }
        List<string> ImagePaths { get; }
        void LoadImagePathsFrom(string path);
    }
}