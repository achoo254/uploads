namespace NhacViecWinform.GUI.Chat
{
    partial class LienHeThanhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LienHeThanhVien));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.listThanhVien = new DevExpress.XtraEditors.ListBoxControl();
            this.btnDanhSachThanhVien = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaNoiDung = new DevExpress.XtraEditors.SimpleButton();
            this.txtTieuDe = new DevExpress.XtraEditors.TextEdit();
            this.btnGuiTinNhan = new DevExpress.XtraEditors.SimpleButton();
            this.meGuiTinNhan = new DevExpress.XtraEditors.MemoEdit();
            this.btnThemLienHe = new DevExpress.XtraEditors.SimpleButton();
            this.gcNhom = new DevExpress.XtraGrid.GridControl();
            this.gvNhom = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThongBao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcChat = new DevExpress.XtraGrid.GridControl();
            this.gvChat = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdChat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayGui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.meNoiDung = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.colGioGui = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdThanhVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ceChonThanhVien = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutBangLienHe = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listThanhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTieuDe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meGuiTinNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNoiDung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceChonThanhVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBangLienHe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.listThanhVien);
            this.layoutControl1.Controls.Add(this.btnDanhSachThanhVien);
            this.layoutControl1.Controls.Add(this.btnXoaNoiDung);
            this.layoutControl1.Controls.Add(this.txtTieuDe);
            this.layoutControl1.Controls.Add(this.btnGuiTinNhan);
            this.layoutControl1.Controls.Add(this.meGuiTinNhan);
            this.layoutControl1.Controls.Add(this.btnThemLienHe);
            this.layoutControl1.Controls.Add(this.gcNhom);
            this.layoutControl1.Controls.Add(this.gcChat);
            this.layoutControl1.Controls.Add(this.ceChonThanhVien);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(955, 477);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // listThanhVien
            // 
            this.listThanhVien.Location = new System.Drawing.Point(790, 339);
            this.listThanhVien.Name = "listThanhVien";
            this.listThanhVien.Size = new System.Drawing.Size(153, 100);
            this.listThanhVien.StyleController = this.layoutControl1;
            this.listThanhVien.TabIndex = 0;
            // 
            // btnDanhSachThanhVien
            // 
            this.btnDanhSachThanhVien.Location = new System.Drawing.Point(790, 313);
            this.btnDanhSachThanhVien.Name = "btnDanhSachThanhVien";
            this.btnDanhSachThanhVien.Size = new System.Drawing.Size(153, 22);
            this.btnDanhSachThanhVien.StyleController = this.layoutControl1;
            this.btnDanhSachThanhVien.TabIndex = 9;
            this.btnDanhSachThanhVien.Text = "Danh sách thành viên";
            // 
            // btnXoaNoiDung
            // 
            this.btnXoaNoiDung.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnXoaNoiDung.Appearance.Options.UseForeColor = true;
            this.btnXoaNoiDung.Location = new System.Drawing.Point(790, 443);
            this.btnXoaNoiDung.Name = "btnXoaNoiDung";
            this.btnXoaNoiDung.Size = new System.Drawing.Size(153, 22);
            this.btnXoaNoiDung.StyleController = this.layoutControl1;
            this.btnXoaNoiDung.TabIndex = 8;
            this.btnXoaNoiDung.Text = "Xóa nội dung";
            this.btnXoaNoiDung.Click += new System.EventHandler(this.btnXoaNoiDung_Click);
            // 
            // txtTieuDe
            // 
            this.txtTieuDe.Location = new System.Drawing.Point(12, 417);
            this.txtTieuDe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTieuDe.Name = "txtTieuDe";
            this.txtTieuDe.Size = new System.Drawing.Size(273, 22);
            this.txtTieuDe.StyleController = this.layoutControl1;
            this.txtTieuDe.TabIndex = 6;
            // 
            // btnGuiTinNhan
            // 
            this.btnGuiTinNhan.Location = new System.Drawing.Point(790, 287);
            this.btnGuiTinNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuiTinNhan.Name = "btnGuiTinNhan";
            this.btnGuiTinNhan.Size = new System.Drawing.Size(153, 22);
            this.btnGuiTinNhan.StyleController = this.layoutControl1;
            this.btnGuiTinNhan.TabIndex = 5;
            this.btnGuiTinNhan.Text = "Gửi";
            this.btnGuiTinNhan.Click += new System.EventHandler(this.btnGuiTinNhan_Click);
            // 
            // meGuiTinNhan
            // 
            this.meGuiTinNhan.Location = new System.Drawing.Point(289, 287);
            this.meGuiTinNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.meGuiTinNhan.Name = "meGuiTinNhan";
            this.meGuiTinNhan.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.meGuiTinNhan.Size = new System.Drawing.Size(497, 178);
            this.meGuiTinNhan.StyleController = this.layoutControl1;
            this.meGuiTinNhan.TabIndex = 4;
            // 
            // btnThemLienHe
            // 
            this.btnThemLienHe.Location = new System.Drawing.Point(12, 443);
            this.btnThemLienHe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemLienHe.Name = "btnThemLienHe";
            this.btnThemLienHe.Size = new System.Drawing.Size(273, 22);
            this.btnThemLienHe.StyleController = this.layoutControl1;
            this.btnThemLienHe.TabIndex = 7;
            this.btnThemLienHe.Text = "Thêm liên hệ";
            this.btnThemLienHe.Click += new System.EventHandler(this.btnThemLienHe_Click);
            // 
            // gcNhom
            // 
            this.gcNhom.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gcNhom.Location = new System.Drawing.Point(12, 31);
            this.gcNhom.MainView = this.gvNhom;
            this.gcNhom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcNhom.Name = "gcNhom";
            this.gcNhom.Size = new System.Drawing.Size(273, 318);
            this.gcNhom.TabIndex = 0;
            this.gcNhom.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvNhom});
            // 
            // gvNhom
            // 
            this.gvNhom.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colNhom,
            this.colThongBao});
            this.gvNhom.DetailHeight = 431;
            this.gvNhom.GridControl = this.gcNhom;
            this.gvNhom.Name = "gvNhom";
            this.gvNhom.OptionsBehavior.Editable = false;
            this.gvNhom.OptionsView.ShowAutoFilterRow = true;
            this.gvNhom.OptionsView.ShowGroupPanel = false;
            this.gvNhom.Click += new System.EventHandler(this.gvNhom_Click);
            // 
            // colId
            // 
            this.colId.FieldName = "id";
            this.colId.MinWidth = 23;
            this.colId.Name = "colId";
            this.colId.Width = 87;
            // 
            // colNhom
            // 
            this.colNhom.Caption = "Thành viên/Nhóm";
            this.colNhom.FieldName = "tieude";
            this.colNhom.MinWidth = 23;
            this.colNhom.Name = "colNhom";
            this.colNhom.Visible = true;
            this.colNhom.VisibleIndex = 0;
            this.colNhom.Width = 178;
            // 
            // colThongBao
            // 
            this.colThongBao.Caption = "Thông báo";
            this.colThongBao.FieldName = "thongbao";
            this.colThongBao.MinWidth = 23;
            this.colThongBao.Name = "colThongBao";
            this.colThongBao.Visible = true;
            this.colThongBao.VisibleIndex = 1;
            this.colThongBao.Width = 94;
            // 
            // gcChat
            // 
            this.gcChat.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.gcChat.Location = new System.Drawing.Point(289, 31);
            this.gcChat.MainView = this.gvChat;
            this.gcChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gcChat.Name = "gcChat";
            this.gcChat.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.meNoiDung});
            this.gcChat.Size = new System.Drawing.Size(654, 252);
            this.gcChat.TabIndex = 2;
            this.gcChat.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvChat});
            // 
            // gvChat
            // 
            this.gvChat.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvChat.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdChat,
            this.colKhoa,
            this.colNgayGui,
            this.colNoiDung,
            this.colGioGui,
            this.colIdThanhVien});
            this.gvChat.DetailHeight = 431;
            this.gvChat.GridControl = this.gcChat;
            this.gvChat.Name = "gvChat";
            this.gvChat.OptionsBehavior.Editable = false;
            this.gvChat.OptionsView.RowAutoHeight = true;
            this.gvChat.OptionsView.ShowAutoFilterRow = true;
            this.gvChat.OptionsView.ShowGroupPanel = false;
            this.gvChat.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvChat.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvChat.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colIdChat
            // 
            this.colIdChat.Caption = "Id";
            this.colIdChat.FieldName = "id";
            this.colIdChat.MinWidth = 23;
            this.colIdChat.Name = "colIdChat";
            this.colIdChat.Width = 87;
            // 
            // colKhoa
            // 
            this.colKhoa.Caption = "Khóa";
            this.colKhoa.FieldName = "khoa";
            this.colKhoa.MinWidth = 23;
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.Width = 87;
            // 
            // colNgayGui
            // 
            this.colNgayGui.Caption = "Ngày gửi";
            this.colNgayGui.FieldName = "ngaygui";
            this.colNgayGui.MinWidth = 23;
            this.colNgayGui.Name = "colNgayGui";
            this.colNgayGui.Visible = true;
            this.colNgayGui.VisibleIndex = 0;
            this.colNgayGui.Width = 93;
            // 
            // colNoiDung
            // 
            this.colNoiDung.Caption = "Nội dung";
            this.colNoiDung.ColumnEdit = this.meNoiDung;
            this.colNoiDung.FieldName = "noidung";
            this.colNoiDung.MinWidth = 23;
            this.colNoiDung.Name = "colNoiDung";
            this.colNoiDung.Visible = true;
            this.colNoiDung.VisibleIndex = 1;
            this.colNoiDung.Width = 540;
            // 
            // meNoiDung
            // 
            this.meNoiDung.Name = "meNoiDung";
            this.meNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.None;
            // 
            // colGioGui
            // 
            this.colGioGui.Caption = "Giờ gửi";
            this.colGioGui.FieldName = "giogui";
            this.colGioGui.Name = "colGioGui";
            this.colGioGui.Visible = true;
            this.colGioGui.VisibleIndex = 2;
            // 
            // colIdThanhVien
            // 
            this.colIdThanhVien.Caption = "Id thành viên";
            this.colIdThanhVien.FieldName = "nguoigui_id";
            this.colIdThanhVien.MinWidth = 23;
            this.colIdThanhVien.Name = "colIdThanhVien";
            this.colIdThanhVien.Width = 87;
            // 
            // ceChonThanhVien
            // 
            this.ceChonThanhVien.EditValue = "";
            this.ceChonThanhVien.Location = new System.Drawing.Point(12, 372);
            this.ceChonThanhVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ceChonThanhVien.Name = "ceChonThanhVien";
            this.ceChonThanhVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceChonThanhVien.Properties.NullText = "Chọn thành viên...";
            this.ceChonThanhVien.Size = new System.Drawing.Size(273, 22);
            this.ceChonThanhVien.StyleController = this.layoutControl1;
            this.ceChonThanhVien.TabIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutBangLienHe,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem4,
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem10,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(955, 477);
            this.Root.TextVisible = false;
            // 
            // layoutBangLienHe
            // 
            this.layoutBangLienHe.Control = this.gcChat;
            this.layoutBangLienHe.Location = new System.Drawing.Point(277, 0);
            this.layoutBangLienHe.Name = "layoutBangLienHe";
            this.layoutBangLienHe.Size = new System.Drawing.Size(658, 275);
            this.layoutBangLienHe.Text = "Bảng liên hệ";
            this.layoutBangLienHe.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutBangLienHe.TextSize = new System.Drawing.Size(101, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gcNhom;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(277, 341);
            this.layoutControlItem2.Text = "Danh sách liên hệ";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(101, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ceChonThanhVien;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 341);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(277, 45);
            this.layoutControlItem3.Text = "Chọn thành viên";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(101, 16);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnGuiTinNhan;
            this.layoutControlItem6.Location = new System.Drawing.Point(778, 275);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(157, 26);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtTieuDe;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 386);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(277, 45);
            this.layoutControlItem7.Text = "Đặt tên liên hệ";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(101, 16);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnThemLienHe;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 431);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(277, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnXoaNoiDung;
            this.layoutControlItem1.Location = new System.Drawing.Point(778, 431);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(157, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.btnDanhSachThanhVien;
            this.layoutControlItem8.Location = new System.Drawing.Point(778, 301);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(157, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.listThanhVien;
            this.layoutControlItem10.Location = new System.Drawing.Point(778, 327);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(157, 104);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.meGuiTinNhan;
            this.layoutControlItem5.Location = new System.Drawing.Point(277, 275);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(501, 182);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // LienHeThanhVien
            // 
            this.AcceptButton = this.btnGuiTinNhan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 477);
            this.Controls.Add(this.layoutControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LienHeThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Liên hệ thành viên";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listThanhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTieuDe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meGuiTinNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvNhom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meNoiDung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceChonThanhVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutBangLienHe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtTieuDe;
        private DevExpress.XtraEditors.SimpleButton btnGuiTinNhan;
        private DevExpress.XtraEditors.MemoEdit meGuiTinNhan;
        private DevExpress.XtraEditors.SimpleButton btnThemLienHe;
        private DevExpress.XtraGrid.GridControl gcNhom;
        private DevExpress.XtraGrid.Views.Grid.GridView gvNhom;
        private DevExpress.XtraGrid.GridControl gcChat;
        private DevExpress.XtraGrid.Views.Grid.GridView gvChat;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutBangLienHe;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colIdChat;
        private DevExpress.XtraGrid.Columns.GridColumn colKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayGui;
        private DevExpress.XtraGrid.Columns.GridColumn colNoiDung;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit meNoiDung;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ceChonThanhVien;
        private DevExpress.XtraGrid.Columns.GridColumn colThongBao;
        private DevExpress.XtraGrid.Columns.GridColumn colIdThanhVien;
        private DevExpress.XtraGrid.Columns.GridColumn colGioGui;
        private DevExpress.XtraEditors.SimpleButton btnXoaNoiDung;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnDanhSachThanhVien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.ListBoxControl listThanhVien;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
    }
}