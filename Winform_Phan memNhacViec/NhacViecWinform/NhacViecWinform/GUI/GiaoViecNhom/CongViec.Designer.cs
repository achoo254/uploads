namespace NhacViecWinform.GUI.Kanban
{
    partial class CongViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongViec));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcCongViecNhan = new DevExpress.XtraGrid.GridControl();
            this.gvCongViecNhan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNNTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNNTieuDe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNNNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNNNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNNNguoiGui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNNThanhVienNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNNCongViecChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcCongViecGui = new DevExpress.XtraGrid.GridControl();
            this.gvCongViecGui = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNGId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGTieude = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGNgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGNguoiNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGCongViecChiTiet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.dragDropEvents1 = new DevExpress.Utils.DragDrop.DragDropEvents(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViecNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongViecNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViecGui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongViecGui)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcCongViecNhan);
            this.layoutControl1.Controls.Add(this.gcCongViecGui);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(761, 635);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcCongViecNhan
            // 
            this.gcCongViecNhan.Location = new System.Drawing.Point(12, 357);
            this.gcCongViecNhan.MainView = this.gvCongViecNhan;
            this.gcCongViecNhan.Name = "gcCongViecNhan";
            this.gcCongViecNhan.Size = new System.Drawing.Size(737, 266);
            this.gcCongViecNhan.TabIndex = 6;
            this.gcCongViecNhan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCongViecNhan});
            // 
            // gvCongViecNhan
            // 
            this.behaviorManager1.SetBehaviors(this.gvCongViecNhan, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.DragDrop.DragDropBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.ColumnViewDragDropSource), true, true, true, true, this.dragDropEvents1)))});
            this.gvCongViecNhan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colNNTrangThai,
            this.colNNTieuDe,
            this.colNNNhan,
            this.colNNNgayTao,
            this.colNNNguoiGui,
            this.colNNThanhVienNhan,
            this.colNNCongViecChiTiet});
            this.gvCongViecNhan.GridControl = this.gcCongViecNhan;
            this.gvCongViecNhan.GroupCount = 1;
            this.gvCongViecNhan.Name = "gvCongViecNhan";
            this.gvCongViecNhan.OptionsBehavior.Editable = false;
            this.gvCongViecNhan.OptionsView.ShowAutoFilterRow = true;
            this.gvCongViecNhan.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNNTrangThai, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "id";
            this.gridColumn1.FieldName = "cv_id";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // colNNTrangThai
            // 
            this.colNNTrangThai.Caption = "Trạng thái";
            this.colNNTrangThai.FieldName = "tt_tieude";
            this.colNNTrangThai.Name = "colNNTrangThai";
            this.colNNTrangThai.Visible = true;
            this.colNNTrangThai.VisibleIndex = 0;
            // 
            // colNNTieuDe
            // 
            this.colNNTieuDe.Caption = "Tiêu đề";
            this.colNNTieuDe.FieldName = "tieude";
            this.colNNTieuDe.Name = "colNNTieuDe";
            this.colNNTieuDe.Visible = true;
            this.colNNTieuDe.VisibleIndex = 1;
            // 
            // colNNNhan
            // 
            this.colNNNhan.Caption = "Nhãn";
            this.colNNNhan.FieldName = "n_tieude";
            this.colNNNhan.Name = "colNNNhan";
            this.colNNNhan.Visible = true;
            this.colNNNhan.VisibleIndex = 0;
            // 
            // colNNNgayTao
            // 
            this.colNNNgayTao.Caption = "Ngày tạo";
            this.colNNNgayTao.FieldName = "ngaytao";
            this.colNNNgayTao.Name = "colNNNgayTao";
            this.colNNNgayTao.Visible = true;
            this.colNNNgayTao.VisibleIndex = 2;
            // 
            // colNNNguoiGui
            // 
            this.colNNNguoiGui.Caption = "Thành viên gửi";
            this.colNNNguoiGui.FieldName = "nguoigui";
            this.colNNNguoiGui.Name = "colNNNguoiGui";
            this.colNNNguoiGui.Visible = true;
            this.colNNNguoiGui.VisibleIndex = 3;
            // 
            // colNNThanhVienNhan
            // 
            this.colNNThanhVienNhan.Caption = "Số thành viên nhận";
            this.colNNThanhVienNhan.FieldName = "dem_thanhvien";
            this.colNNThanhVienNhan.Name = "colNNThanhVienNhan";
            this.colNNThanhVienNhan.Visible = true;
            this.colNNThanhVienNhan.VisibleIndex = 4;
            // 
            // colNNCongViecChiTiet
            // 
            this.colNNCongViecChiTiet.Caption = "Số công việc chi tiết";
            this.colNNCongViecChiTiet.FieldName = "dem_tongcongviec";
            this.colNNCongViecChiTiet.Name = "colNNCongViecChiTiet";
            this.colNNCongViecChiTiet.Visible = true;
            this.colNNCongViecChiTiet.VisibleIndex = 5;
            // 
            // gcCongViecGui
            // 
            this.gcCongViecGui.Location = new System.Drawing.Point(12, 28);
            this.gcCongViecGui.MainView = this.gvCongViecGui;
            this.gcCongViecGui.Name = "gcCongViecGui";
            this.gcCongViecGui.Size = new System.Drawing.Size(737, 309);
            this.gcCongViecGui.TabIndex = 5;
            this.gcCongViecGui.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCongViecGui});
            // 
            // gvCongViecGui
            // 
            this.gvCongViecGui.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNGId,
            this.colNGTrangThai,
            this.colNGTieude,
            this.colNGNhan,
            this.colNGNgayTao,
            this.colNGNguoiNhan,
            this.colNGCongViecChiTiet});
            this.gvCongViecGui.GridControl = this.gcCongViecGui;
            this.gvCongViecGui.GroupCount = 1;
            this.gvCongViecGui.Name = "gvCongViecGui";
            this.gvCongViecGui.OptionsBehavior.Editable = false;
            this.gvCongViecGui.OptionsView.ShowAutoFilterRow = true;
            this.gvCongViecGui.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNGTrangThai, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colNGId
            // 
            this.colNGId.Caption = "id";
            this.colNGId.FieldName = "cv_id";
            this.colNGId.Name = "colNGId";
            // 
            // colNGTrangThai
            // 
            this.colNGTrangThai.Caption = "Trạng thái";
            this.colNGTrangThai.FieldName = "tt_tieude";
            this.colNGTrangThai.Name = "colNGTrangThai";
            this.colNGTrangThai.Visible = true;
            this.colNGTrangThai.VisibleIndex = 0;
            // 
            // colNGTieude
            // 
            this.colNGTieude.Caption = "Tiêu đề";
            this.colNGTieude.FieldName = "tieude";
            this.colNGTieude.Name = "colNGTieude";
            this.colNGTieude.Visible = true;
            this.colNGTieude.VisibleIndex = 1;
            // 
            // colNGNhan
            // 
            this.colNGNhan.Caption = "Nhãn";
            this.colNGNhan.FieldName = "n_tieude";
            this.colNGNhan.Name = "colNGNhan";
            this.colNGNhan.Visible = true;
            this.colNGNhan.VisibleIndex = 0;
            // 
            // colNGNgayTao
            // 
            this.colNGNgayTao.Caption = "Ngày tạo";
            this.colNGNgayTao.FieldName = "ngaytao";
            this.colNGNgayTao.Name = "colNGNgayTao";
            this.colNGNgayTao.Visible = true;
            this.colNGNgayTao.VisibleIndex = 2;
            // 
            // colNGNguoiNhan
            // 
            this.colNGNguoiNhan.Caption = "Số thành viên nhận";
            this.colNGNguoiNhan.FieldName = "dem_thanhvien";
            this.colNGNguoiNhan.Name = "colNGNguoiNhan";
            this.colNGNguoiNhan.Visible = true;
            this.colNGNguoiNhan.VisibleIndex = 3;
            // 
            // colNGCongViecChiTiet
            // 
            this.colNGCongViecChiTiet.Caption = "Số công việc chi tiết";
            this.colNGCongViecChiTiet.FieldName = "dem_tongcongviec";
            this.colNGCongViecChiTiet.Name = "colNGCongViecChiTiet";
            this.colNGCongViecChiTiet.Visible = true;
            this.colNGCongViecChiTiet.VisibleIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(761, 635);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcCongViecGui;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(741, 329);
            this.layoutControlItem2.Text = "Công việc đã gửi";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcCongViecNhan;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 329);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(741, 286);
            this.layoutControlItem1.Text = "Công việc đã nhận";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(89, 13);
            // 
            // CongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 635);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CongViec";
            this.Text = "Công việc";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViecNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongViecNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViecGui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongViecGui)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcCongViecGui;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCongViecGui;
        private DevExpress.XtraGrid.Columns.GridColumn colNGId;
        private DevExpress.XtraGrid.Columns.GridColumn colNGTieude;
        private DevExpress.XtraGrid.Columns.GridColumn colNGNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNGNguoiNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNGCongViecChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn colNGTrangThai;
        private DevExpress.Utils.DragDrop.DragDropEvents dragDropEvents1;
        private DevExpress.XtraGrid.GridControl gcCongViecNhan;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCongViecNhan;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colNNTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colNNTieuDe;
        private DevExpress.XtraGrid.Columns.GridColumn colNNNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNNThanhVienNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNNCongViecChiTiet;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colNNNguoiGui;
        private DevExpress.XtraGrid.Columns.GridColumn colNNNgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn colNGNgayTao;
    }
}