/**************************************************************************
 *                                                                        *
 *  File:        MockView.cs                                              *
 *  E-mail:      mircea.dobreanu@gmail.com                                *
 *  Description: Mocking class designed to help with testing of           *
 *              presenter class.                                          *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using ImageLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageLibraryTest
{
    class MockView : IView
    {
        private Presenter _presenter;
        public MockView()
        {
        }

        Presenter IView.Presenter
        {
            get
            {
                return _presenter;
            }

            set
            {
                _presenter = value;
            }
        }

        void IView.ShowImage(string path)
        {
        }
    }
}
