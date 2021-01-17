namespace NhacViecWinform.GUI
{
    partial class LichSuKSNB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LichSuKSNB));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.deLichSu = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gcLichSuKSNB = new DevExpress.XtraGrid.GridControl();
            this.gvLichSuKSNB = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcBaoCaoNXT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcHoSoCXLKSNB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deLichSu.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deLichSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLichSuKSNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichSuKSNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
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
            this.dockPanel1.ID = new System.Guid("8d957a85-4747-42a6-a54e-090be1c0ddd2");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 116);
            this.dockPanel1.Size = new System.Drawing.Size(651, 116);
            this.dockPanel1.Text = "Chọn ngày lịch sử";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 40);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(643, 71);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.deLichSu);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(525, 193, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(643, 71);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // deLichSu
            // 
            this.deLichSu.EditValue = null;
            this.deLichSu.Location = new System.Drawing.Point(12, 31);
            this.deLichSu.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.deLichSu.Name = "deLichSu";
            this.deLichSu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deLichSu.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deLichSu.Size = new System.Drawing.Size(301, 22);
            this.deLichSu.StyleController = this.layoutControl1;
            this.deLichSu.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(643, 71);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.deLichSu;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(305, 51);
            this.layoutControlItem2.Text = "Chọn ngày";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 16);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(305, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(318, 51);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gcLichSuKSNB
            // 
            this.gcLichSuKSNB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcLichSuKSNB.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcLichSuKSNB.Location = new System.Drawing.Point(0, 116);
            this.gcLichSuKSNB.MainView = this.gvLichSuKSNB;
            this.gcLichSuKSNB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gcLichSuKSNB.Name = "gcLichSuKSNB";
            this.gcLichSuKSNB.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gcLichSuKSNB.Size = new System.Drawing.Size(651, 318);
            this.gcLichSuKSNB.TabIndex = 1;
            this.gcLichSuKSNB.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvLichSuKSNB});
            // 
            // gvLichSuKSNB
            // 
            this.gvLichSuKSNB.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gcSTT,
            this.gridColumn5,
            this.gcBaoCaoNXT,
            this.gcHoSoCXLKSNB,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gvLichSuKSNB.DetailHeight = 295;
            this.gvLichSuKSNB.GridControl = this.gcLichSuKSNB;
            this.gvLichSuKSNB.Name = "gvLichSuKSNB";
            this.gvLichSuKSNB.OptionsBehavior.ReadOnly = true;
            this.gvLichSuKSNB.OptionsView.RowAutoHeight = true;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Phụ trách";
            this.gridColumn6.FieldName = "phutrach";
            this.gridColumn6.MinWidth = 16;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Width = 58;
            // 
            // gcSTT
            // 
            this.gcSTT.Caption = "Số thứ tự";
            this.gcSTT.FieldName = "STT";
            this.gcSTT.MinWidth = 16;
            this.gcSTT.Name = "gcSTT";
            this.gcSTT.OptionsColumn.AllowEdit = false;
            this.gcSTT.Visible = true;
            this.gcSTT.VisibleIndex = 0;
            this.gcSTT.Width = 59;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Trung tâm";
            this.gridColumn5.FieldName = "ten";
            this.gridColumn5.MinWidth = 16;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 82;
            // 
            // gcBaoCaoNXT
            // 
            this.gcBaoCaoNXT.Caption = "Báo cáo NXT";
            this.gcBaoCaoNXT.FieldName = "baocaonxt";
            this.gcBaoCaoNXT.MinWidth = 16;
            this.gcBaoCaoNXT.Name = "gcBaoCaoNXT";
            this.gcBaoCaoNXT.Visible = true;
            this.gcBaoCaoNXT.VisibleIndex = 2;
            this.gcBaoCaoNXT.Width = 82;
            // 
            // gcHoSoCXLKSNB
            // 
            this.gcHoSoCXLKSNB.Caption = "Hồ sơ chờ xử lý";
            this.gcHoSoCXLKSNB.FieldName = "hosocxlksnb";
            this.gcHoSoCXLKSNB.MinWidth = 16;
            this.gcHoSoCXLKSNB.Name = "gcHoSoCXLKSNB";
            this.gcHoSoCXLKSNB.Visible = true;
            this.gcHoSoCXLKSNB.VisibleIndex = 3;
            this.gcHoSoCXLKSNB.Width = 82;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Phiếu chuyển kho QAs";
            this.gridColumn1.FieldName = "phieuchuyenkhoqas";
            this.gridColumn1.MinWidth = 16;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 82;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Phiếu hủy QAs";
            this.gridColumn2.FieldName = "phieuhuyqas";
            this.gridColumn2.MinWidth = 16;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 5;
            this.gridColumn2.Width = 82;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Hồ sơ hủy";
            this.gridColumn3.ColumnEdit = this.repositoryItemMemoEdit1;
            this.gridColumn3.FieldName = "hosohuy";
            this.gridColumn3.MinWidth = 16;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 6;
            this.gridColumn3.Width = 82;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Báo cáo sai lệch";
            this.gridColumn4.FieldName = "baocaosailech";
            this.gridColumn4.MinWidth = 16;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 7;
            this.gridColumn4.Width = 86;
            // 
            // LichSuKSNB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 434);
            this.Controls.Add(this.gcLichSuKSNB);
            this.Controls.Add(this.dockPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("LichSuKSNB.IconOptions.Icon")));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("LichSuKSNB.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "LichSuKSNB";
            this.Text = "Lịch sử công việc KSNB";
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deLichSu.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deLichSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcLichSuKSNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvLichSuKSNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.DateEdit deLichSu;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gcLichSuKSNB;
        private DevExpress.XtraGrid.Views.Grid.GridView gvLichSuKSNB;
        private DevExpress.XtraGrid.Columns.GridColumn gcSTT;
        private DevExpress.XtraGrid.Columns.GridColumn gcBaoCaoNXT;
        private DevExpress.XtraGrid.Columns.GridColumn gcHoSoCXLKSNB;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}