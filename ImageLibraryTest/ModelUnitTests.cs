/**************************************************************************
 *                                                                        *
 *  File:        ModelUnitTests.cs                                        *
 *  E-mail:      mircea.dobreanu@gmail.com                                *
 *  Description: Unit tests that check the model logic.                   *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageLibrary;
using System.Collections.Generic;

namespace ImageLibraryTest
{
    [TestClass]
    public class ModelUnitTests
    {
        [TestMethod]
        public void ShouldCyclePathsForwardsWithAllImages()
        {
            Model m = new Model(new List<string> { "one.jpg", "two.png", "three.bmp" });

            m.MoveToNextImage().MoveToNextImage().MoveToNextImage();
            Assert.AreEqual("one.jpg", m.CurrentImagePath);
        }

        [TestMethod]
        public void ShouldCyclePathsBackwardsWithAllImages()
        {
            Model m = new Model(new List<string> { "one.jpg", "two.png", "three.bmp" });

            m.MoveToPreviousImage().MoveToPreviousImage().MoveToPreviousImage();
            Assert.AreEqual("one.jpg", m.CurrentImagePath);
        }

        [TestMethod]
        public void ShouldIterateForwardsWithMixedFiles()
        {
            Model m = new Model(new List<string> { "one.jpg", "two.txt", "three.bmp" });

            m.MoveToNextImage();
            Assert.AreEqual("three.bmp", m.CurrentImagePath);
        }

        [TestMethod]
        public void ShouldCyclePathsForwardsWithMixedFiles()
        {
            Model m = new Model(new List<string> { "zero.txt", "one.jpg", "two.txt", "three.bmp" });


            m.MoveToNextImage().MoveToNextImage();
            Assert.AreEqual("one.jpg", m.CurrentImagePath);
        }

        [TestMethod]
        public void ShouldCyclePathsBackwardsWithMixedFiles()
        {
            Model m = new Model(new List<string> { "zero.txt", "one.jpg", "two.txt", "three.bmp" });

            m.MoveToPreviousImage().MoveToPreviousImage();
            Assert.AreEqual("one.jpg", m.CurrentImagePath);
        }

        [TestMethod]
        public void ShouldCycleBothWaysWithMixedFiles()
        {
            Model m = new Model(new List<string> { "swap", "zero.txt", "one.jpg", "two.txt", "three.bmp" });
            m.MoveToNextImage().MoveToNextImage().MoveToNextImage().MoveToNextImage();
            m.MoveToPreviousImage().MoveToPreviousImage().MoveToPreviousImage();
            Assert.AreEqual("three.bmp", m.CurrentImagePath);
            
        }

        [TestMethod]
        public void ShouldHandleNoImages()
        {
            IModel m = new Model();
            m.MoveToNextImage().MoveToNextImage();

            Assert.IsNull(m.CurrentImagePath);
        }

        [TestMethod]
        public void ShouldBeValidImageJPG()
        {
            Assert.IsTrue(Model.IsImage("abcd.jpg"));
            Assert.IsTrue(Model.IsImage("defg.JpG"));
            Assert.IsTrue(Model.IsImage("xzvxzcv.erqw.jPG"));
            Assert.IsTrue(Model.IsImage("bncnbc.jpeg"));
            Assert.IsTrue(Model.IsImage("dhfefg.JpeG"));
            Assert.IsTrue(Model.IsImage("rewttwer.sdaf.gf.jPeG"));
        }

        [TestMethod]
        public void ShouldBeValidImageTiff()
        {
            Assert.IsTrue(Model.IsImage("cxvz.tiff"));
            Assert.IsTrue(Model.IsImage("defg.Tiff"));
            Assert.IsTrue(Model.IsImage("xzvxzcv.erqw.TiF"));
            Assert.IsTrue(Model.IsImage("bncnbc.Tiff"));
            Assert.IsTrue(Model.IsImage("dhfefg.tIFF"));
            Assert.IsTrue(Model.IsImage("rewttwer.sdaf.gf.jPeG"));
        }

        [TestMethod]
        public void ShouldBeValidImageGIF()
        {
            Assert.IsTrue(Model.IsImage("abcd.gif"));
            Assert.IsTrue(Model.IsImage("defg.GIF"));
            Assert.IsTrue(Model.IsImage("xzvxzcv.erqw.GiF"));
        }

        [TestMethod]
        public void ShouldBeValidImageICO()
        {
            Assert.IsTrue(Model.IsImage("mgfhyer.ico"));
            Assert.IsTrue(Model.IsImage("xchghdfg.ICO"));
            Assert.IsTrue(Model.IsImage("treqwtqt.erqw.iCO"));
        }

        [TestMethod]
        public void ShouldBeValidImagePNG()
        {
            Assert.IsTrue(Model.IsImage("fdgsdg.PNG"));
            Assert.IsTrue(Model.IsImage("zcvb.pNG"));
            Assert.IsTrue(Model.IsImage("wetrwet.erqw.pnG"));
        }
        [TestMethod]
        public void ShouldBeValidImageBMP()
        {
            Assert.IsTrue(Model.IsImage("abcd.bmp"));
            Assert.IsTrue(Model.IsImage("defg.BMP"));
            Assert.IsTrue(Model.IsImage(".erqw.bMP"));
        }

        [TestMethod]
        public void ShouldBeInvalidImageWithNormalFiles()
        {
            Assert.IsFalse(Model.IsImage("gameofthroness08e06.mkv"));
            Assert.IsFalse(Model.IsImage("swap.swap"));
            Assert.IsFalse(Model.IsImage("cmd.exe"));
            Assert.IsFalse(Model.IsImage("svchost.exe"));
        }


        [TestMethod]
        private void ShouldBeInvalidContainingValidSubstring()
        {
            Assert.IsFalse(Model.IsImage(".jpg.sadf.exe"));
            Assert.IsFalse(Model.IsImage(".jpeg.re.exe"));
            Assert.IsFalse(Model.IsImage(".TiFF.txt"));
            Assert.IsFalse(Model.IsImage(".jp.g.gitignore"));
        }

        [TestMethod]
        public void ShouldBeInvalidImageWithBlank()
        {
            Assert.IsFalse(Model.IsImage("   \t"));
        }

        [TestMethod]
        public void ShouldBeInvalidImageWithEmpty()
        {
            Assert.IsFalse(Model.IsImage(string.Empty));
        }

        [TestMethod]
        public void ShouldBeInvalidImageWithNull()
        {
            Assert.IsFalse(Model.IsImage(null));
        }
    }
}