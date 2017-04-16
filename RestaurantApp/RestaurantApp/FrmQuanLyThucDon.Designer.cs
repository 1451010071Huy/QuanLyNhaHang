namespace RestaurantApp
{
    partial class FrmQuanLyThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyThucDon));
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.MaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThemNhom = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnSuaNhom = new System.Windows.Forms.Button();
            this.btnSuaMon = new System.Windows.Forms.Button();
            this.btnXoaNhom = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.txtMaDanhMuc = new System.Windows.Forms.TextBox();
            this.txtTenDanhMuc = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaMonAn = new System.Windows.Forms.TextBox();
            this.txtTenMonAn = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtDonViTinhtd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbTenMonAn = new System.Windows.Forms.ComboBox();
            this.cbbTenNguyenLieu = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnThemCongThuc = new System.Windows.Forms.Button();
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.MaMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMonAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDanhMuc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDanhMuc2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCongThuc = new System.Windows.Forms.DataGridView();
            this.MaMonAn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblMaMonAn = new System.Windows.Forms.Label();
            this.lblMaNguyenLieu = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnXoaCongThuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToResizeRows = false;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDanhMuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDanhMuc,
            this.TenDanhMuc,
            this.MoTa});
            this.dgvDanhMuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvDanhMuc.Location = new System.Drawing.Point(31, 187);
            this.dgvDanhMuc.MultiSelect = false;
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.ReadOnly = true;
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhMuc.Size = new System.Drawing.Size(353, 418);
            this.dgvDanhMuc.TabIndex = 4;
            this.dgvDanhMuc.TabStop = false;
            this.dgvDanhMuc.Click += new System.EventHandler(this.dgvDanhMuc_Click);
            // 
            // MaDanhMuc
            // 
            this.MaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.MaDanhMuc.HeaderText = "Mã Danh Mục";
            this.MaDanhMuc.Name = "MaDanhMuc";
            this.MaDanhMuc.ReadOnly = true;
            // 
            // TenDanhMuc
            // 
            this.TenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.TenDanhMuc.HeaderText = "Tên Danh Mục";
            this.TenDanhMuc.Name = "TenDanhMuc";
            this.TenDanhMuc.ReadOnly = true;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(407, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "DANH SÁCH THỰC ĐƠN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1025, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "CÔNG THỨC CHẾ BIÊN";
            // 
            // btnThemNhom
            // 
            this.btnThemNhom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemNhom.BackgroundImage")));
            this.btnThemNhom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNhom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemNhom.Location = new System.Drawing.Point(45, 146);
            this.btnThemNhom.Name = "btnThemNhom";
            this.btnThemNhom.Size = new System.Drawing.Size(94, 32);
            this.btnThemNhom.TabIndex = 2;
            this.btnThemNhom.Text = "Thêm";
            this.btnThemNhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemNhom.UseVisualStyleBackColor = true;
            this.btnThemNhom.Click += new System.EventHandler(this.btnThemNhom_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnThemMon.BackgroundImage")));
            this.btnThemMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThemMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Location = new System.Drawing.Point(555, 146);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(94, 32);
            this.btnThemMon.TabIndex = 8;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnSuaNhom
            // 
            this.btnSuaNhom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaNhom.BackgroundImage")));
            this.btnSuaNhom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaNhom.Location = new System.Drawing.Point(155, 146);
            this.btnSuaNhom.Name = "btnSuaNhom";
            this.btnSuaNhom.Size = new System.Drawing.Size(94, 32);
            this.btnSuaNhom.TabIndex = 3;
            this.btnSuaNhom.Text = "Sửa DM";
            this.btnSuaNhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaNhom.UseVisualStyleBackColor = true;
            this.btnSuaNhom.Click += new System.EventHandler(this.btnSuaNhom_Click);
            // 
            // btnSuaMon
            // 
            this.btnSuaMon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSuaMon.BackgroundImage")));
            this.btnSuaMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSuaMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaMon.Location = new System.Drawing.Point(667, 146);
            this.btnSuaMon.Name = "btnSuaMon";
            this.btnSuaMon.Size = new System.Drawing.Size(94, 32);
            this.btnSuaMon.TabIndex = 9;
            this.btnSuaMon.Text = "Sửa Món";
            this.btnSuaMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaMon.UseVisualStyleBackColor = true;
            this.btnSuaMon.Click += new System.EventHandler(this.btnSuaMon_Click);
            // 
            // btnXoaNhom
            // 
            this.btnXoaNhom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaNhom.BackgroundImage")));
            this.btnXoaNhom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaNhom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNhom.Location = new System.Drawing.Point(265, 146);
            this.btnXoaNhom.Name = "btnXoaNhom";
            this.btnXoaNhom.Size = new System.Drawing.Size(94, 32);
            this.btnXoaNhom.TabIndex = 4;
            this.btnXoaNhom.Text = "Xóa";
            this.btnXoaNhom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaNhom.UseVisualStyleBackColor = true;
            this.btnXoaNhom.Click += new System.EventHandler(this.btnXoaNhom_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXoaMon.BackgroundImage")));
            this.btnXoaMon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnXoaMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaMon.Location = new System.Drawing.Point(779, 146);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(94, 32);
            this.btnXoaMon.TabIndex = 10;
            this.btnXoaMon.Text = "Xóa";
            this.btnXoaMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaMon.UseVisualStyleBackColor = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // txtMaDanhMuc
            // 
            this.txtMaDanhMuc.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMaDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.txtMaDanhMuc.Location = new System.Drawing.Point(127, 67);
            this.txtMaDanhMuc.Name = "txtMaDanhMuc";
            this.txtMaDanhMuc.ReadOnly = true;
            this.txtMaDanhMuc.Size = new System.Drawing.Size(193, 22);
            this.txtMaDanhMuc.TabIndex = 5;
            this.txtMaDanhMuc.TabStop = false;
            // 
            // txtTenDanhMuc
            // 
            this.txtTenDanhMuc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.txtTenDanhMuc.Location = new System.Drawing.Point(127, 93);
            this.txtTenDanhMuc.Name = "txtTenDanhMuc";
            this.txtTenDanhMuc.Size = new System.Drawing.Size(193, 22);
            this.txtTenDanhMuc.TabIndex = 0;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoTa.ForeColor = System.Drawing.Color.Black;
            this.txtMoTa.Location = new System.Drawing.Point(127, 119);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(193, 22);
            this.txtMoTa.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Danh Mục";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên Danh Mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(31, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mô tả";
            // 
            // txtMaMonAn
            // 
            this.txtMaMonAn.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMaMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonAn.ForeColor = System.Drawing.Color.Black;
            this.txtMaMonAn.Location = new System.Drawing.Point(544, 70);
            this.txtMaMonAn.Name = "txtMaMonAn";
            this.txtMaMonAn.ReadOnly = true;
            this.txtMaMonAn.Size = new System.Drawing.Size(155, 22);
            this.txtMaMonAn.TabIndex = 8;
            this.txtMaMonAn.TabStop = false;
            // 
            // txtTenMonAn
            // 
            this.txtTenMonAn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenMonAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMonAn.ForeColor = System.Drawing.Color.Black;
            this.txtTenMonAn.Location = new System.Drawing.Point(544, 99);
            this.txtTenMonAn.Name = "txtTenMonAn";
            this.txtTenMonAn.Size = new System.Drawing.Size(155, 22);
            this.txtTenMonAn.TabIndex = 5;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.ForeColor = System.Drawing.Color.Black;
            this.txtGiaTien.Location = new System.Drawing.Point(779, 100);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(101, 22);
            this.txtGiaTien.TabIndex = 7;
            this.txtGiaTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaTien_KeyPress);
            // 
            // txtDonViTinhtd
            // 
            this.txtDonViTinhtd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonViTinhtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinhtd.ForeColor = System.Drawing.Color.Black;
            this.txtDonViTinhtd.Location = new System.Drawing.Point(779, 70);
            this.txtDonViTinhtd.Name = "txtDonViTinhtd";
            this.txtDonViTinhtd.Size = new System.Drawing.Size(145, 22);
            this.txtDonViTinhtd.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(459, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã món ăn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(459, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tên món ăn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(705, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Giá tiền";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(705, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Đơn vị tính";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(888, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "VNĐ";
            // 
            // cbbTenMonAn
            // 
            this.cbbTenMonAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTenMonAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenMonAn.FormattingEnabled = true;
            this.cbbTenMonAn.Location = new System.Drawing.Point(1138, 76);
            this.cbbTenMonAn.Name = "cbbTenMonAn";
            this.cbbTenMonAn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbTenMonAn.Size = new System.Drawing.Size(152, 21);
            this.cbbTenMonAn.TabIndex = 11;
            // 
            // cbbTenNguyenLieu
            // 
            this.cbbTenNguyenLieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbTenNguyenLieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenNguyenLieu.FormattingEnabled = true;
            this.cbbTenNguyenLieu.Location = new System.Drawing.Point(1138, 101);
            this.cbbTenNguyenLieu.Name = "cbbTenNguyenLieu";
            this.cbbTenNguyenLieu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbTenNguyenLieu.Size = new System.Drawing.Size(152, 21);
            this.cbbTenNguyenLieu.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1025, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tên món ăn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(1025, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Tên nguyên liệu";
            // 
            // btnThemCongThuc
            // 
            this.btnThemCongThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemCongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCongThuc.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCongThuc.Image")));
            this.btnThemCongThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemCongThuc.Location = new System.Drawing.Point(1070, 152);
            this.btnThemCongThuc.Name = "btnThemCongThuc";
            this.btnThemCongThuc.Size = new System.Drawing.Size(94, 32);
            this.btnThemCongThuc.TabIndex = 14;
            this.btnThemCongThuc.Text = "Thêm";
            this.btnThemCongThuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemCongThuc.UseVisualStyleBackColor = true;
            this.btnThemCongThuc.Click += new System.EventHandler(this.btnThemCongThuc_Click);
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.AllowUserToResizeRows = false;
            this.dgvMonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMonAn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvMonAn.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvMonAn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMonAn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonAn,
            this.TenMonAn,
            this.GiaTien,
            this.DonViTinh,
            this.TenDanhMuc2,
            this.MaDanhMuc2});
            this.dgvMonAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMonAn.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvMonAn.Location = new System.Drawing.Point(407, 187);
            this.dgvMonAn.MultiSelect = false;
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.ReadOnly = true;
            this.dgvMonAn.RowHeadersVisible = false;
            this.dgvMonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMonAn.Size = new System.Drawing.Size(595, 418);
            this.dgvMonAn.TabIndex = 20;
            this.dgvMonAn.TabStop = false;
            this.dgvMonAn.Click += new System.EventHandler(this.dgvMonAn_Click);
            // 
            // MaMonAn
            // 
            this.MaMonAn.DataPropertyName = "MaMonAn";
            this.MaMonAn.HeaderText = "Mã Món Ăn";
            this.MaMonAn.Name = "MaMonAn";
            this.MaMonAn.ReadOnly = true;
            // 
            // TenMonAn
            // 
            this.TenMonAn.DataPropertyName = "TenMonAn";
            this.TenMonAn.FillWeight = 110F;
            this.TenMonAn.HeaderText = "Tên Món Ăn";
            this.TenMonAn.Name = "TenMonAn";
            this.TenMonAn.ReadOnly = true;
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.FillWeight = 80F;
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.FillWeight = 60F;
            this.DonViTinh.HeaderText = "ĐVT";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // TenDanhMuc2
            // 
            this.TenDanhMuc2.DataPropertyName = "TenDanhMuc";
            this.TenDanhMuc2.FillWeight = 110F;
            this.TenDanhMuc2.HeaderText = "Tên Danh Mục";
            this.TenDanhMuc2.Name = "TenDanhMuc2";
            this.TenDanhMuc2.ReadOnly = true;
            this.TenDanhMuc2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // MaDanhMuc2
            // 
            this.MaDanhMuc2.DataPropertyName = "MaDanhMuc";
            this.MaDanhMuc2.HeaderText = "Mã Danh Mục";
            this.MaDanhMuc2.Name = "MaDanhMuc2";
            this.MaDanhMuc2.ReadOnly = true;
            // 
            // dgvCongThuc
            // 
            this.dgvCongThuc.AllowUserToResizeRows = false;
            this.dgvCongThuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongThuc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvCongThuc.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvCongThuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCongThuc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCongThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongThuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMonAn2,
            this.NguyenLieu,
            this.GhiChu});
            this.dgvCongThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCongThuc.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCongThuc.Location = new System.Drawing.Point(1025, 187);
            this.dgvCongThuc.MultiSelect = false;
            this.dgvCongThuc.Name = "dgvCongThuc";
            this.dgvCongThuc.ReadOnly = true;
            this.dgvCongThuc.RowHeadersVisible = false;
            this.dgvCongThuc.RowHeadersWidth = 40;
            this.dgvCongThuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongThuc.Size = new System.Drawing.Size(317, 418);
            this.dgvCongThuc.TabIndex = 20;
            this.dgvCongThuc.TabStop = false;
            this.dgvCongThuc.Click += new System.EventHandler(this.dgvCongThuc_Click);
            // 
            // MaMonAn2
            // 
            this.MaMonAn2.DataPropertyName = "TenMonAn";
            this.MaMonAn2.FillWeight = 85F;
            this.MaMonAn2.HeaderText = "Tên Món Ăn";
            this.MaMonAn2.Name = "MaMonAn2";
            this.MaMonAn2.ReadOnly = true;
            // 
            // NguyenLieu
            // 
            this.NguyenLieu.DataPropertyName = "TenNL";
            this.NguyenLieu.HeaderText = "Tên Nguyên Liệu";
            this.NguyenLieu.Name = "NguyenLieu";
            this.NguyenLieu.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.FillWeight = 75F;
            this.GhiChu.HeaderText = "Ghi Chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1025, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 16);
            this.label16.TabIndex = 25;
            this.label16.Text = "Ghi chú";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(1138, 128);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(152, 20);
            this.txtGhiChu.TabIndex = 13;
            // 
            // lblMaMonAn
            // 
            this.lblMaMonAn.BackColor = System.Drawing.Color.Black;
            this.lblMaMonAn.Location = new System.Drawing.Point(1309, 82);
            this.lblMaMonAn.Name = "lblMaMonAn";
            this.lblMaMonAn.Size = new System.Drawing.Size(41, 13);
            this.lblMaMonAn.TabIndex = 34;
            this.lblMaMonAn.Visible = false;
            // 
            // lblMaNguyenLieu
            // 
            this.lblMaNguyenLieu.BackColor = System.Drawing.Color.Black;
            this.lblMaNguyenLieu.Location = new System.Drawing.Point(1309, 109);
            this.lblMaNguyenLieu.Name = "lblMaNguyenLieu";
            this.lblMaNguyenLieu.Size = new System.Drawing.Size(41, 13);
            this.lblMaNguyenLieu.TabIndex = 34;
            this.lblMaNguyenLieu.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1442, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "label14";
            // 
            // btnXoaCongThuc
            // 
            this.btnXoaCongThuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoaCongThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaCongThuc.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCongThuc.Image")));
            this.btnXoaCongThuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaCongThuc.Location = new System.Drawing.Point(1196, 152);
            this.btnXoaCongThuc.Name = "btnXoaCongThuc";
            this.btnXoaCongThuc.Size = new System.Drawing.Size(94, 32);
            this.btnXoaCongThuc.TabIndex = 15;
            this.btnXoaCongThuc.Text = "Xóa";
            this.btnXoaCongThuc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaCongThuc.UseVisualStyleBackColor = true;
            this.btnXoaCongThuc.Click += new System.EventHandler(this.btnXoaCongThuc_Click);
            // 
            // FrmQuanLyThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1354, 729);
            this.Controls.Add(this.btnXoaCongThuc);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblMaNguyenLieu);
            this.Controls.Add(this.lblMaMonAn);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dgvCongThuc);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.dgvMonAn);
            this.Controls.Add(this.btnThemCongThuc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbbTenNguyenLieu);
            this.Controls.Add(this.cbbTenMonAn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenDanhMuc);
            this.Controls.Add(this.txtDonViTinhtd);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.txtTenMonAn);
            this.Controls.Add(this.txtMaMonAn);
            this.Controls.Add(this.txtMaDanhMuc);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.btnXoaNhom);
            this.Controls.Add(this.btnSuaMon);
            this.Controls.Add(this.btnSuaNhom);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.btnThemNhom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmQuanLyThucDon";
            this.Text = "1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQuanLyThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongThuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemNhom;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnSuaNhom;
        private System.Windows.Forms.Button btnSuaMon;
        private System.Windows.Forms.Button btnXoaNhom;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.TextBox txtMaDanhMuc;
        private System.Windows.Forms.TextBox txtTenDanhMuc;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaMonAn;
        private System.Windows.Forms.TextBox txtTenMonAn;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.TextBox txtDonViTinhtd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.ComboBox cbbTenMonAn;
        private System.Windows.Forms.ComboBox cbbTenNguyenLieu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnThemCongThuc;
        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMonAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDanhMuc2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDanhMuc2;
        private System.Windows.Forms.DataGridView dgvCongThuc;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lblMaMonAn;
        private System.Windows.Forms.Label lblMaNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMonAn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnXoaCongThuc;
    }
}