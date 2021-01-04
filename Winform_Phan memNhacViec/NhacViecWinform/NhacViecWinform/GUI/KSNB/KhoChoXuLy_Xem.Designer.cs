namespace HoTroNhacViecWinform.GUI.KSNB
{
    partial class KhoChoXuLy_Xem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoChoXuLy_Xem));
            this.gcXemTonKhoChoXuLy = new DevExpress.XtraGrid.GridControl();
            this.gvXemTonKhoChoXuLy = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHanDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoCXL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayBCSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoBCSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLyDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhVienTao = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gcXemTonKhoChoXuLy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXemTonKhoChoXuLy)).BeginInit();
            this.SuspendLayout();
            // 
            // gcXemTonKhoChoXuLy
            // 
            this.gcXemTonKhoChoXuLy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcXemTonKhoChoXuLy.Location = new System.Drawing.Point(0, 0);
            this.gcXemTonKhoChoXuLy.MainView = this.gvXemTonKhoChoXuLy;
            this.gcXemTonKhoChoXuLy.Name = "gcXemTonKhoChoXuLy";
            this.gcXemTonKhoChoXuLy.Size = new System.Drawing.Size(775, 341);
            this.gcXemTonKhoChoXuLy.TabIndex = 0;
            this.gcXemTonKhoChoXuLy.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvXemTonKhoChoXuLy});
            // 
            // gvXemTonKhoChoXuLy
            // 
            this.gvXemTonKhoChoXuLy.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenSP,
            this.colLo,
            this.colHanDung,
            this.colSoLuong,
            this.colKhoCXL,
            this.colNgayBCSL,
            this.colSoBCSL,
            this.colLyDo,
            this.colThanhVienTao});
            this.gvXemTonKhoChoXuLy.GridControl = this.gcXemTonKhoChoXuLy;
            this.gvXemTonKhoChoXuLy.Name = "gvXemTonKhoChoXuLy";
            // 
            // colTenSP
            // 
            this.colTenSP.Caption = "Tên SP";
            this.colTenSP.FieldName = "tensp";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Visible = true;
            this.colTenSP.VisibleIndex = 0;
            // 
            // colLo
            // 
            this.colLo.Caption = "Lô";
            this.colLo.FieldName = "lo";
            this.colLo.Name = "colLo";
            this.colLo.Visible = true;
            this.colLo.VisibleIndex = 1;
            // 
            // colHanDung
            // 
            this.colHanDung.Caption = "Hạn dùng";
            this.colHanDung.FieldName = "handung";
            this.colHanDung.Name = "colHanDung";
            this.colHanDung.Visible = true;
            this.colHanDung.VisibleIndex = 2;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.FieldName = "soluong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
            // 
            // colKhoCXL
            // 
            this.colKhoCXL.Caption = "Kho chờ xử lý";
            this.colKhoCXL.FieldName = "khochoxuly";
            this.colKhoCXL.Name = "colKhoCXL";
            this.colKhoCXL.Visible = true;
            this.colKhoCXL.VisibleIndex = 4;
            // 
            // colNgayBCSL
            // 
            this.colNgayBCSL.Caption = "Ngày BCSL";
            this.colNgayBCSL.FieldName = "ngaybcsl";
            this.colNgayBCSL.Name = "colNgayBCSL";
            this.colNgayBCSL.Visible = true;
            this.colNgayBCSL.VisibleIndex = 5;
            // 
            // colSoBCSL
            // 
            this.colSoBCSL.Caption = "Số BCSL";
            this.colSoBCSL.FieldName = "sobcsl";
            this.colSoBCSL.Name = "colSoBCSL";
            this.colSoBCSL.Visible = true;
            this.colSoBCSL.VisibleIndex = 6;
            // 
            // colLyDo
            // 
            this.colLyDo.Caption = "Lý do";
            this.colLyDo.FieldName = "lydo";
            this.colLyDo.Name = "colLyDo";
            this.colLyDo.Visible = true;
            this.colLyDo.VisibleIndex = 7;
            // 
            // colThanhVienTao
            // 
            this.colThanhVienTao.Caption = "Thành viên tạo";
            this.colThanhVienTao.FieldName = "fullname";
            this.colThanhVienTao.Name = "colThanhVienTao";
            this.colThanhVienTao.Visible = true;
            this.colThanhVienTao.VisibleIndex = 8;
            // 
            // KhoChoXuLy_Xem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 341);
            this.Controls.Add(this.gcXemTonKhoChoXuLy);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("KhoChoXuLy_Xem.IconOptions.Image")));
            this.Name = "KhoChoXuLy_Xem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem tồn kho chờ xử lý";
            ((System.ComponentModel.ISupportInitialize)(this.gcXemTonKhoChoXuLy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvXemTonKhoChoXuLy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcXemTonKhoChoXuLy;
        private DevExpress.XtraGrid.Views.Grid.GridView gvXemTonKhoChoXuLy;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSP;
        private DevExpress.XtraGrid.Columns.GridColumn colLo;
        private DevExpress.XtraGrid.Columns.GridColumn colHanDung;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoCXL;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayBCSL;
        private DevExpress.XtraGrid.Columns.GridColumn colSoBCSL;
        private DevExpress.XtraGrid.Columns.GridColumn colLyDo;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhVienTao;
    }
}