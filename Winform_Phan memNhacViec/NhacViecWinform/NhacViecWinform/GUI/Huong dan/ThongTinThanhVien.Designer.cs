namespace HoTroNhacViecWinform.GUI.Huong_dan
{
    partial class ThongTinThanhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinThanhVien));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcThongTinThanhVien = new DevExpress.XtraGrid.GridControl();
            this.gvThongTinThanhVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colTrungTam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBoPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTinThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThongTinThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcThongTinThanhVien);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(790, 386);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcThongTinThanhVien
            // 
            this.gcThongTinThanhVien.Location = new System.Drawing.Point(12, 12);
            this.gcThongTinThanhVien.MainView = this.gvThongTinThanhVien;
            this.gcThongTinThanhVien.Name = "gcThongTinThanhVien";
            this.gcThongTinThanhVien.Size = new System.Drawing.Size(766, 362);
            this.gcThongTinThanhVien.TabIndex = 4;
            this.gcThongTinThanhVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThongTinThanhVien});
            // 
            // gvThongTinThanhVien
            // 
            this.gvThongTinThanhVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.colTrungTam,
            this.gridColumn1,
            this.colBoPhan,
            this.colChucDanh,
            this.colEmail,
            this.colPhone});
            this.gvThongTinThanhVien.GridControl = this.gcThongTinThanhVien;
            this.gvThongTinThanhVien.GroupCount = 1;
            this.gvThongTinThanhVien.Name = "gvThongTinThanhVien";
            this.gvThongTinThanhVien.OptionsBehavior.ReadOnly = true;
            this.gvThongTinThanhVien.OptionsSelection.MultiSelect = true;
            this.gvThongTinThanhVien.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTrungTam, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(790, 386);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcThongTinThanhVien;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(770, 366);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // colTrungTam
            // 
            this.colTrungTam.Caption = "Trung tâm";
            this.colTrungTam.FieldName = "ten";
            this.colTrungTam.Name = "colTrungTam";
            this.colTrungTam.Visible = true;
            this.colTrungTam.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Họ tên";
            this.gridColumn1.FieldName = "fullname";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Id";
            this.gridColumn2.FieldName = "trungtam_id";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // colBoPhan
            // 
            this.colBoPhan.Caption = "Bộ phận";
            this.colBoPhan.FieldName = "bophan";
            this.colBoPhan.Name = "colBoPhan";
            this.colBoPhan.Visible = true;
            this.colBoPhan.VisibleIndex = 1;
            // 
            // colChucDanh
            // 
            this.colChucDanh.Caption = "Chức danh";
            this.colChucDanh.FieldName = "chucdanh";
            this.colChucDanh.Name = "colChucDanh";
            this.colChucDanh.Visible = true;
            this.colChucDanh.VisibleIndex = 2;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 3;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Điện thoại";
            this.colPhone.FieldName = "phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 4;
            // 
            // ThongTinThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 386);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThongTinThanhVien";
            this.Text = "Thông tin các trung tâm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcThongTinThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThongTinThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gcThongTinThanhVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThongTinThanhVien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn colTrungTam;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn colBoPhan;
        private DevExpress.XtraGrid.Columns.GridColumn colChucDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
    }
}