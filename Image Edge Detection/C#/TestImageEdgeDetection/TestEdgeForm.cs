using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageEdgeDetection;
using System.Drawing;

namespace TestImageEdgeDetection
{
    [TestClass]
    public class TestEdgeForm
    {
        //void methods : check if throws error 

        [TestMethod]
        public void TestApplyFilter()
        {
            try
            {
                Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
                EdgeForm MyForm = new EdgeForm(bmp);
                MyForm.ApplyFilter(true);
            }
            catch(Exception e) { 
                throw e;
            }
        }

        [TestMethod]
        public void TestbtnSaveNewImage_Click()
        {
            try
            {
                Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
                EdgeForm MyForm = new EdgeForm(bmp);
                MyForm.btnSaveNewImage_Click(null,null);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        [TestMethod]
        public void TestcmbEdgeDetection_SelectedIndexChanged()
        {
            try
            {
                Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
                EdgeForm MyForm = new EdgeForm(bmp);
                MyForm.cmbEdgeDetection_SelectedIndexChanged(null, null);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        [TestMethod]
        public void TestbtnReturnToFilterForm_Click()
        {
            try 
            {
                Bitmap bmp = new Bitmap("C:/Users/Nicolas Solioz/Pictures/Cheese Disco 22.07.2017/tree.jpg");
                EdgeForm MyForm = new EdgeForm(bmp);
                MyForm.btnReturnToFilterForm_Click(null, null);
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
