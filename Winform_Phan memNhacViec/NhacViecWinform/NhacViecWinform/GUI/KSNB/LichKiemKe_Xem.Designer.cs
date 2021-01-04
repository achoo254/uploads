namespace HoTroNhacViecWinform.GUI.KSNB
{
    partial class LichKiemKe_Xem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichKiemKe_Xem));
            this.gcXemLichKiemKe = new DevExpress.XtraGrid.GridControl();
            this.gvXemLichKiemKe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGianKiemKe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayKiemKe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongSoPhongTiem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongSoPhongTiemOff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongSoPhongTiemKiemSang = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcXemLichKiemKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXemLichKiemKe)).BeginInit();
            this.SuspendLayout();
            // 
            // gcXemLichKiemKe
            // 
            this.gcXemLichKiemKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcXemLichKiemKe.Location = new System.Drawing.Point(0, 0);
            this.gcXemLichKiemKe.MainView = this.gvXemLichKiemKe;
            this.gcXemLichKiemKe.Name = "gcXemLichKiemKe";
            this.gcXemLichKiemKe.Size = new System.Drawing.Size(775, 341);
            this.gcXemLichKiemKe.TabIndex = 0;
            this.gcXemLichKiemKe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvXemLichKiemKe});
            // 
            // gvXemLichKiemKe
            // 
            this.gvXemLichKiemKe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrungTam,
            this.colTenKho,
            this.colThoiGianKiemKe,
            this.colNgayKiemKe,
            this.colTongSoPhongTiem,
            this.colTongSoPhongTiemOff,
            this.colTongSoPhongTiemKiemSang});
            this.gvXemLichKiemKe.GridControl = this.gcXemLichKiemKe;
            this.gvXemLichKiemKe.Name = "gvXemLichKiemKe";
            // 
            // colTrungTam
            // 
            this.colTrungTam.Caption = "Trung tâm";
            this.colTrungTam.FieldName = "trungtam";
            this.colTrungTam.Name = "colTrungTam";
            this.colTrungTam.Visible = true;
            this.colTrungTam.VisibleIndex = 0;
            // 
            // colTenKho
            // 
            this.colTenKho.Caption = "Tên kho";
            this.colTenKho.FieldName = "tenkho";
            this.colTenKho.Name = "colTenKho";
            this.colTenKho.Visible = true;
            this.colTenKho.VisibleIndex = 1;
            // 
            // colThoiGianKiemKe
            // 
            this.colThoiGianKiemKe.Caption = "Thời gian kiểm kê";
            this.colThoiGianKiemKe.FieldName = "thoigiankiemke";
            this.colThoiGianKiemKe.Name = "colThoiGianKiemKe";
            this.colThoiGianKiemKe.Visible = true;
            this.colThoiGianKiemKe.VisibleIndex = 2;
            // 
            // colNgayKiemKe
            // 
            this.colNgayKiemKe.Caption = "Ngày kiểm kê";
            this.colNgayKiemKe.FieldName = "ngaykiemke";
            this.colNgayKiemKe.Name = "colNgayKiemKe";
            this.colNgayKiemKe.Visible = true;
            this.colNgayKiemKe.VisibleIndex = 3;
            // 
            // colTongSoPhongTiem
            // 
            this.colTongSoPhongTiem.Caption = "Tổng số phòng tiêm";
            this.colTongSoPhongTiem.FieldName = "phongtiem_tong";
            this.colTongSoPhongTiem.Name = "colTongSoPhongTiem";
            this.colTongSoPhongTiem.Visible = true;
            this.colTongSoPhongTiem.VisibleIndex = 4;
            // 
            // colTongSoPhongTiemOff
            // 
            this.colTongSoPhongTiemOff.Caption = "Tổng số phòng tiêm off ngày thường";
            this.colTongSoPhongTiemOff.FieldName = "phongtiem_nghi";
            this.colTongSoPhongTiemOff.Name = "colTongSoPhongTiemOff";
            this.colTongSoPhongTiemOff.Visible = true;
            this.colTongSoPhongTiemOff.VisibleIndex = 5;
            // 
            // colTongSoPhongTiemKiemSang
            // 
            this.colTongSoPhongTiemKiemSang.Caption = "Tổng số phòng tiêm kiểm sáng";
            this.colTongSoPhongTiemKiemSang.FieldName = "phongtiem_kiemsang";
            this.colTongSoPhongTiemKiemSang.Name = "colTongSoPhongTiemKiemSang";
            this.colTongSoPhongTiemKiemSang.Visible = true;
            this.colTongSoPhongTiemKiemSang.VisibleIndex = 6;
            // 
            // LichKiemKe_Xem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 341);
            this.Controls.Add(this.gcXemLichKiemKe);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("LichKiemKe_Xem.IconOptions.Image")));
            this.Name = "LichKiemKe_Xem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem tồn kho chờ xử lý";
            ((System.ComponentModel.ISupportInitialize)(this.gcXemLichKiemKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXemLichKiemKe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcXemLichKiemKe;
        private DevExpress.XtraGrid.Views.Grid.GridView gvXemLichKiemKe;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKho;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGianKiemKe;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayKiemKe;
        private DevExpress.XtraGrid.Columns.GridColumn colTongSoPhongTiem;
        private DevExpress.XtraGrid.Columns.GridColumn colTongSoPhongTiemOff;
        private DevExpress.XtraGrid.Columns.GridColumn colTongSoPhongTiemKiemSang;
    }
}