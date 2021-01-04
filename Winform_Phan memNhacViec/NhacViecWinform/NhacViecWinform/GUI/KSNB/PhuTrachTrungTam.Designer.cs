namespace NhacViecWinform.GUI.KSNB
{
    partial class PhuTrachTrungTam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhuTrachTrungTam));
            this.gcPhuTrachTrungTam = new DevExpress.XtraGrid.GridControl();
            this.gvPhuTrachTrungTam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhuTrach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhVienPhuTrach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lblPhuTrach = new DevExpress.XtraEditors.LabelControl();
            this.btnXacNhan = new DevExpress.XtraEditors.SimpleButton();
            this.cbbPhuTrach = new DevExpress.XtraEditors.ComboBoxEdit();
            this.leTrungTam = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhuTrachTrungTam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhuTrachTrungTam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbbPhuTrach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTrungTam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcPhuTrachTrungTam
            // 
            this.gcPhuTrachTrungTam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPhuTrachTrungTam.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gcPhuTrachTrungTam.Location = new System.Drawing.Point(0, 204);
            this.gcPhuTrachTrungTam.MainView = this.gvPhuTrachTrungTam;
            this.gcPhuTrachTrungTam.Margin = new System.Windows.Forms.Padding(2);
            this.gcPhuTrachTrungTam.Name = "gcPhuTrachTrungTam";
            this.gcPhuTrachTrungTam.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.gcPhuTrachTrungTam.Size = new System.Drawing.Size(891, 461);
            this.gcPhuTrachTrungTam.TabIndex = 0;
            this.gcPhuTrachTrungTam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhuTrachTrungTam});
            // 
            // gvPhuTrachTrungTam
            // 
            this.gvPhuTrachTrungTam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrungTam,
            this.colPhuTrach,
            this.colThanhVienPhuTrach});
            this.gvPhuTrachTrungTam.DetailHeight = 294;
            this.gvPhuTrachTrungTam.FixedLineWidth = 1;
            this.gvPhuTrachTrungTam.GridControl = this.gcPhuTrachTrungTam;
            this.gvPhuTrachTrungTam.GroupCount = 1;
            this.gvPhuTrachTrungTam.Name = "gvPhuTrachTrungTam";
            this.gvPhuTrachTrungTam.OptionsBehavior.Editable = false;
            this.gvPhuTrachTrungTam.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colThanhVienPhuTrach, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colTrungTam
            // 
            this.colTrungTam.Caption = "Trung tâm";
            this.colTrungTam.FieldName = "ten";
            this.colTrungTam.MinWidth = 15;
            this.colTrungTam.Name = "colTrungTam";
            this.colTrungTam.OptionsColumn.AllowEdit = false;
            this.colTrungTam.Visible = true;
            this.colTrungTam.VisibleIndex = 0;
            this.colTrungTam.Width = 58;
            // 
            // colPhuTrach
            // 
            this.colPhuTrach.Caption = "Phụ trách";
            this.colPhuTrach.FieldName = "phutrach";
            this.colPhuTrach.MinWidth = 15;
            this.colPhuTrach.Name = "colPhuTrach";
            this.colPhuTrach.Visible = true;
            this.colPhuTrach.VisibleIndex = 1;
            this.colPhuTrach.Width = 58;
            // 
            // colThanhVienPhuTrach
            // 
            this.colThanhVienPhuTrach.Caption = "Thành viên";
            this.colThanhVienPhuTrach.FieldName = "fullname";
            this.colThanhVienPhuTrach.MinWidth = 23;
            this.colThanhVienPhuTrach.Name = "colThanhVienPhuTrach";
            this.colThanhVienPhuTrach.Visible = true;
            this.colThanhVienPhuTrach.VisibleIndex = 2;
            this.colThanhVienPhuTrach.Width = 58;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Items.AddRange(new object[] {
            "Không phụ trách",
            "Phụ trách báo cáo hủy",
            "Phụ trách báo cáo sai lệch",
            "Phụ trách tất cả"});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
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
            this.dockPanel1.ID = new System.Guid("a294f802-dc14-4725-8155-b091cd47443a");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 204);
            this.dockPanel1.Size = new System.Drawing.Size(891, 204);
            this.dockPanel1.Text = "Thông tin thêm";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.layoutControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 40);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(2);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(883, 159);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lblPhuTrach);
            this.layoutControl1.Controls.Add(this.btnXacNhan);
            this.layoutControl1.Controls.Add(this.cbbPhuTrach);
            this.layoutControl1.Controls.Add(this.leTrungTam);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(716, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(883, 159);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lblPhuTrach
            // 
            this.lblPhuTrach.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhuTrach.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblPhuTrach.Appearance.Options.UseFont = true;
            this.lblPhuTrach.Appearance.Options.UseForeColor = true;
            this.lblPhuTrach.Location = new System.Drawing.Point(370, 138);
            this.lblPhuTrach.Margin = new System.Windows.Forms.Padding(2);
            this.lblPhuTrach.Name = "lblPhuTrach";
            this.lblPhuTrach.Size = new System.Drawing.Size(126, 13);
            this.lblPhuTrach.StyleController = this.layoutControl1;
            this.lblPhuTrach.TabIndex = 7;
            this.lblPhuTrach.Text = "Vui lòng nhập đủ thông tin";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXacNhan.ImageOptions.Image")));
            this.btnXacNhan.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnXacNhan.Location = new System.Drawing.Point(12, 112);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(842, 22);
            this.btnXacNhan.StyleController = this.layoutControl1;
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // cbbPhuTrach
            // 
            this.cbbPhuTrach.Location = new System.Drawing.Point(12, 31);
            this.cbbPhuTrach.Margin = new System.Windows.Forms.Padding(2);
            this.cbbPhuTrach.Name = "cbbPhuTrach";
            this.cbbPhuTrach.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbbPhuTrach.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbbPhuTrach.Size = new System.Drawing.Size(842, 22);
            this.cbbPhuTrach.StyleController = this.layoutControl1;
            this.cbbPhuTrach.TabIndex = 5;
            // 
            // leTrungTam
            // 
            this.leTrungTam.Location = new System.Drawing.Point(12, 76);
            this.leTrungTam.Margin = new System.Windows.Forms.Padding(2);
            this.leTrungTam.Name = "leTrungTam";
            this.leTrungTam.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leTrungTam.Properties.NullText = "";
            this.leTrungTam.Size = new System.Drawing.Size(842, 22);
            this.leTrungTam.StyleController = this.layoutControl1;
            this.leTrungTam.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(866, 163);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbbPhuTrach;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(846, 45);
            this.layoutControlItem2.Text = "Phụ trách";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(60, 16);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.leTrungTam;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 45);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(846, 45);
            this.layoutControlItem1.Text = "Trung tâm";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(60, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnXacNhan;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 100);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(846, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lblPhuTrach;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 126);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(846, 17);
            this.layoutControlItem4.Text = "Vui lòng nhập đủ thông tin";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 90);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(846, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // PhuTrachTrungTam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 665);
            this.Controls.Add(this.gcPhuTrachTrungTam);
            this.Controls.Add(this.dockPanel1);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("PhuTrachTrungTam.IconOptions.Icon")));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("PhuTrachTrungTam.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PhuTrachTrungTam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm phụ trách trung tâm";
            ((System.ComponentModel.ISupportInitialize)(this.gcPhuTrachTrungTam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhuTrachTrungTam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbbPhuTrach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTrungTam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcPhuTrachTrungTam;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhuTrachTrungTam;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.LabelControl lblPhuTrach;
        private DevExpress.XtraEditors.SimpleButton btnXacNhan;
        private DevExpress.XtraEditors.ComboBoxEdit cbbPhuTrach;
        private DevExpress.XtraEditors.LookUpEdit leTrungTam;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn colPhuTrach;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhVienPhuTrach;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}