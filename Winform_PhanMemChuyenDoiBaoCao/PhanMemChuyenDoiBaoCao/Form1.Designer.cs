
namespace PhanMemChuyenDoiBaoCao
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDuongDan_Folder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaCauHinh = new System.Windows.Forms.Button();
            this.btnSuaCauHinh = new System.Windows.Forms.Button();
            this.cbbDocCauHinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemCauHinh = new System.Windows.Forms.Button();
            this.txtTenCauHinh = new System.Windows.Forms.TextBox();
            this.dgvLuoiDoiGiaTri = new System.Windows.Forms.DataGridView();
            this.TenThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTriCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaTriMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCapNhatGiaTriThe = new System.Windows.Forms.CheckedListBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.txtDuongDan_File = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gbTienTrinhXuLy = new System.Windows.Forms.GroupBox();
            this.lvNhieuDatasource = new System.Windows.Forms.ListView();
            this.lvNhieuPage = new System.Windows.Forms.ListView();
            this.lbTongSoFile = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbLoading = new System.Windows.Forms.ProgressBar();
            this.dgvLogXuLy = new System.Windows.Forms.DataGridView();
            this.colTenFile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiDungCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNoiDungMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuoiDoiGiaTri)).BeginInit();
            this.gbTienTrinhXuLy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogXuLy)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDuongDan_Folder
            // 
            this.txtDuongDan_Folder.Location = new System.Drawing.Point(158, 25);
            this.txtDuongDan_Folder.Name = "txtDuongDan_Folder";
            this.txtDuongDan_Folder.ReadOnly = true;
            this.txtDuongDan_Folder.Size = new System.Drawing.Size(292, 20);
            this.txtDuongDan_Folder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đường dẫn đến thư mục";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.dgvLuoiDoiGiaTri);
            this.groupBox3.Controls.Add(this.clCapNhatGiaTriThe);
            this.groupBox3.Controls.Add(this.btnOpenFile);
            this.groupBox3.Controls.Add(this.btnOpenFolder);
            this.groupBox3.Controls.Add(this.txtDuongDan_File);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtDuongDan_Folder);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(515, 742);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết chức năng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoaCauHinh);
            this.groupBox1.Controls.Add(this.btnSuaCauHinh);
            this.groupBox1.Controls.Add(this.cbbDocCauHinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnThemCauHinh);
            this.groupBox1.Controls.Add(this.txtTenCauHinh);
            this.groupBox1.Location = new System.Drawing.Point(21, 574);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 153);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cấu hình";
            // 
            // btnXoaCauHinh
            // 
            this.btnXoaCauHinh.ForeColor = System.Drawing.Color.Red;
            this.btnXoaCauHinh.Image = global::PhanMemChuyenDoiBaoCao.Properties.Resources.icons8_f3_key_50;
            this.btnXoaCauHinh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaCauHinh.Location = new System.Drawing.Point(137, 75);
            this.btnXoaCauHinh.Name = "btnXoaCauHinh";
            this.btnXoaCauHinh.Size = new System.Drawing.Size(48, 66);
            this.btnXoaCauHinh.TabIndex = 9;
            this.btnXoaCauHinh.Text = "Xóa";
            this.btnXoaCauHinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaCauHinh.UseVisualStyleBackColor = true;
            this.btnXoaCauHinh.Click += new System.EventHandler(this.btnXoaCauHinh_Click);
            // 
            // btnSuaCauHinh
            // 
            this.btnSuaCauHinh.Image = global::PhanMemChuyenDoiBaoCao.Properties.Resources.icons8_f4_key_50;
            this.btnSuaCauHinh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaCauHinh.Location = new System.Drawing.Point(191, 75);
            this.btnSuaCauHinh.Name = "btnSuaCauHinh";
            this.btnSuaCauHinh.Size = new System.Drawing.Size(48, 66);
            this.btnSuaCauHinh.TabIndex = 10;
            this.btnSuaCauHinh.Text = "Sửa";
            this.btnSuaCauHinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaCauHinh.UseVisualStyleBackColor = true;
            this.btnSuaCauHinh.Click += new System.EventHandler(this.btnSuaCauHinh_Click);
            // 
            // cbbDocCauHinh
            // 
            this.cbbDocCauHinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDocCauHinh.FormattingEnabled = true;
            this.cbbDocCauHinh.Location = new System.Drawing.Point(137, 19);
            this.cbbDocCauHinh.Name = "cbbDocCauHinh";
            this.cbbDocCauHinh.Size = new System.Drawing.Size(156, 21);
            this.cbbDocCauHinh.TabIndex = 7;
            this.cbbDocCauHinh.SelectedValueChanged += new System.EventHandler(this.cbbDocCauHinh_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tên cấu hình";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Đọc cấu hình";
            // 
            // btnThemCauHinh
            // 
            this.btnThemCauHinh.Image = global::PhanMemChuyenDoiBaoCao.Properties.Resources.icons8_f5_key_50;
            this.btnThemCauHinh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemCauHinh.Location = new System.Drawing.Point(245, 75);
            this.btnThemCauHinh.Name = "btnThemCauHinh";
            this.btnThemCauHinh.Size = new System.Drawing.Size(48, 66);
            this.btnThemCauHinh.TabIndex = 11;
            this.btnThemCauHinh.Text = "Thêm";
            this.btnThemCauHinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemCauHinh.UseVisualStyleBackColor = true;
            this.btnThemCauHinh.Click += new System.EventHandler(this.btnLuuCauHinh_Click);
            // 
            // txtTenCauHinh
            // 
            this.txtTenCauHinh.Location = new System.Drawing.Point(137, 49);
            this.txtTenCauHinh.Name = "txtTenCauHinh";
            this.txtTenCauHinh.Size = new System.Drawing.Size(156, 20);
            this.txtTenCauHinh.TabIndex = 8;
            this.txtTenCauHinh.TextChanged += new System.EventHandler(this.txtTenCauHinh_TextChanged);
            // 
            // dgvLuoiDoiGiaTri
            // 
            this.dgvLuoiDoiGiaTri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuoiDoiGiaTri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLuoiDoiGiaTri.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenThe,
            this.colGiaTriCu,
            this.colGiaTriMoi});
            this.dgvLuoiDoiGiaTri.Location = new System.Drawing.Point(21, 232);
            this.dgvLuoiDoiGiaTri.Name = "dgvLuoiDoiGiaTri";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLuoiDoiGiaTri.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLuoiDoiGiaTri.Size = new System.Drawing.Size(475, 328);
            this.dgvLuoiDoiGiaTri.TabIndex = 6;
            // 
            // TenThe
            // 
            this.TenThe.HeaderText = "Tên Thẻ";
            this.TenThe.Name = "TenThe";
            // 
            // colGiaTriCu
            // 
            this.colGiaTriCu.HeaderText = "Giá trị cũ";
            this.colGiaTriCu.Name = "colGiaTriCu";
            // 
            // colGiaTriMoi
            // 
            this.colGiaTriMoi.HeaderText = "Giá Trị Mới";
            this.colGiaTriMoi.Name = "colGiaTriMoi";
            // 
            // clCapNhatGiaTriThe
            // 
            this.clCapNhatGiaTriThe.CheckOnClick = true;
            this.clCapNhatGiaTriThe.FormattingEnabled = true;
            this.clCapNhatGiaTriThe.Items.AddRange(new object[] {
            "Đổi tên trường cố định",
            "Thêm tham số mẫu",
            "Đổi nhóm",
            "Thêm liên kết bảng",
            "Thêm thẻ dữ liệu",
            "Sửa watermark",
            "Sửa Datasource thành JSON",
            "Chuyển tham số thành trường dữ liệu (chỉ giữ tham số mẫu)",
            "Thêm tiền tố trường dữ liệu vào tham số cũ áp dụng cho chứng từ"});
            this.clCapNhatGiaTriThe.Location = new System.Drawing.Point(158, 51);
            this.clCapNhatGiaTriThe.Name = "clCapNhatGiaTriThe";
            this.clCapNhatGiaTriThe.Size = new System.Drawing.Size(338, 139);
            this.clCapNhatGiaTriThe.TabIndex = 3;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Image = global::PhanMemChuyenDoiBaoCao.Properties.Resources.icons8_f2_key_50;
            this.btnOpenFile.Location = new System.Drawing.Point(456, 196);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(40, 30);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Image = global::PhanMemChuyenDoiBaoCao.Properties.Resources.icons8_f1_key_50;
            this.btnOpenFolder.Location = new System.Drawing.Point(456, 19);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(40, 30);
            this.btnOpenFolder.TabIndex = 2;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // txtDuongDan_File
            // 
            this.txtDuongDan_File.Location = new System.Drawing.Point(158, 202);
            this.txtDuongDan_File.Name = "txtDuongDan_File";
            this.txtDuongDan_File.ReadOnly = true;
            this.txtDuongDan_File.Size = new System.Drawing.Size(292, 20);
            this.txtDuongDan_File.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 205);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 6;
            this.label13.Text = "Chọn file tham chiếu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Cập nhật giá trị trong thẻ";
            // 
            // gbTienTrinhXuLy
            // 
            this.gbTienTrinhXuLy.Controls.Add(this.lvNhieuDatasource);
            this.gbTienTrinhXuLy.Controls.Add(this.lvNhieuPage);
            this.gbTienTrinhXuLy.Controls.Add(this.lbTongSoFile);
            this.gbTienTrinhXuLy.Controls.Add(this.label6);
            this.gbTienTrinhXuLy.Controls.Add(this.label5);
            this.gbTienTrinhXuLy.Controls.Add(this.label4);
            this.gbTienTrinhXuLy.Controls.Add(this.pbLoading);
            this.gbTienTrinhXuLy.Controls.Add(this.dgvLogXuLy);
            this.gbTienTrinhXuLy.Controls.Add(this.btnThucHien);
            this.gbTienTrinhXuLy.Location = new System.Drawing.Point(537, 12);
            this.gbTienTrinhXuLy.Name = "gbTienTrinhXuLy";
            this.gbTienTrinhXuLy.Size = new System.Drawing.Size(517, 742);
            this.gbTienTrinhXuLy.TabIndex = 3;
            this.gbTienTrinhXuLy.TabStop = false;
            this.gbTienTrinhXuLy.Text = "Tiến trình xử lý";
            // 
            // lvNhieuDatasource
            // 
            this.lvNhieuDatasource.HideSelection = false;
            this.lvNhieuDatasource.Location = new System.Drawing.Point(185, 115);
            this.lvNhieuDatasource.Name = "lvNhieuDatasource";
            this.lvNhieuDatasource.Size = new System.Drawing.Size(311, 58);
            this.lvNhieuDatasource.TabIndex = 21;
            this.lvNhieuDatasource.UseCompatibleStateImageBehavior = false;
            this.lvNhieuDatasource.View = System.Windows.Forms.View.List;
            // 
            // lvNhieuPage
            // 
            this.lvNhieuPage.HideSelection = false;
            this.lvNhieuPage.Location = new System.Drawing.Point(185, 51);
            this.lvNhieuPage.Name = "lvNhieuPage";
            this.lvNhieuPage.Size = new System.Drawing.Size(310, 58);
            this.lvNhieuPage.TabIndex = 20;
            this.lvNhieuPage.UseCompatibleStateImageBehavior = false;
            this.lvNhieuPage.View = System.Windows.Forms.View.List;
            // 
            // lbTongSoFile
            // 
            this.lbTongSoFile.AutoSize = true;
            this.lbTongSoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongSoFile.Location = new System.Drawing.Point(182, 28);
            this.lbTongSoFile.Name = "lbTongSoFile";
            this.lbTongSoFile.Size = new System.Drawing.Size(14, 13);
            this.lbTongSoFile.TabIndex = 19;
            this.lbTongSoFile.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Danh sách file nhiều hơn 2 bảng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Danh sách file nhiều hơn 1 Page";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tổng số file thực hiện";
            // 
            // pbLoading
            // 
            this.pbLoading.Location = new System.Drawing.Point(75, 649);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(421, 66);
            this.pbLoading.TabIndex = 1;
            this.pbLoading.Visible = false;
            // 
            // dgvLogXuLy
            // 
            this.dgvLogXuLy.AllowUserToAddRows = false;
            this.dgvLogXuLy.AllowUserToDeleteRows = false;
            this.dgvLogXuLy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogXuLy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogXuLy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenFile,
            this.colThe,
            this.colNoiDungCu,
            this.colNoiDungMoi});
            this.dgvLogXuLy.Location = new System.Drawing.Point(21, 232);
            this.dgvLogXuLy.Name = "dgvLogXuLy";
            this.dgvLogXuLy.ReadOnly = true;
            this.dgvLogXuLy.Size = new System.Drawing.Size(475, 411);
            this.dgvLogXuLy.TabIndex = 13;
            // 
            // colTenFile
            // 
            this.colTenFile.HeaderText = "Tên File";
            this.colTenFile.Name = "colTenFile";
            this.colTenFile.ReadOnly = true;
            // 
            // colThe
            // 
            this.colThe.HeaderText = "Tên Thẻ";
            this.colThe.Name = "colThe";
            this.colThe.ReadOnly = true;
            // 
            // colNoiDungCu
            // 
            this.colNoiDungCu.HeaderText = "Nội Dung Cũ";
            this.colNoiDungCu.Name = "colNoiDungCu";
            this.colNoiDungCu.ReadOnly = true;
            // 
            // colNoiDungMoi
            // 
            this.colNoiDungMoi.HeaderText = "Nội Dung Mới";
            this.colNoiDungMoi.Name = "colNoiDungMoi";
            this.colNoiDungMoi.ReadOnly = true;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThucHien.ForeColor = System.Drawing.Color.Black;
            this.btnThucHien.Image = global::PhanMemChuyenDoiBaoCao.Properties.Resources.icons8_f6_key_50;
            this.btnThucHien.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThucHien.Location = new System.Drawing.Point(20, 649);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(48, 66);
            this.btnThucHien.TabIndex = 12;
            this.btnThucHien.Text = "Chạy";
            this.btnThucHien.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 770);
            this.Controls.Add(this.gbTienTrinhXuLy);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm chuyển đổi bảo cáo và chứng từ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuoiDoiGiaTri)).EndInit();
            this.gbTienTrinhXuLy.ResumeLayout(false);
            this.gbTienTrinhXuLy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogXuLy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDuongDan_Folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDuongDan_File;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.CheckedListBox clCapNhatGiaTriThe;
        private System.Windows.Forms.DataGridView dgvLuoiDoiGiaTri;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTriCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaTriMoi;
        private System.Windows.Forms.Button btnThemCauHinh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbDocCauHinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenCauHinh;
        private System.Windows.Forms.Button btnXoaCauHinh;
        private System.Windows.Forms.Button btnSuaCauHinh;
        private System.Windows.Forms.GroupBox gbTienTrinhXuLy;
        private System.Windows.Forms.DataGridView dgvLogXuLy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiDungCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNoiDungMoi;
        private System.Windows.Forms.ProgressBar pbLoading;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTongSoFile;
        private System.Windows.Forms.ListView lvNhieuDatasource;
        private System.Windows.Forms.ListView lvNhieuPage;
    }
}

