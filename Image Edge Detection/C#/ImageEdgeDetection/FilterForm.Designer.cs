namespace ImageEdgeDetection
{
    partial class FilterForm
    {
        private void InitializeComponent()
        {
            this.btnOpenEdgeForm = new System.Windows.Forms.Button();
            this.btnLoadImg = new System.Windows.Forms.Button();
            this.ckbZenFilter = new System.Windows.Forms.CheckBox();
            this.ckbRainbowFilter = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.Image = global::ImageEdgeDetection.Properties.Resources.loadImg;
            this.picPreview.Click += new System.EventHandler(this.picPreview_Click);
            // 
            // btnOpenEdgeForm
            // 
            this.btnOpenEdgeForm.Enabled = false;
            this.btnOpenEdgeForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenEdgeForm.Location = new System.Drawing.Point(500, 618);
            this.btnOpenEdgeForm.Name = "btnOpenEdgeForm";
            this.btnOpenEdgeForm.Size = new System.Drawing.Size(112, 53);
            this.btnOpenEdgeForm.TabIndex = 14;
            this.btnOpenEdgeForm.Text = "Next...";
            this.btnOpenEdgeForm.UseVisualStyleBackColor = true;
            this.btnOpenEdgeForm.Click += new System.EventHandler(this.btnOpenEdgeForm_Click);
            // 
            // btnLoadImg
            // 
            this.btnLoadImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImg.Location = new System.Drawing.Point(12, 618);
            this.btnLoadImg.Name = "btnLoadImg";
            this.btnLoadImg.Size = new System.Drawing.Size(112, 53);
            this.btnLoadImg.TabIndex = 15;
            this.btnLoadImg.Text = "Load Image";
            this.btnLoadImg.UseVisualStyleBackColor = true;
            this.btnLoadImg.Click += new System.EventHandler(this.btnLoadImg_Click);
            // 
            // ckbZenFilter
            // 
            this.ckbZenFilter.AutoSize = true;
            this.ckbZenFilter.Enabled = false;
            this.ckbZenFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbZenFilter.Location = new System.Drawing.Point(141, 631);
            this.ckbZenFilter.Name = "ckbZenFilter";
            this.ckbZenFilter.Size = new System.Drawing.Size(173, 41);
            this.ckbZenFilter.TabIndex = 16;
            this.ckbZenFilter.Text = "Zen filter";
            this.ckbZenFilter.UseVisualStyleBackColor = true;
            this.ckbZenFilter.CheckedChanged += new System.EventHandler(this.ckbZenFilter_CheckedChanged);
            // 
            // ckbRainbowFilter
            // 
            this.ckbRainbowFilter.AutoSize = true;
            this.ckbRainbowFilter.Enabled = false;
            this.ckbRainbowFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbRainbowFilter.Location = new System.Drawing.Point(317, 631);
            this.ckbRainbowFilter.Name = "ckbRainbowFilter";
            this.ckbRainbowFilter.Size = new System.Drawing.Size(242, 41);
            this.ckbRainbowFilter.TabIndex = 17;
            this.ckbRainbowFilter.Text = "Rainbow filter";
            this.ckbRainbowFilter.UseVisualStyleBackColor = true;
            this.ckbRainbowFilter.CheckedChanged += new System.EventHandler(this.ckbRainbowFilter_CheckedChanged);
            // 
            // FilterForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 675);
            this.Controls.Add(this.ckbRainbowFilter);
            this.Controls.Add(this.ckbZenFilter);
            this.Controls.Add(this.btnLoadImg);
            this.Controls.Add(this.btnOpenEdgeForm);
            this.Name = "FilterForm";
            this.Text = "Filter application";
            this.Controls.SetChildIndex(this.picPreview, 0);
            this.Controls.SetChildIndex(this.btnOpenEdgeForm, 0);
            this.Controls.SetChildIndex(this.btnLoadImg, 0);
            this.Controls.SetChildIndex(this.ckbZenFilter, 0);
            this.Controls.SetChildIndex(this.ckbRainbowFilter, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btnOpenEdgeForm;
        private System.Windows.Forms.Button btnLoadImg;
        private System.Windows.Forms.CheckBox ckbZenFilter;
        private System.Windows.Forms.CheckBox ckbRainbowFilter;
    }
}
