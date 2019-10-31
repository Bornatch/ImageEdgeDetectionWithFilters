namespace ImageEdgeDetection
{
    partial class EdgeForm
    {
        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.cmbEdgeDetection = new System.Windows.Forms.ComboBox();
            this.btnReturnToFilterForm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(487, 618);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(125, 45);
            this.btnSaveNewImage.TabIndex = 14;
            this.btnSaveNewImage.Text = "Save";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // cmbEdgeDetection
            // 
            this.cmbEdgeDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdgeDetection.FormattingEnabled = true;
            this.cmbEdgeDetection.Items.AddRange(new object[] {
            "None",
            "Laplacian 3x3",
            "Laplacian 3x3 Grayscale",
            "Laplacian 5x5",
            "Laplacian 5x5 Grayscale",
            "Laplacian of Gaussian",
            "Laplacian 3x3 of Gaussian 3x3",
            "Laplacian 3x3 of Gaussian 5x5 - 1",
            "Laplacian 3x3 of Gaussian 5x5 - 2",
            "Laplacian 5x5 of Gaussian 3x3",
            "Laplacian 5x5 of Gaussian 5x5 - 1",
            "Laplacian 5x5 of Gaussian 5x5 - 2",
            "Sobel 3x3",
            "Sobel 3x3 Grayscale",
            "Prewitt",
            "Prewitt Grayscale",
            "Kirsch",
            "Kirsch Grayscale"});
            this.cmbEdgeDetection.Location = new System.Drawing.Point(158, 625);
            this.cmbEdgeDetection.Name = "cmbEdgeDetection";
            this.cmbEdgeDetection.Size = new System.Drawing.Size(314, 28);
            this.cmbEdgeDetection.TabIndex = 15;
            this.cmbEdgeDetection.SelectedIndexChanged += new System.EventHandler(this.cmbEdgeDetection_SelectedIndexChanged);
            // 
            // btnReturnToFilterForm
            // 
            this.btnReturnToFilterForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnToFilterForm.Location = new System.Drawing.Point(12, 618);
            this.btnReturnToFilterForm.Name = "btnReturnToFilterForm";
            this.btnReturnToFilterForm.Size = new System.Drawing.Size(125, 45);
            this.btnReturnToFilterForm.TabIndex = 16;
            this.btnReturnToFilterForm.Text = "Back...";
            this.btnReturnToFilterForm.UseVisualStyleBackColor = true;
            this.btnReturnToFilterForm.Click += new System.EventHandler(this.btnReturnToFilterForm_Click);
            // 
            // EdgeForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 675);
            this.Controls.Add(this.btnReturnToFilterForm);
            this.Controls.Add(this.cmbEdgeDetection);
            this.Controls.Add(this.btnSaveNewImage);
            this.Name = "EdgeForm";
            this.Text = "Edge Detection";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EdgeForm_FormClosed);
            this.Controls.SetChildIndex(this.btnSaveNewImage, 0);
            this.Controls.SetChildIndex(this.cmbEdgeDetection, 0);
            this.Controls.SetChildIndex(this.btnReturnToFilterForm, 0);
            this.Controls.SetChildIndex(this.picPreview, 0);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbEdgeDetection;
        private System.Windows.Forms.Button btnReturnToFilterForm;
    }
}
