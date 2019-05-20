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

            Assert.AreEqual("one.jpg", m.CurrentImagePath);

            m.moveToNextImage();
            Assert.AreEqual("two.png", m.CurrentImagePath);

            m.moveToNextImage();
            Assert.AreEqual("three.bmp", m.CurrentImagePath);

            m.moveToNextImage();
            Assert.AreEqual("one.jpg", m.CurrentImagePath);
        }

        [TestMethod]
        public void ShouldCyclePathsBackwardsWithAllImages()
        {
            Model m = new Model(new List<string> { "one.jpg", "two.png", "three.bmp" });
            Assert.AreEqual("one.jpg", m.CurrentImagePath);

            m.moveToPreviousImage();
            Assert.AreEqual("three.bmp", m.CurrentImagePath);

            m.moveToPreviousImage();
            Assert.AreEqual("two.png", m.CurrentImagePath);

            m.moveToPreviousImage();
            Assert.AreEqual("one.jpg", m.CurrentImagePath);
        }

        [TestMethod]
        public void ShouldCyclePathsForwardsWithMixedFiles()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void ShouldCyclePathsBackwardsWithMixedFiles()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void ShouldHandleNoImages()
        {
            // TODO: possibly use exception?
            Assert.Fail();
        }

        [TestMethod]
        public void ShouldBeValidImage()
        {
            Assert.Fail();
        }

        [TestMethod]
        public void ShouldBeInvalidImage()
        {
            Assert.Fail();
        }
    }
}