namespace NhacViecWinform.GUI
{
    partial class ViecKSNB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViecKSNB));
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.gcCongViecKSNB = new DevExpress.XtraGrid.GridControl();
            this.gvCongViecKSNB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcPhuTrachID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBaoCaoNXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcHoSoCXL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhieuChuyenKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPhieuXuatHuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcHoSoHuy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gcBCSL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deChonNgay = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViecKSNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongViecKSNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deChonNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChonNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.gcCongViecKSNB);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 104);
            this.layoutControl2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(662, 212);
            this.layoutControl2.TabIndex = 1;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // gcCongViecKSNB
            // 
            this.gcCongViecKSNB.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcCongViecKSNB.Location = new System.Drawing.Point(10, 10);
            this.gcCongViecKSNB.MainView = this.gvCongViecKSNB;
            this.gcCongViecKSNB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcCongViecKSNB.Name = "gcCongViecKSNB";
            this.gcCongViecKSNB.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTimeEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemMemoEdit1});
            this.gcCongViecKSNB.Size = new System.Drawing.Size(642, 192);
            this.gcCongViecKSNB.TabIndex = 4;
            this.gcCongViecKSNB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCongViecKSNB});
            // 
            // gvCongViecKSNB
            // 
            this.gvCongViecKSNB.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcPhuTrachID,
            this.gridColumn1,
            this.gcTrungTam,
            this.gcBaoCaoNXT,
            this.gcHoSoCXL,
            this.gcPhieuChuyenKho,
            this.gcPhieuXuatHuy,
            this.gcHoSoHuy,
            this.gcBCSL});
            this.gvCongViecKSNB.DetailHeight = 295;
            this.gvCongViecKSNB.GridControl = this.gcCongViecKSNB;
            this.gvCongViecKSNB.Name = "gvCongViecKSNB";
            this.gvCongViecKSNB.OptionsView.RowAutoHeight = true;
            // 
            // gcPhuTrachID
            // 
            this.gcPhuTrachID.Caption = "ID";
            this.gcPhuTrachID.FieldName = "phutrach_id";
            this.gcPhuTrachID.MinWidth = 16;
            this.gcPhuTrachID.Name = "gcPhuTrachID";
            this.gcPhuTrachID.Width = 58;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số thứ tự";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.MinWidth = 16;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 58;
            // 
            // gcTrungTam
            // 
            this.gcTrungTam.Caption = "Trung tâm";
            this.gcTrungTam.FieldName = "ten";
            this.gcTrungTam.MinWidth = 16;
            this.gcTrungTam.Name = "gcTrungTam";
            this.gcTrungTam.OptionsColumn.AllowEdit = false;
            this.gcTrungTam.Visible = true;
            this.gcTrungTam.VisibleIndex = 1;
            this.gcTrungTam.Width = 65;
            // 
            // gcBaoCaoNXT
            // 
            this.gcBaoCaoNXT.Caption = "Báo cáo NXT";
            this.gcBaoCaoNXT.FieldName = "baocaonxt";
            this.gcBaoCaoNXT.MinWidth = 16;
            this.gcBaoCaoNXT.Name = "gcBaoCaoNXT";
            this.gcBaoCaoNXT.Visible = true;
            this.gcBaoCaoNXT.VisibleIndex = 2;
            this.gcBaoCaoNXT.Width = 51;
            // 
            // gcHoSoCXL
            // 
            this.gcHoSoCXL.Caption = "Hồ sơ chưa xử lý";
            this.gcHoSoCXL.FieldName = "hosocxlksnb";
            this.gcHoSoCXL.MinWidth = 16;
            this.gcHoSoCXL.Name = "gcHoSoCXL";
            this.gcHoSoCXL.Visible = true;
            this.gcHoSoCXL.VisibleIndex = 3;
            this.gcHoSoCXL.Width = 77;
            // 
            // gcPhieuChuyenKho
            // 
            this.gcPhieuChuyenKho.Caption = "Phiếu chuyển kho QAs";
            this.gcPhieuChuyenKho.FieldName = "phieuchuyenkhoqas";
            this.gcPhieuChuyenKho.MinWidth = 16;
            this.gcPhieuChuyenKho.Name = "gcPhieuChuyenKho";
            this.gcPhieuChuyenKho.Visible = true;
            this.gcPhieuChuyenKho.VisibleIndex = 4;
            this.gcPhieuChuyenKho.Width = 93;
            // 
            // gcPhieuXuatHuy
            // 
            this.gcPhieuXuatHuy.Caption = "Phiếu xuất hủy QAs";
            this.gcPhieuXuatHuy.FieldName = "phieuhuyqas";
            this.gcPhieuXuatHuy.MinWidth = 16;
            this.gcPhieuXuatHuy.Name = "gcPhieuXuatHuy";
            this.gcPhieuXuatHuy.Visible = true;
            this.gcPhieuXuatHuy.VisibleIndex = 5;
            this.gcPhieuXuatHuy.Width = 81;
            // 
            // gcHoSoHuy
            // 
            this.gcHoSoHuy.Caption = "Hồ sơ hủy";
            this.gcHoSoHuy.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gcHoSoHuy.FieldName = "hosohuy";
            this.gcHoSoHuy.MinWidth = 16;
            this.gcHoSoHuy.Name = "gcHoSoHuy";
            this.gcHoSoHuy.Visible = true;
            this.gcHoSoHuy.VisibleIndex = 6;
            this.gcHoSoHuy.Width = 43;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            this.repositoryItemMemoEdit1.WordWrap = false;
            // 
            // gcBCSL
            // 
            this.gcBCSL.Caption = "Báo cáo sai lệch";
            this.gcBCSL.FieldName = "baocaosailech";
            this.gcBCSL.MinWidth = 16;
            this.gcBCSL.Name = "gcBCSL";
            this.gcBCSL.Visible = true;
            this.gcBCSL.VisibleIndex = 7;
            this.gcBCSL.Width = 76;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(662, 212);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcCongViecKSNB;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(646, 196);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Top;
            this.dockPanel1.ID = new System.Guid("d6cad28f-5566-4a8b-b992-dbee348c99a1");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 124);
            this.dockPanel1.Size = new System.Drawing.Size(662, 104);
            this.dockPanel1.Text = "Chọn ngày lấy thông tin";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.labelControl1);
            this.dockPanel1_Container.Controls.Add(this.deChonNgay);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 40);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(654, 59);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(131, 28);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 16);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Chọn ngày";
            // 
            // deChonNgay
            // 
            this.deChonNgay.EditValue = null;
            this.deChonNgay.Location = new System.Drawing.Point(194, 25);
            this.deChonNgay.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deChonNgay.Name = "deChonNgay";
            this.deChonNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deChonNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deChonNgay.Size = new System.Drawing.Size(212, 22);
            this.deChonNgay.TabIndex = 0;
            this.deChonNgay.EditValueChanged += new System.EventHandler(this.deChonNgay_EditValueChanged);
            // 
            // ViecKSNB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 316);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.dockPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("ViecKSNB.IconOptions.Icon")));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("ViecKSNB.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ViecKSNB";
            this.Text = "Công việc KSNB";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCongViecKSNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCongViecKSNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.dockPanel1_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deChonNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deChonNgay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraGrid.GridControl gcCongViecKSNB;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCongViecKSNB;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gcTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn gcBaoCaoNXT;
        private DevExpress.XtraGrid.Columns.GridColumn gcHoSoCXL;
        private DevExpress.XtraGrid.Columns.GridColumn gcPhieuChuyenKho;
        private DevExpress.XtraGrid.Columns.GridColumn gcPhieuXuatHuy;
        private DevExpress.XtraGrid.Columns.GridColumn gcHoSoHuy;
        private DevExpress.XtraGrid.Columns.GridColumn gcBCSL;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gcPhuTrachID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deChonNgay;
    }
}