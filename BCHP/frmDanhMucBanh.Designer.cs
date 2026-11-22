namespace QuanLyBanBanh
{
    partial class frmDanhMucBanh
    {
        private System.ComponentModel.IContainer components = null;

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
        /// Phần này do Visual Studio quản lý: khi bạn kéo thả / sửa thuộc tính trong
        /// cửa sổ Designer, Visual Studio tự sửa code ở đây.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cboFilterLoai = new System.Windows.Forms.ComboBox();
            this.dgvCakes = new System.Windows.Forms.DataGridView();
            this.colMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHanDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblLegendExpired = new System.Windows.Forms.Label();
            this.lblLegendNearExpiry = new System.Windows.Forms.Label();
            this.lblLegendLowStock = new System.Windows.Forms.Label();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMaBanh = new System.Windows.Forms.Label();
            this.txtMaBanh = new System.Windows.Forms.TextBox();
            this.lblTenBanh = new System.Windows.Forms.Label();
            this.txtTenBanh = new System.Windows.Forms.TextBox();
            this.lblKichCo = new System.Windows.Forms.Label();
            this.cboKichCo = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.lblTon = new System.Windows.Forms.Label();
            this.nudTon = new System.Windows.Forms.NumericUpDown();
            this.lblHanDung = new System.Windows.Forms.Label();
            this.dtpHanDung = new System.Windows.Forms.DateTimePicker();
            this.lblDonGiaError = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCakes)).BeginInit();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(40)))), ((int)(((byte)(84)))));
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1007, 39);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(149, 21);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "DANH MỤC BÁNH";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(20, 48);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(77, 15);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Tìm tên bánh";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(110, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(260, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cboFilterLoai
            // 
            this.cboFilterLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterLoai.FormattingEnabled = true;
            this.cboFilterLoai.Items.AddRange(new object[] {
            "Tất cả loại",
            "BongLan",
            "Mousse",
            "KemTuoi"});
            this.cboFilterLoai.Location = new System.Drawing.Point(390, 45);
            this.cboFilterLoai.Name = "cboFilterLoai";
            this.cboFilterLoai.Size = new System.Drawing.Size(150, 23);
            this.cboFilterLoai.TabIndex = 3;
            this.cboFilterLoai.SelectedIndexChanged += new System.EventHandler(this.cboFilterLoai_SelectedIndexChanged);
            // 
            // dgvCakes
            // 
            this.dgvCakes.AllowUserToAddRows = false;
            this.dgvCakes.AllowUserToDeleteRows = false;
            this.dgvCakes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCakes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCakes.BackgroundColor = System.Drawing.Color.White;
            this.dgvCakes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCakes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa,
            this.colTen,
            this.colLoai,
            this.colKichCo,
            this.colDonGia,
            this.colTon,
            this.colHanDung});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(40)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCakes.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCakes.Location = new System.Drawing.Point(20, 80);
            this.dgvCakes.MultiSelect = false;
            this.dgvCakes.Name = "dgvCakes";
            this.dgvCakes.ReadOnly = true;
            this.dgvCakes.RowHeadersVisible = false;
            this.dgvCakes.RowHeadersWidth = 82;
            this.dgvCakes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCakes.Size = new System.Drawing.Size(967, 200);
            this.dgvCakes.TabIndex = 4;
            this.dgvCakes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCakes_CellFormatting);
            this.dgvCakes.SelectionChanged += new System.EventHandler(this.dgvCakes_SelectionChanged);
            // 
            // colMa
            // 
            this.colMa.DataPropertyName = "Ma";
            this.colMa.FillWeight = 12F;
            this.colMa.HeaderText = "Mã";
            this.colMa.MinimumWidth = 10;
            this.colMa.Name = "colMa";
            this.colMa.ReadOnly = true;
            // 
            // colTen
            // 
            this.colTen.DataPropertyName = "TenBanh";
            this.colTen.FillWeight = 30F;
            this.colTen.HeaderText = "Tên bánh";
            this.colTen.MinimumWidth = 10;
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            // 
            // colLoai
            // 
            this.colLoai.DataPropertyName = "Loai";
            this.colLoai.FillWeight = 14F;
            this.colLoai.HeaderText = "Loại";
            this.colLoai.MinimumWidth = 10;
            this.colLoai.Name = "colLoai";
            this.colLoai.ReadOnly = true;
            // 
            // colKichCo
            // 
            this.colKichCo.DataPropertyName = "KichCo";
            this.colKichCo.FillWeight = 10F;
            this.colKichCo.HeaderText = "Kích cỡ";
            this.colKichCo.MinimumWidth = 10;
            this.colKichCo.Name = "colKichCo";
            this.colKichCo.ReadOnly = true;
            // 
            // colDonGia
            // 
            this.colDonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = null;
            this.colDonGia.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDonGia.FillWeight = 14F;
            this.colDonGia.HeaderText = "Đơn giá";
            this.colDonGia.MinimumWidth = 10;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;
            // 
            // colTon
            // 
            this.colTon.DataPropertyName = "Ton";
            this.colTon.FillWeight = 8F;
            this.colTon.HeaderText = "Tồn";
            this.colTon.MinimumWidth = 10;
            this.colTon.Name = "colTon";
            this.colTon.ReadOnly = true;
            // 
            // colHanDung
            // 
            this.colHanDung.DataPropertyName = "HanDung";
            dataGridViewCellStyle8.Format = "dd/MM/yyyy";
            dataGridViewCellStyle8.NullValue = null;
            this.colHanDung.DefaultCellStyle = dataGridViewCellStyle8;
            this.colHanDung.FillWeight = 14F;
            this.colHanDung.HeaderText = "Hạn dùng";
            this.colHanDung.MinimumWidth = 10;
            this.colHanDung.Name = "colHanDung";
            this.colHanDung.ReadOnly = true;
            // 
            // lblLegendExpired
            // 
            this.lblLegendExpired.AutoSize = true;
            this.lblLegendExpired.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(200)))), ((int)(((byte)(210)))));
            this.lblLegendExpired.Location = new System.Drawing.Point(20, 290);
            this.lblLegendExpired.Name = "lblLegendExpired";
            this.lblLegendExpired.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.lblLegendExpired.Size = new System.Drawing.Size(57, 19);
            this.lblLegendExpired.TabIndex = 5;
            this.lblLegendExpired.Text = "Hết hạn";
            // 
            // lblLegendNearExpiry
            // 
            this.lblLegendNearExpiry.AutoSize = true;
            this.lblLegendNearExpiry.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblLegendNearExpiry.Location = new System.Drawing.Point(90, 293);
            this.lblLegendNearExpiry.Name = "lblLegendNearExpiry";
            this.lblLegendNearExpiry.Size = new System.Drawing.Size(84, 15);
            this.lblLegendNearExpiry.TabIndex = 6;
            this.lblLegendNearExpiry.Text = "Còn ≤ 30 ngày";
            // 
            // lblLegendLowStock
            // 
            this.lblLegendLowStock.AutoSize = true;
            this.lblLegendLowStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLegendLowStock.Location = new System.Drawing.Point(200, 293);
            this.lblLegendLowStock.Name = "lblLegendLowStock";
            this.lblLegendLowStock.Size = new System.Drawing.Size(56, 15);
            this.lblLegendLowStock.TabIndex = 7;
            this.lblLegendLowStock.Text = "Tồn < 10";
            // 
            // pnlInput
            // 
            this.pnlInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlInput.Controls.Add(this.btnXoa);
            this.pnlInput.Controls.Add(this.lblMaBanh);
            this.pnlInput.Controls.Add(this.txtMaBanh);
            this.pnlInput.Controls.Add(this.lblTenBanh);
            this.pnlInput.Controls.Add(this.txtTenBanh);
            this.pnlInput.Controls.Add(this.lblKichCo);
            this.pnlInput.Controls.Add(this.cboKichCo);
            this.pnlInput.Controls.Add(this.lblDonGia);
            this.pnlInput.Controls.Add(this.txtDonGia);
            this.pnlInput.Controls.Add(this.lblTon);
            this.pnlInput.Controls.Add(this.nudTon);
            this.pnlInput.Controls.Add(this.lblHanDung);
            this.pnlInput.Controls.Add(this.dtpHanDung);
            this.pnlInput.Controls.Add(this.lblDonGiaError);
            this.pnlInput.Controls.Add(this.lblLoai);
            this.pnlInput.Controls.Add(this.cboLoai);
            this.pnlInput.Controls.Add(this.btnThem);
            this.pnlInput.Controls.Add(this.btnSua);
            this.pnlInput.Location = new System.Drawing.Point(20, 325);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(967, 245);
            this.pnlInput.TabIndex = 8;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.IndianRed;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(206, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 45);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMaBanh
            // 
            this.lblMaBanh.AutoSize = true;
            this.lblMaBanh.Location = new System.Drawing.Point(0, 0);
            this.lblMaBanh.Name = "lblMaBanh";
            this.lblMaBanh.Size = new System.Drawing.Size(54, 15);
            this.lblMaBanh.TabIndex = 0;
            this.lblMaBanh.Text = "Mã bánh";
            // 
            // txtMaBanh
            // 
            this.txtMaBanh.Location = new System.Drawing.Point(0, 20);
            this.txtMaBanh.MaxLength = 10;
            this.txtMaBanh.Name = "txtMaBanh";
            this.txtMaBanh.Size = new System.Drawing.Size(290, 23);
            this.txtMaBanh.TabIndex = 1;
            // 
            // lblTenBanh
            // 
            this.lblTenBanh.AutoSize = true;
            this.lblTenBanh.Location = new System.Drawing.Point(320, 0);
            this.lblTenBanh.Name = "lblTenBanh";
            this.lblTenBanh.Size = new System.Drawing.Size(55, 15);
            this.lblTenBanh.TabIndex = 2;
            this.lblTenBanh.Text = "Tên bánh";
            // 
            // txtTenBanh
            // 
            this.txtTenBanh.Location = new System.Drawing.Point(320, 20);
            this.txtTenBanh.MaxLength = 100;
            this.txtTenBanh.Name = "txtTenBanh";
            this.txtTenBanh.Size = new System.Drawing.Size(290, 23);
            this.txtTenBanh.TabIndex = 3;
            // 
            // lblKichCo
            // 
            this.lblKichCo.AutoSize = true;
            this.lblKichCo.Location = new System.Drawing.Point(640, 0);
            this.lblKichCo.Name = "lblKichCo";
            this.lblKichCo.Size = new System.Drawing.Size(46, 15);
            this.lblKichCo.TabIndex = 4;
            this.lblKichCo.Text = "Kích cỡ";
            // 
            // cboKichCo
            // 
            this.cboKichCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKichCo.FormattingEnabled = true;
            this.cboKichCo.Items.AddRange(new object[] {
            "16cm",
            "18cm",
            "20cm",
            "24cm"});
            this.cboKichCo.Location = new System.Drawing.Point(640, 20);
            this.cboKichCo.Name = "cboKichCo";
            this.cboKichCo.Size = new System.Drawing.Size(290, 23);
            this.cboKichCo.TabIndex = 5;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(0, 60);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(48, 15);
            this.lblDonGia.TabIndex = 6;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(0, 80);
            this.txtDonGia.MaxLength = 9;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(290, 23);
            this.txtDonGia.TabIndex = 7;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // lblTon
            // 
            this.lblTon.AutoSize = true;
            this.lblTon.Location = new System.Drawing.Point(320, 60);
            this.lblTon.Name = "lblTon";
            this.lblTon.Size = new System.Drawing.Size(75, 15);
            this.lblTon.TabIndex = 8;
            this.lblTon.Text = "Số lượng tồn";
            // 
            // nudTon
            // 
            this.nudTon.Location = new System.Drawing.Point(320, 80);
            this.nudTon.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudTon.Name = "nudTon";
            this.nudTon.Size = new System.Drawing.Size(290, 23);
            this.nudTon.TabIndex = 9;
            // 
            // lblHanDung
            // 
            this.lblHanDung.AutoSize = true;
            this.lblHanDung.Location = new System.Drawing.Point(640, 60);
            this.lblHanDung.Name = "lblHanDung";
            this.lblHanDung.Size = new System.Drawing.Size(60, 15);
            this.lblHanDung.TabIndex = 10;
            this.lblHanDung.Text = "Hạn dùng";
            // 
            // dtpHanDung
            // 
            this.dtpHanDung.CustomFormat = "dd/MM/yyyy";
            this.dtpHanDung.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHanDung.Location = new System.Drawing.Point(640, 80);
            this.dtpHanDung.Name = "dtpHanDung";
            this.dtpHanDung.Size = new System.Drawing.Size(290, 23);
            this.dtpHanDung.TabIndex = 11;
            // 
            // lblDonGiaError
            // 
            this.lblDonGiaError.AutoSize = true;
            this.lblDonGiaError.ForeColor = System.Drawing.Color.Firebrick;
            this.lblDonGiaError.Location = new System.Drawing.Point(0, 108);
            this.lblDonGiaError.Name = "lblDonGiaError";
            this.lblDonGiaError.Size = new System.Drawing.Size(164, 15);
            this.lblDonGiaError.TabIndex = 12;
            this.lblDonGiaError.Text = "Đơn giá phải là bội số của 100";
            this.lblDonGiaError.Visible = false;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(0, 135);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(29, 15);
            this.lblLoai.TabIndex = 13;
            this.lblLoai.Text = "Loại";
            // 
            // cboLoai
            // 
            this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Items.AddRange(new object[] {
            "BongLan",
            "Mousse",
            "KemTuoi"});
            this.cboLoai.Location = new System.Drawing.Point(0, 155);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(290, 23);
            this.cboLoai.TabIndex = 14;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(40)))), ((int)(((byte)(84)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(0, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 45);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(103, 200);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 45);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmDanhMucBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1007, 603);
            this.Controls.Add(this.pnlInput);
            this.Controls.Add(this.lblLegendLowStock);
            this.Controls.Add(this.lblLegendNearExpiry);
            this.Controls.Add(this.lblLegendExpired);
            this.Controls.Add(this.dgvCakes);
            this.Controls.Add(this.cboFilterLoai);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(800, 560);
            this.Name = "frmDanhMucBanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục bánh - Le Gâteau";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCakes)).EndInit();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // ----- Danh sách control (tên theo chức năng + vị trí) -----
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboFilterLoai;
        private System.Windows.Forms.DataGridView dgvCakes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKichCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHanDung;
        private System.Windows.Forms.Label lblLegendExpired;
        private System.Windows.Forms.Label lblLegendNearExpiry;
        private System.Windows.Forms.Label lblLegendLowStock;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblMaBanh;
        private System.Windows.Forms.TextBox txtMaBanh;
        private System.Windows.Forms.Label lblTenBanh;
        private System.Windows.Forms.TextBox txtTenBanh;
        private System.Windows.Forms.Label lblKichCo;
        private System.Windows.Forms.ComboBox cboKichCo;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblTon;
        private System.Windows.Forms.NumericUpDown nudTon;
        private System.Windows.Forms.Label lblHanDung;
        private System.Windows.Forms.DateTimePicker dtpHanDung;
        private System.Windows.Forms.Label lblDonGiaError;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
    }
}
