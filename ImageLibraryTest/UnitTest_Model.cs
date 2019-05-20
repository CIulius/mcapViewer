using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageLibrary;

namespace ImageLibraryTest
{
    [TestClass]
    public class UnitTest_Model
    {
        [TestMethod]
        public void Test_showNextImageMethod()
        {
            Model m = new Model();
            Assert.AreEqual(m.CurrentImagePath, "one");

            m.moveToNextImage();
            Assert.AreEqual(m.CurrentImagePath, "two");

            m.moveToNextImage();
            Assert.AreEqual(m.CurrentImagePath, "three");

            m.moveToNextImage();
            Assert.AreEqual(m.CurrentImagePath, "one");
        }

        [TestMethod]
        public void Test_showPreviousImageMethod()
        {
            Model m = new Model();
            Assert.AreEqual(m.CurrentImagePath, "one");

            m.moveToPreviousImage();
            Assert.AreEqual(m.CurrentImagePath, "three");

            m.moveToPreviousImage();
            Assert.AreEqual(m.CurrentImagePath, "two");

            m.moveToPreviousImage();
            Assert.AreEqual(m.CurrentImagePath, "one");
        }
    }
}