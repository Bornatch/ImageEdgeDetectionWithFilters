/*
 * The Following Code was developed by Dewald Esterhuizen
 * View Documentation at: http://softwarebydefault.com
 * Licensed under Ms-PL 
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ImageEdgeDetection
{
    public partial class EdgeForm : Form
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;
        private String appliedFilter = "";
        
        public EdgeForm()
        {
            InitializeComponent();
            originalBitmap = new Bitmap(@"C:\Users\Nicolas Solioz\Pictures\Cheese Disco 22.07.2017\tree.jpg");
            picPreview.Image = originalBitmap; 

            cmbEdgeDetection.SelectedIndex = 0;
        }

        private void btnSaveNewImage_Click(object sender, EventArgs e)
        {
            //open dialog in order to save the modified image

            resultBitmap = previewBitmap;
            if (resultBitmap != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
                sfd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string fileExtension = Path.GetExtension(sfd.FileName).ToUpper();
                    ImageFormat imgFormat = ImageFormat.Png;

                    if (fileExtension == "BMP")
                    {
                        imgFormat = ImageFormat.Bmp;
                    }
                    else if (fileExtension == "JPG")
                    {
                        imgFormat = ImageFormat.Jpeg;
                    }

                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    resultBitmap.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();

                    resultBitmap = null;
                }
            }
        }

        private void ApplyFilter(bool preview)
        {
            //retrieve selected value in drop down list
            String chosenEdgeFilter = cmbEdgeDetection.SelectedItem.ToString();

            //check if the selected edge filter is already applied
            if (appliedFilter.Equals(chosenEdgeFilter))
                return;

            switch(chosenEdgeFilter)
            {
                case "None":
                    previewBitmap = originalBitmap;
                    break;

                case "Laplacian 3x3":
                    previewBitmap = originalBitmap.Laplacian3x3Filter(false);
                    break;

                case "Laplacian 3x3 Grayscale":
                    previewBitmap = originalBitmap.Laplacian3x3Filter(true);
                    break;

                case "Laplacian 5x5":
                    previewBitmap = originalBitmap.Laplacian5x5Filter(false);
                    break;

                case "Laplacian 5x5 Grayscale":
                    previewBitmap = originalBitmap.Laplacian5x5Filter(true);
                    break;

                case "Laplacian of Gaussian":
                    previewBitmap = originalBitmap.LaplacianOfGaussianFilter();
                    break;

                case "Laplacian 3x3 of Gaussian 3x3":
                    previewBitmap = originalBitmap.Laplacian3x3OfGaussian3x3Filter();
                    break;

                case "Laplacian 3x3 of Gaussian 5x5 - 1":
                    previewBitmap = originalBitmap.Laplacian3x3OfGaussian5x5Filter1();
                    break;

                case "Laplacian 5x5 of Gaussian 3x3":
                    previewBitmap = originalBitmap.Laplacian5x5OfGaussian3x3Filter();
                    break;

                case "Laplacian 5x5 of Gaussian 5x5 - 1":
                    previewBitmap = originalBitmap.Laplacian5x5OfGaussian5x5Filter1();
                    break;

                case "Laplacian 5x5 of Gaussian 5x5 - 2":
                    previewBitmap = originalBitmap.Laplacian5x5OfGaussian5x5Filter2();
                    break;

                case "Sobel 3x3":
                    previewBitmap = originalBitmap.Sobel3x3Filter(false);
                    break;

                case "Sobel 3x3 Grayscale":
                    previewBitmap = originalBitmap.Sobel3x3Filter();
                    break;

                case "Prewitt":
                    previewBitmap = originalBitmap.PrewittFilter(false);
                    break;

                case "Prewitt Grayscale":
                    previewBitmap = originalBitmap.PrewittFilter();
                    break;

                case "Kirsch":
                    previewBitmap = originalBitmap.KirschFilter(false);
                    break;

                case "Kirsch Grayscale":
                    previewBitmap = originalBitmap.KirschFilter();
                    break;
            }

            //refresh preview image
            picPreview.Image = previewBitmap;
            appliedFilter = chosenEdgeFilter;
        }

  
        private void NeighbourCountValueChangedEventHandler(object sender, EventArgs e)
        {
            ApplyFilter(true);
        }

        private void picPreview_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
