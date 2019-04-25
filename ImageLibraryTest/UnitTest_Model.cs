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
            Assert.AreEqual(m.Path, "one");

            m.showNextImage();
            Assert.AreEqual(m.Path, "two");

            m.showNextImage();
            Assert.AreEqual(m.Path, "three");

            m.showNextImage();
            Assert.AreEqual(m.Path, "one");
        }

        [TestMethod]
        public void Test_showPreviousImageMethod()
        {
            Model m = new Model();
            Assert.AreEqual(m.Path, "one");

            m.showPreviousImage();
            Assert.AreEqual(m.Path, "three");

            m.showPreviousImage();
            Assert.AreEqual(m.Path, "two");

            m.showPreviousImage();
            Assert.AreEqual(m.Path, "one");
        }
    }
}