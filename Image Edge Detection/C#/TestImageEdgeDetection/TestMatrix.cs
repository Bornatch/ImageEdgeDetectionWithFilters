using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageEdgeDetection;

namespace TestImageEdgeDetection
{
    [TestClass]
    public class TestMatrix
    {
        [TestMethod]
        public void TestLaplacian3x3()
        {
            double[,] result = new double[,]
                { { -1, -1, -1,  },
                  { -1,  8, -1,  },
                  { -1, -1, -1,  }, };

            Assert.AreEqual(Matrix.Laplacian3x3, result);
        }

        [TestMethod]
        public void TestLaplacian5x5()
        {
            double[,] result = new double[,]
                { { -1, -1, -1, -1, -1, },
                  { -1, -1, -1, -1, -1, },
                  { -1, -1, 24, -1, -1, },
                  { -1, -1, -1, -1, -1, },
                  { -1, -1, -1, -1, -1  }, };

            Assert.AreEqual(Matrix.Laplacian5x5, result);
        }

        [TestMethod]
        public void TestLaplacianOfGaussian()
        {
            double[,] result = new double[,]
                { {  0,   0, -1,  0,  0 },
                  {  0,  -1, -2, -1,  0 },
                  { -1,  -2, 16, -2, -1 },
                  {  0,  -1, -2, -1,  0 },
                  {  0,   0, -1,  0,  0 }, };

            Assert.AreEqual(Matrix.LaplacianOfGaussian, result);
        }

        [TestMethod]
        public void TestGaussian3x3()
        {
            double[,] result = new double[,]
                { { 1, 2, 1, },
                  { 2, 4, 2, },
                  { 1, 2, 1, }, };

            Assert.AreEqual(Matrix.Gaussian3x3, result);
        }

        [TestMethod]
        public void TestGaussian5x5Type1()
        {
            double[,] result = new double[,]
                { { 2, 04, 05, 04, 2 },
                  { 4, 09, 12, 09, 4 },
                  { 5, 12, 15, 12, 5 },
                  { 4, 09, 12, 09, 4 },
                  { 2, 04, 05, 04, 2 }, };

            Assert.AreEqual(Matrix.Gaussian5x5Type1, result);
        }

        [TestMethod]
        public void TestGaussian5x5Type2()
        {
            double[,] result = new double[,]
                { {  1,   4,  6,  4,  1 },
                  {  4,  16, 24, 16,  4 },
                  {  6,  24, 36, 24,  6 },
                  {  4,  16, 24, 16,  4 },
                  {  1,   4,  6,  4,  1 }, };

            Assert.AreEqual(Matrix.Gaussian5x5Type2, result);
        }

        [TestMethod]
        public void TestSobel3x3Horizontal()
        {
            double[,] result = new double[,]
                { { -1,  0,  1, },
                  { -2,  0,  2, },
                  { -1,  0,  1, }, };

            Assert.AreEqual(Matrix.Sobel3x3Horizontal, result);
        }

        [TestMethod]
        public void TestSobel3x3Vertical()
        {
            double[,] result = new double[,]
                { {  1,  2,  1, },
                  {  0,  0,  0, },
                  { -1, -2, -1, }, };

            Assert.AreEqual(Matrix.Sobel3x3Vertical, result);
        }

        [TestMethod]
        public void TestPrewitt3x3Horizontal()
        {
            double[,] result = new double[,]
                { { -1,  0,  1, },
                  { -1,  0,  1, },
                  { -1,  0,  1, }, };

            Assert.AreEqual(Matrix.Prewitt3x3Horizontal, result);
        }

        [TestMethod]
        public void TestPrewitt3x3Vertical()
        {
            double[,] result = new double[,]
                { {  1,  1,  1, },
                  {  0,  0,  0, },
                  { -1, -1, -1, }, };

            Assert.AreEqual(Matrix.Prewitt3x3Vertical, result);
        }

        [TestMethod]
        public void TestKirsch3x3Horizontal()
        {
            double[,] result = new double[,]
                { {  5,  5,  5, },
                  { -3,  0, -3, },
                  { -3, -3, -3, }, };

            Assert.AreEqual(Matrix.Kirsch3x3Horizontal, result);
        }

        [TestMethod]
        public void TestKirsch3x3Vertical()
        {
            double[,] result = new double[,]
                { {  5, -3, -3, },
                  {  5,  0, -3, },
                  {  5, -3, -3, }, };

            Assert.AreEqual(Matrix.Kirsch3x3Vertical, result);
        }
    }
}
