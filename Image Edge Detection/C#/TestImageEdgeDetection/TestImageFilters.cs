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
       
        [TestMethod]
        public void TestRainbowFilter()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = ImageFilters.RainbowFilter(bmp);
            int resultSize = imageResult.Width * imageResult.Height;

            Assert.AreEqual(resultSize, 307200);
        }

        [TestMethod]
        public void TestZenFilter()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = ImageFilters.ZenFilter(bmp, 10, 10, 10, 10);
            int resultSize = imageResult.Width * imageResult.Height;

            Assert.AreEqual(resultSize, 307200);
        }
    }
}
