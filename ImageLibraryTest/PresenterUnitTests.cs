/**************************************************************************
 *                                                                        *
 *  File:        PresenterUnitTests.cs                                    *
 *  E-mail:      mircea.dobreanu@gmail.com                                *
 *  Description: Unit tests that check the presenter logic.               *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using ImageLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageLibraryTest
{
    [TestClass]
    public class PresenterUnitTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShouldThrowOnNullFromPresenterConstructor()
        {
            Presenter presenter = new Presenter(null, null);
        }

        [TestMethod]
        public void ShouldWorkWithEmptyListAsModel()
        {
            IView view = new MockView();
            IModel model = new Model();
            Presenter presenter = new Presenter(view, model);

            Assert.IsNull(presenter.CurrentImagePath);
            presenter.LoadAndShowNextImage();
            Assert.IsNull(presenter.CurrentImagePath);
        }

        [TestMethod]
        public void ShouldNumberImagesCorrectly()
        {
            IView view = new MockView();
            IModel model = new Model(new List<string> { "swap", "zero.txt", "one.jpg", "two.txt", "three.bmp", "another.tiff" });

            Presenter presenter = new Presenter(view, model);

            Assert.AreEqual("1/3", presenter.GetCurrentImagePositionInCollection());
            presenter.LoadNextImage().LoadNextImage().LoadNextImage().LoadPreviousImage();

            Assert.AreEqual("3/3", presenter.GetCurrentImagePositionInCollection());
                
        }
    }
}
