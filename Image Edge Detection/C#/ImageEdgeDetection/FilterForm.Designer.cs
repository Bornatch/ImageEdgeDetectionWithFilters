using System.Windows.Forms;

namespace ImageEdgeDetection
{
    partial class FilterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.cmbEdgeDetection = new System.Windows.Forms.ComboBox();
            this.ckbFilterZen = new System.Windows.Forms.CheckBox();
            this.ckbFilterRainbow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(600, 600);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenOriginal.Location = new System.Drawing.Point(12, 618);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(150, 46);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load Image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(462, 618);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(150, 46);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            // 
            // cmbEdgeDetection
            // 
            this.cmbEdgeDetection.Location = new System.Drawing.Point(0, 0);
            this.cmbEdgeDetection.Name = "cmbEdgeDetection";
            this.cmbEdgeDetection.Size = new System.Drawing.Size(121, 21);
            this.cmbEdgeDetection.TabIndex = 0;
            // 
            // ckbFilterZen
            // 
            this.ckbFilterZen.AutoSize = true;
            this.ckbFilterZen.Location = new System.Drawing.Point(168, 620);
            this.ckbFilterZen.Name = "ckbFilterZen";
            this.ckbFilterZen.Size = new System.Drawing.Size(67, 17);
            this.ckbFilterZen.TabIndex = 17;
            this.ckbFilterZen.Text = "FilterZen";
            this.ckbFilterZen.UseVisualStyleBackColor = true;
            this.ckbFilterZen.CheckedChanged += new System.EventHandler(this.ckbFilterZen_CheckedChanged);
            // 
            // ckbFilterRainbow
            // 
            this.ckbFilterRainbow.AutoSize = true;
            this.ckbFilterRainbow.Location = new System.Drawing.Point(310, 620);
            this.ckbFilterRainbow.Name = "ckbFilterRainbow";
            this.ckbFilterRainbow.Size = new System.Drawing.Size(93, 17);
            this.ckbFilterRainbow.TabIndex = 17;
            this.ckbFilterRainbow.Text = "Filter Rainbow";
            this.ckbFilterRainbow.UseVisualStyleBackColor = true;
            this.ckbFilterRainbow.CheckedChanged += new System.EventHandler(this.ckbFilterRainbow_CheckedChanged);
            // 
            // FilterForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(624, 675);
            this.Controls.Add(this.ckbFilterZen);
            this.Controls.Add(this.ckbFilterRainbow);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenOriginal);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apply at least one filter";
            this.Load += new System.EventHandler(this.FilterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picPreview;
        private Button btnOpenOriginal;
        private Button btnSaveNewImage;
        private ComboBox cmbEdgeDetection;
        //create filter checkbox and textbox
        private CheckBox ckbFilterZen;        
        private CheckBox ckbFilterRainbow;
        
       
    }
}

