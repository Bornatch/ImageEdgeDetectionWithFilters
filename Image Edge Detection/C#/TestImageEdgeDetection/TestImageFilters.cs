using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using ImageEdgeDetection;

namespace TestImageEdgeDetection
{
    [TestClass]
    public class TestImageFilters
    {

        //zenfilter tests
        [TestMethod]
        public void TestZenFilterAlpha()
        {
            Bitmap init = new Bitmap("C:/Users/Bornatch/Documents/GitHub/ImageEdgeDetectionWithFilters/Image Edge Detection/C#/ImageEdgeDetection/Resources/loadImg.png");

            Bitmap value = ImageFilters.ZenFilter(init, -1, 10, 1, 1);

            int control = 7878550;// ImageFilters.ZenFilter(init, 1, 10, 1, 1).GetHashCode();

            Assert.AreEqual(value.GetHashCode(), control);

        }

        [TestMethod]
        public void TestZenFilterRed()
        {
            Bitmap init = new Bitmap("C:/Users/Bornatch/Documents/GitHub/ImageEdgeDetectionWithFilters/Image Edge Detection/C#/ImageEdgeDetection/Resources/loadImg.png");

            Bitmap value = ImageFilters.ZenFilter(init, 1, -1, 1, 1);

            int control = 7878550;

            Assert.AreEqual(value.GetHashCode(), control);

        }

        [TestMethod]
        public void TestZenFilterBlue()
        {
            Bitmap init = new Bitmap("C:/Users/Bornatch/Documents/GitHub/ImageEdgeDetectionWithFilters/Image Edge Detection/C#/ImageEdgeDetection/Resources/loadImg.png");

            Bitmap value = ImageFilters.ZenFilter(init, 1, 10, 0, 1);

            int control = 7878550;// ImageFilters.ZenFilter(init, 1, 10, 1, 1).GetHashCode();

            Assert.AreEqual(value.GetHashCode(), control);

        }

        [TestMethod]
        public void TestZenFilterGreen()
        {
            Bitmap init = new Bitmap("C:/Users/Bornatch/Documents/GitHub/ImageEdgeDetectionWithFilters/Image Edge Detection/C#/ImageEdgeDetection/Resources/loadImg.png");

            Bitmap value = ImageFilters.ZenFilter(init, 1, 1, 10, -1);

            int control = 7878550;// ImageFilters.ZenFilter(init, 1, 1, 10, 1).GetHashCode();

            Assert.AreEqual(value.GetHashCode(), control);

        }

        //Rainbow Filter test
        [TestMethod]
        public void TestRainbowFilter()
        {
            Bitmap init = new Bitmap("C:/Users/Bornatch/Documents/GitHub/ImageEdgeDetectionWithFilters/Image Edge Detection/C#/ImageEdgeDetection/Resources/loadImg.png");

            Bitmap value = ImageFilters.RainbowFilter(init);

            int control = 7878550;

            Assert.AreEqual(value.GetHashCode(), control);

        }
    }
}
