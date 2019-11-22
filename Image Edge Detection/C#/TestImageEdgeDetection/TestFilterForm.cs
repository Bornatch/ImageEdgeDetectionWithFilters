using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageEdgeDetection;
using System.Drawing;

namespace TestImageEdgeDetection
{
    /// <summary>
    /// Description résumée pour TestFilterForm
    /// </summary>
    [TestClass]
    public class TestFilterForm
    {
        [TestMethod]
        public void TestbtnLoadImg_Click()
        {
            try
            {
                Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
                FilterForm MyForm = new FilterForm(bmp);

                MyForm.btnLoadImg_Click(null, null);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        [TestMethod]
        public void TestApplyFilter()
        {
            try
            {
                Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
                FilterForm MyForm = new FilterForm(bmp);

                MyForm.ApplyFilter();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [TestMethod]
        public void TestckbZenFilter_CheckedChanged()
        {
            try
            {
                Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
                FilterForm MyForm = new FilterForm(bmp);

                MyForm.ckbRainbowFilter_CheckedChanged(null, null);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [TestMethod]
        public void TestckbRainbowFilter_CheckedChanged()
        {
            try
            {
                Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
                FilterForm MyForm = new FilterForm(bmp);

                MyForm.ckbRainbowFilter_CheckedChanged(null, null);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [TestMethod]
        public void TestenableCheckboxes()
        {
            try
            {
                Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
                FilterForm MyForm = new FilterForm(bmp);

                MyForm.enableCheckboxes();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        [TestMethod]
        public void TestbtnOpenEdgeForm_Click()
        {
            try
            {
                Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
                FilterForm MyForm = new FilterForm(bmp);

                MyForm.btnOpenEdgeForm_Click(null, null);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
