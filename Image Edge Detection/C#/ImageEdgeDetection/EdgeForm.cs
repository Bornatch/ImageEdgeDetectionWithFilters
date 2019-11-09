﻿using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace ImageEdgeDetection
{
    public partial class EdgeForm : ImageEdgeDetection.TemplateForm
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private String appliedFilter = "";

        public EdgeForm(Bitmap importedImage)
        {
            InitializeComponent();
            originalBitmap = importedImage;
            picPreview.Image = originalBitmap;

            cmbEdgeDetection.SelectedIndex = 0;
        }

        private void ApplyFilter(bool preview)
        {
            //retrieve selected value in drop down list
            String chosenEdgeFilter = cmbEdgeDetection.SelectedItem.ToString();

            //check if the selected edge filter is already applied
            if (appliedFilter.Equals(chosenEdgeFilter))
                return;

            switch (chosenEdgeFilter)
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

        private void btnSaveNewImage_Click(object sender, EventArgs e)
        {
            //open dialog in order to save the modified image
            if (previewBitmap != null)
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
                    previewBitmap.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();

                    previewBitmap = null;
                }
            }
        }

        private void cmbEdgeDetection_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter(true);
        }

        private void btnReturnToFilterForm_Click(object sender, EventArgs e)
        { 
            this.Close();
            Application.OpenForms[0].Show();
        }
    }
}
