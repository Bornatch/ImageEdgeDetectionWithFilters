using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageEdgeDetection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestImageEdgeDetection
{
    [TestClass]
    public class TestExtBitmap
    {
        [TestMethod]
        public void TestCopyToSquareCanvas()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = ExtBitmap.CopyToSquareCanvas(bmp, 10);
            int resultSize = imageResult.Width * imageResult.Height;

            Assert.AreEqual(resultSize, 70);
        }
    }
}
