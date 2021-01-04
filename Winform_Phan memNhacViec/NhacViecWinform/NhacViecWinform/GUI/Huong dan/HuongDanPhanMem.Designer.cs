namespace NhacViecWinform.GUI.Huong_dan
{
    partial class HuongDanPhanMem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HuongDanPhanMem));
            this.pdfHuongDanPhanMem = new DevExpress.XtraPdfViewer.PdfViewer();
            this.SuspendLayout();
            // 
            // pdfHuongDanPhanMem
            // 
            this.pdfHuongDanPhanMem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfHuongDanPhanMem.Location = new System.Drawing.Point(0, 0);
            this.pdfHuongDanPhanMem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pdfHuongDanPhanMem.Name = "pdfHuongDanPhanMem";
            this.pdfHuongDanPhanMem.NavigationPaneWidth = 199;
            this.pdfHuongDanPhanMem.Size = new System.Drawing.Size(946, 489);
            this.pdfHuongDanPhanMem.TabIndex = 0;
            // 
            // HuongDanPhanMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 489);
            this.Controls.Add(this.pdfHuongDanPhanMem);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("HuongDanPhanMem.IconOptions.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HuongDanPhanMem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng dẫn phần mềm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPdfViewer.PdfViewer pdfHuongDanPhanMem;
    }
}