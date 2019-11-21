using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageEdgeDetection;
using System.Drawing;

namespace TestImageEdgeDetection
{
    [TestClass]
    public class TestImageFilter
    {
        [TestMethod]
        public void TestZenInputParam()
        {
            Bitmap bitmap = new Bitmap("");

            ImageFilters.ZenFilter(bitmap, -1, 1, 1, 1);
        }
    }
}
