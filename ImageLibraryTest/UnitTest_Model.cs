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
            Assert.AreEqual(m.getCurrentImage(), "one");

            m.showNextImage();
            Assert.AreEqual(m.getCurrentImage(), "two");

            m.showNextImage();
            Assert.AreEqual(m.getCurrentImage(), "three");

            m.showNextImage();
            Assert.AreEqual(m.getCurrentImage(), "one");
        }

        [TestMethod]
        public void Test_showPreviousImageMethod()
        {
            Model m = new Model();
            Assert.AreEqual(m.getCurrentImage(), "one");

            m.showPreviousImage();
            Assert.AreEqual(m.getCurrentImage(), "three");

            m.showPreviousImage();
            Assert.AreEqual(m.getCurrentImage(), "two");

            m.showPreviousImage();
            Assert.AreEqual(m.getCurrentImage(), "one");
        }
    }
}