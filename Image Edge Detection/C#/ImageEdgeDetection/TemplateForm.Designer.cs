using System.Windows.Forms;
using System.Drawing;

namespace ImageEdgeDetection
{
    partial class TemplateForm
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
            this.picPreview = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.AccessibleName = "picPreview";
            this.picPreview.BackColor = Color.Silver;
            this.picPreview.BackgroundImageLayout = ImageLayout.None;
            this.picPreview.BorderStyle = BorderStyle.FixedSingle;
            this.picPreview.Cursor = Cursors.Cross;
            this.picPreview.Location = new Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new Size(600, 600);
            this.picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            // 
            // TemplateForm
            // 
            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(624, 675);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TemplateForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected PictureBox picPreview;
    }
}

