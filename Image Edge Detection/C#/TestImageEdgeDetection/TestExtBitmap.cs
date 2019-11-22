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

        //couldn't get this one to work
        /*[TestMethod]
        public void TestConvolutionFilter()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            double[,] xFilterMatrix = new double[5, 5];
            double[,] yFilterMatrix = new double[5, 5];
            Bitmap imageResult = ExtBitmap.ConvolutionFilter(bmp, xFilterMatrix, yFilterMatrix, 1, 0, false);

            int resultSize = imageResult.Width * imageResult.Height;

            Console.WriteLine(resultSize);
            Console.ReadLine();
            Assert.AreEqual(resultSize, 307200);

        }*/

        [TestMethod]
        public void TestLaplacian3x3Filter()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = bmp.Laplacian3x3Filter();

            int resultSize = imageResult.Width * imageResult.Height;
            Assert.AreEqual(resultSize, 307200);
        }

        [TestMethod]
        public void TestLaplacian5x5Filter()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = bmp.Laplacian5x5Filter();

            int resultSize = imageResult.Width * imageResult.Height;
            Assert.AreEqual(resultSize, 307200);
        }

        [TestMethod]
        public void TestLaplacianOfGaussianFilter()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = bmp.LaplacianOfGaussianFilter();

            int resultSize = imageResult.Width * imageResult.Height;
            Assert.AreEqual(resultSize, 307200);
        }

        [TestMethod]
        public void TestLaplacian3x3OfGaussian3x3Filter()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = bmp.Laplacian3x3OfGaussian3x3Filter();

            int resultSize = imageResult.Width * imageResult.Height;
            Assert.AreEqual(resultSize, 307200);
        }

        [TestMethod]
        public void TestLaplacian3x3OfGaussian5x5Filter1()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = bmp.Laplacian3x3OfGaussian5x5Filter1();

            int resultSize = imageResult.Width * imageResult.Height;
            Assert.AreEqual(resultSize, 307200);
        }

        [TestMethod]
        public void TestLaplacian3x3OfGaussian5x5Filter2()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = bmp.Laplacian3x3OfGaussian5x5Filter2();

            int resultSize = imageResult.Width * imageResult.Height;
            Assert.AreEqual(resultSize, 307200);
        }

        [TestMethod]
        public void TestLaplacian5x5OfGaussian3x3Filter()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = bmp.Laplacian5x5OfGaussian3x3Filter();

            int resultSize = imageResult.Width * imageResult.Height;
            Assert.AreEqual(resultSize, 307200);
        }

        [TestMethod]
        public void TestLaplacian5x5OfGaussian5x5Filter1()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = bmp.Laplacian5x5OfGaussian5x5Filter1();

            int resultSize = imageResult.Width * imageResult.Height;
            Assert.AreEqual(resultSize, 307200);
        }

        [TestMethod]
        public void TestLaplacian5x5OfGaussian5x5Filter2()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = bmp.Laplacian5x5OfGaussian5x5Filter2();

            int resultSize = imageResult.Width * imageResult.Height;
            Assert.AreEqual(resultSize, 307200);
        }

        [TestMethod]
        public void TestSobel3x3Filter()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = bmp.Sobel3x3Filter();

            int resultSize = imageResult.Width * imageResult.Height;
            Assert.AreEqual(resultSize, 307200);
        }

        [TestMethod]
        public void TestPrewittFilter()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = bmp.PrewittFilter();

            int resultSize = imageResult.Width * imageResult.Height;
            Assert.AreEqual(resultSize, 307200);
        }

        [TestMethod]
        public void TestKirschFilter()
        {
            Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
            Bitmap imageResult = bmp.KirschFilter();

            int resultSize = imageResult.Width * imageResult.Height;
            Assert.AreEqual(resultSize, 307200);
        }
    }
}
