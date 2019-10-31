using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ImageEdgeDetection
{
    public partial class FilterForm : ImageEdgeDetection.TemplateForm
    {
        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;

        private Boolean zenChecked = false;
        private Boolean rainbowChecked = false;

        public FilterForm()
        {
            InitializeComponent();
        }

        private void btnLoadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "Png Images(*.png)|*.png|Jpeg Images(*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images(*.bmp)|*.bmp";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                previewBitmap = originalBitmap.CopyToSquareCanvas(picPreview.Width);
                picPreview.Image = previewBitmap;

                ApplyFilter();
            }

            enableCheckboxes();
        }

        private void ApplyFilter()
        {
            previewBitmap = originalBitmap;

            if (zenChecked)
                previewBitmap = ImageFilters.ZenFilter(previewBitmap, 1, 10, 1, 1);

            if (rainbowChecked)
                previewBitmap = ImageFilters.RainbowFilter(previewBitmap);

            if (zenChecked || rainbowChecked)
                btnOpenEdgeForm.Enabled = true;
            else
                btnOpenEdgeForm.Enabled = false;

            picPreview.Image = previewBitmap;
        }

        private void ckbZenFilter_CheckedChanged(object sender, EventArgs e)
        {
            zenChecked = ckbZenFilter.Checked;
            ApplyFilter();
        }

        private void ckbRainbowFilter_CheckedChanged(object sender, EventArgs e)
        {
            rainbowChecked = ckbRainbowFilter.Checked;
            ApplyFilter();
        }

        private void enableCheckboxes()
        {
            ckbRainbowFilter.Enabled = true;
            ckbZenFilter.Enabled = true;
        }

        private void btnOpenEdgeForm_Click(object sender, EventArgs e)
        {
            // CODE TAKEN FROM STACK OVERFLOW ***
            // URL : https://stackoverflow.com/questions/5548746/c-sharp-open-a-new-form-then-close-the-current-form
            this.Hide();
            var edgeForm = new EdgeForm(previewBitmap);
            edgeForm.Closed += (s, args) => this.Close();
            edgeForm.Show();
            // END OF CODE SNIPPET           
        }
    }
}
