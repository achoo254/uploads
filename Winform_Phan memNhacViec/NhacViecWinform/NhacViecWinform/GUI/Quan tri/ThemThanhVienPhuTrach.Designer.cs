namespace HoTroNhacViecWinform.GUI.Quan_tri
{
    partial class ThemThanhVienPhuTrach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemThanhVienPhuTrach));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.listThanhVienPhuTrach = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.gcThemPhuTrach = new DevExpress.XtraGrid.GridControl();
            this.gvThemPhuTrach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhanQuyen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.leTenThanhVien = new DevExpress.XtraEditors.LookUpEdit();
            this.leBoPhan = new DevExpress.XtraEditors.LookUpEdit();
            this.leChucDanh = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listThanhVienPhuTrach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThemPhuTrach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThemPhuTrach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTenThanhVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leBoPhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leChucDanh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.listThanhVienPhuTrach);
            this.layoutControl1.Controls.Add(this.gcThemPhuTrach);
            this.layoutControl1.Controls.Add(this.btnDongY);
            this.layoutControl1.Controls.Add(this.leTenThanhVien);
            this.layoutControl1.Controls.Add(this.leBoPhan);
            this.layoutControl1.Controls.Add(this.leChucDanh);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(707, 190, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(787, 513);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // listThanhVienPhuTrach
            // 
            this.listThanhVienPhuTrach.CheckMode = DevExpress.XtraEditors.CheckMode.Single;
            this.listThanhVienPhuTrach.CheckOnClick = true;
            this.listThanhVienPhuTrach.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.listThanhVienPhuTrach.Items.AddRange(new DevExpress.XtraEditors.Controls.CheckedListBoxItem[] {
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Thành viên KSNB"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Thành viên QA"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Thành viên Cung Ứng"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Thành viên Điều Dưỡng"),
            new DevExpress.XtraEditors.Controls.CheckedListBoxItem(null, "Thành viên")});
            this.listThanhVienPhuTrach.Location = new System.Drawing.Point(12, 166);
            this.listThanhVienPhuTrach.Name = "listThanhVienPhuTrach";
            this.listThanhVienPhuTrach.Size = new System.Drawing.Size(763, 106);
            this.listThanhVienPhuTrach.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.listThanhVienPhuTrach.StyleController = this.layoutControl1;
            this.listThanhVienPhuTrach.TabIndex = 12;
            // 
            // gcThemPhuTrach
            // 
            this.gcThemPhuTrach.Location = new System.Drawing.Point(12, 321);
            this.gcThemPhuTrach.MainView = this.gvThemPhuTrach;
            this.gcThemPhuTrach.Name = "gcThemPhuTrach";
            this.gcThemPhuTrach.Size = new System.Drawing.Size(763, 180);
            this.gcThemPhuTrach.TabIndex = 10;
            this.gcThemPhuTrach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThemPhuTrach});
            // 
            // gvThemPhuTrach
            // 
            this.gvThemPhuTrach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colThanhVien,
            this.gridColumn1,
            this.gridColumn2,
            this.colPhanQuyen});
            this.gvThemPhuTrach.GridControl = this.gcThemPhuTrach;
            this.gvThemPhuTrach.Name = "gvThemPhuTrach";
            this.gvThemPhuTrach.OptionsBehavior.Editable = false;
            this.gvThemPhuTrach.OptionsView.ShowGroupPanel = false;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "id";
            this.colId.Name = "colId";
            // 
            // colThanhVien
            // 
            this.colThanhVien.Caption = "Tên thành viên";
            this.colThanhVien.FieldName = "fullname";
            this.colThanhVien.Name = "colThanhVien";
            this.colThanhVien.Visible = true;
            this.colThanhVien.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Bộ phận";
            this.gridColumn1.FieldName = "bophan";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Chức danh";
            this.gridColumn2.FieldName = "chucdanh";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // colPhanQuyen
            // 
            this.colPhanQuyen.Caption = "Phân quyền";
            this.colPhanQuyen.FieldName = "roles";
            this.colPhanQuyen.Name = "colPhanQuyen";
            this.colPhanQuyen.Visible = true;
            this.colPhanQuyen.VisibleIndex = 3;
            // 
            // btnDongY
            // 
            this.btnDongY.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDongY.ImageOptions.Image")));
            this.btnDongY.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnDongY.Location = new System.Drawing.Point(12, 276);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(763, 22);
            this.btnDongY.StyleController = this.layoutControl1;
            this.btnDongY.TabIndex = 8;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // leTenThanhVien
            // 
            this.leTenThanhVien.Location = new System.Drawing.Point(12, 31);
            this.leTenThanhVien.Name = "leTenThanhVien";
            this.leTenThanhVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leTenThanhVien.Properties.NullText = "Chọn tên thành viên...";
            this.leTenThanhVien.Size = new System.Drawing.Size(763, 22);
            this.leTenThanhVien.StyleController = this.layoutControl1;
            this.leTenThanhVien.TabIndex = 4;
            // 
            // leBoPhan
            // 
            this.leBoPhan.Location = new System.Drawing.Point(12, 76);
            this.leBoPhan.Name = "leBoPhan";
            this.leBoPhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leBoPhan.Properties.NullText = "";
            this.leBoPhan.Properties.ReadOnly = true;
            this.leBoPhan.Size = new System.Drawing.Size(763, 22);
            this.leBoPhan.StyleController = this.layoutControl1;
            this.leBoPhan.TabIndex = 5;
            // 
            // leChucDanh
            // 
            this.leChucDanh.Location = new System.Drawing.Point(12, 121);
            this.leChucDanh.Name = "leChucDanh";
            this.leChucDanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leChucDanh.Properties.NullText = "";
            this.leChucDanh.Properties.ReadOnly = true;
            this.leChucDanh.Size = new System.Drawing.Size(763, 22);
            this.leChucDanh.StyleController = this.layoutControl1;
            this.leChucDanh.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem7,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(787, 513);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.leTenThanhVien;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(767, 45);
            this.layoutControlItem1.Text = "Tên thành viên";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(122, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.leBoPhan;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 45);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(767, 45);
            this.layoutControlItem2.Text = "Bộ phận";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(122, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.leChucDanh;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 90);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(767, 45);
            this.layoutControlItem3.Text = "Chức danh";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(122, 16);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnDongY;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 264);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(767, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.gcThemPhuTrach;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 290);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(767, 203);
            this.layoutControlItem7.Text = "Danh sách thành viên";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(122, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.listThanhVienPhuTrach;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 135);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(767, 129);
            this.layoutControlItem6.Text = "Phụ trách";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(122, 16);
            // 
            // ThemThanhVienPhuTrach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 513);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemThanhVienPhuTrach";
            this.Text = "Thêm quản trị";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listThanhVienPhuTrach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcThemPhuTrach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThemPhuTrach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTenThanhVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leBoPhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leChucDanh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcThemPhuTrach;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThemPhuTrach;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraEditors.LookUpEdit leTenThanhVien;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LookUpEdit leBoPhan;
        private DevExpress.XtraEditors.LookUpEdit leChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhVien;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colPhanQuyen;
        private DevExpress.XtraEditors.CheckedListBoxControl listThanhVienPhuTrach;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}