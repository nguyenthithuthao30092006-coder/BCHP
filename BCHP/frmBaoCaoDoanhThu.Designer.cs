namespace BCHP
{
    partial class frmBaoCaoDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilter = new System.Windows.Forms.Panel();
            this.lblTuNgay = new System.Windows.Forms.Label();
            this.dtpTuNgay = new System.Windows.Forms.DateTimePicker();
            this.lblDenNgay = new System.Windows.Forms.Label();
            this.dtpDenNgay = new System.Windows.Forms.DateTimePicker();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardDoanhThu = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.lblDoanhThuTitle = new System.Windows.Forms.Label();
            this.cardHoaDon = new System.Windows.Forms.Panel();
            this.lblHoaDon = new System.Windows.Forms.Label();
            this.lblHoaDonTitle = new System.Windows.Forms.Label();
            this.cardGiamGia = new System.Windows.Forms.Panel();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblGiamGiaTitle = new System.Windows.Forms.Label();
            this.cardTruocGiam = new System.Windows.Forms.Panel();
            this.lblTruocGiam = new System.Windows.Forms.Label();
            this.lblTruocGiamTitle = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.pnlBieuDo = new System.Windows.Forms.Panel();
            this.tabInvoices = new System.Windows.Forms.TabPage();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.tabProducts = new System.Windows.Forms.TabPage();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.pnlFilter.SuspendLayout();
            this.tlpCards.SuspendLayout();
            this.cardDoanhThu.SuspendLayout();
            this.cardHoaDon.SuspendLayout();
            this.cardGiamGia.SuspendLayout();
            this.cardTruocGiam.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabChart.SuspendLayout();
            this.tabInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.tabProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.lblTitle.Location = new System.Drawing.Point(22, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(297, 36);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO DOANH THU";
            // 
            // pnlFilter
            // 
            this.pnlFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilter.BackColor = System.Drawing.Color.White;
            this.pnlFilter.Controls.Add(this.lblTuNgay);
            this.pnlFilter.Controls.Add(this.dtpTuNgay);
            this.pnlFilter.Controls.Add(this.lblDenNgay);
            this.pnlFilter.Controls.Add(this.dtpDenNgay);
            this.pnlFilter.Controls.Add(this.btnLoc);
            this.pnlFilter.Controls.Add(this.btnXuat);
            this.pnlFilter.Location = new System.Drawing.Point(22, 62);
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(1055, 62);
            this.pnlFilter.TabIndex = 1;
            // 
            // lblTuNgay
            // 
            this.lblTuNgay.AutoSize = true;
            this.lblTuNgay.Location = new System.Drawing.Point(15, 21);
            this.lblTuNgay.Name = "lblTuNgay";
            this.lblTuNgay.Size = new System.Drawing.Size(49, 15);
            this.lblTuNgay.TabIndex = 0;
            this.lblTuNgay.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTuNgay.Location = new System.Drawing.Point(75, 17);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(135, 23);
            this.dtpTuNgay.TabIndex = 1;
            // 
            // lblDenNgay
            // 
            this.lblDenNgay.AutoSize = true;
            this.lblDenNgay.Location = new System.Drawing.Point(230, 21);
            this.lblDenNgay.Name = "lblDenNgay";
            this.lblDenNgay.Size = new System.Drawing.Size(57, 15);
            this.lblDenNgay.TabIndex = 2;
            this.lblDenNgay.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenNgay.Location = new System.Drawing.Point(300, 17);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(135, 23);
            this.dtpDenNgay.TabIndex = 3;
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLoc.FlatAppearance.BorderSize = 0;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(455, 14);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(115, 34);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc báo cáo";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(100)))));
            this.btnXuat.FlatAppearance.BorderSize = 0;
            this.btnXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuat.ForeColor = System.Drawing.Color.White;
            this.btnXuat.Location = new System.Drawing.Point(585, 14);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(145, 34);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "Xuất CSV hóa đơn";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // tlpCards
            // 
            this.tlpCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCards.ColumnCount = 4;
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpCards.Controls.Add(this.cardDoanhThu, 0, 0);
            this.tlpCards.Controls.Add(this.cardHoaDon, 1, 0);
            this.tlpCards.Controls.Add(this.cardGiamGia, 2, 0);
            this.tlpCards.Controls.Add(this.cardTruocGiam, 3, 0);
            this.tlpCards.Location = new System.Drawing.Point(22, 140);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.RowCount = 1;
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCards.Size = new System.Drawing.Size(1055, 96);
            this.tlpCards.TabIndex = 2;
            // 
            // cardDoanhThu
            // 
            this.cardDoanhThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(200)))));
            this.cardDoanhThu.Controls.Add(this.lblDoanhThu);
            this.cardDoanhThu.Controls.Add(this.lblDoanhThuTitle);
            this.cardDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.cardDoanhThu.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.cardDoanhThu.Name = "cardDoanhThu";
            this.cardDoanhThu.Size = new System.Drawing.Size(257, 96);
            this.cardDoanhThu.TabIndex = 0;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.lblDoanhThu.Location = new System.Drawing.Point(13, 42);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(24, 28);
            this.lblDoanhThu.TabIndex = 1;
            this.lblDoanhThu.Text = "0";
            // 
            // lblDoanhThuTitle
            // 
            this.lblDoanhThuTitle.AutoSize = true;
            this.lblDoanhThuTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.lblDoanhThuTitle.Location = new System.Drawing.Point(13, 13);
            this.lblDoanhThuTitle.Name = "lblDoanhThuTitle";
            this.lblDoanhThuTitle.Size = new System.Drawing.Size(142, 15);
            this.lblDoanhThuTitle.TabIndex = 0;
            this.lblDoanhThuTitle.Text = "DOANH THU THỰC THU";
            // 
            // cardHoaDon
            // 
            this.cardHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(200)))));
            this.cardHoaDon.Controls.Add(this.lblHoaDon);
            this.cardHoaDon.Controls.Add(this.lblHoaDonTitle);
            this.cardHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardHoaDon.Location = new System.Drawing.Point(269, 0);
            this.cardHoaDon.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cardHoaDon.Name = "cardHoaDon";
            this.cardHoaDon.Size = new System.Drawing.Size(251, 96);
            this.cardHoaDon.TabIndex = 1;
            // 
            // lblHoaDon
            // 
            this.lblHoaDon.AutoSize = true;
            this.lblHoaDon.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.lblHoaDon.Location = new System.Drawing.Point(13, 42);
            this.lblHoaDon.Name = "lblHoaDon";
            this.lblHoaDon.Size = new System.Drawing.Size(24, 28);
            this.lblHoaDon.TabIndex = 1;
            this.lblHoaDon.Text = "0";
            // 
            // lblHoaDonTitle
            // 
            this.lblHoaDonTitle.AutoSize = true;
            this.lblHoaDonTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblHoaDonTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.lblHoaDonTitle.Location = new System.Drawing.Point(13, 13);
            this.lblHoaDonTitle.Name = "lblHoaDonTitle";
            this.lblHoaDonTitle.Size = new System.Drawing.Size(82, 15);
            this.lblHoaDonTitle.TabIndex = 0;
            this.lblHoaDonTitle.Text = "SỐ HÓA ĐƠN";
            // 
            // cardGiamGia
            // 
            this.cardGiamGia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(200)))));
            this.cardGiamGia.Controls.Add(this.lblGiamGia);
            this.cardGiamGia.Controls.Add(this.lblGiamGiaTitle);
            this.cardGiamGia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardGiamGia.Location = new System.Drawing.Point(532, 0);
            this.cardGiamGia.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cardGiamGia.Name = "cardGiamGia";
            this.cardGiamGia.Size = new System.Drawing.Size(251, 96);
            this.cardGiamGia.TabIndex = 2;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoSize = true;
            this.lblGiamGia.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblGiamGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.lblGiamGia.Location = new System.Drawing.Point(13, 42);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(24, 28);
            this.lblGiamGia.TabIndex = 1;
            this.lblGiamGia.Text = "0";
            // 
            // lblGiamGiaTitle
            // 
            this.lblGiamGiaTitle.AutoSize = true;
            this.lblGiamGiaTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblGiamGiaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.lblGiamGiaTitle.Location = new System.Drawing.Point(13, 13);
            this.lblGiamGiaTitle.Name = "lblGiamGiaTitle";
            this.lblGiamGiaTitle.Size = new System.Drawing.Size(100, 15);
            this.lblGiamGiaTitle.TabIndex = 0;
            this.lblGiamGiaTitle.Text = "TỔNG GIẢM GIÁ";
            // 
            // cardTruocGiam
            // 
            this.cardTruocGiam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(200)))));
            this.cardTruocGiam.Controls.Add(this.lblTruocGiam);
            this.cardTruocGiam.Controls.Add(this.lblTruocGiamTitle);
            this.cardTruocGiam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTruocGiam.Location = new System.Drawing.Point(795, 0);
            this.cardTruocGiam.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.cardTruocGiam.Name = "cardTruocGiam";
            this.cardTruocGiam.Size = new System.Drawing.Size(260, 96);
            this.cardTruocGiam.TabIndex = 3;
            // 
            // lblTruocGiam
            // 
            this.lblTruocGiam.AutoSize = true;
            this.lblTruocGiam.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblTruocGiam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.lblTruocGiam.Location = new System.Drawing.Point(13, 42);
            this.lblTruocGiam.Name = "lblTruocGiam";
            this.lblTruocGiam.Size = new System.Drawing.Size(24, 28);
            this.lblTruocGiam.TabIndex = 1;
            this.lblTruocGiam.Text = "0";
            // 
            // lblTruocGiamTitle
            // 
            this.lblTruocGiamTitle.AutoSize = true;
            this.lblTruocGiamTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblTruocGiamTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.lblTruocGiamTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTruocGiamTitle.Name = "lblTruocGiamTitle";
            this.lblTruocGiamTitle.Size = new System.Drawing.Size(119, 15);
            this.lblTruocGiamTitle.TabIndex = 0;
            this.lblTruocGiamTitle.Text = "TỔNG TRƯỚC GIẢM";
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabChart);
            this.tabs.Controls.Add(this.tabInvoices);
            this.tabs.Controls.Add(this.tabProducts);
            this.tabs.Location = new System.Drawing.Point(22, 255);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1055, 342);
            this.tabs.TabIndex = 3;
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.pnlBieuDo);
            this.tabChart.Location = new System.Drawing.Point(4, 24);
            this.tabChart.Name = "tabChart";
            this.tabChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabChart.Size = new System.Drawing.Size(1047, 314);
            this.tabChart.TabIndex = 0;
            this.tabChart.Text = "Biểu đồ doanh thu";
            this.tabChart.UseVisualStyleBackColor = true;
            // 
            // pnlBieuDo
            // 
            this.pnlBieuDo.BackColor = System.Drawing.Color.White;
            this.pnlBieuDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBieuDo.Location = new System.Drawing.Point(3, 3);
            this.pnlBieuDo.Name = "pnlBieuDo";
            this.pnlBieuDo.Size = new System.Drawing.Size(1041, 308);
            this.pnlBieuDo.TabIndex = 0;
            this.pnlBieuDo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBieuDo_Paint);
            this.pnlBieuDo.Resize += new System.EventHandler(this.pnlBieuDo_Resize);
            // 
            // tabInvoices
            // 
            this.tabInvoices.Controls.Add(this.dgvHoaDon);
            this.tabInvoices.Location = new System.Drawing.Point(4, 24);
            this.tabInvoices.Name = "tabInvoices";
            this.tabInvoices.Padding = new System.Windows.Forms.Padding(3);
            this.tabInvoices.Size = new System.Drawing.Size(1047, 417);
            this.tabInvoices.TabIndex = 1;
            this.tabInvoices.Text = "Danh sách hóa đơn";
            this.tabInvoices.UseVisualStyleBackColor = true;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHoaDon.Location = new System.Drawing.Point(3, 3);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(1041, 411);
            this.dgvHoaDon.TabIndex = 0;
            // 
            // tabProducts
            // 
            this.tabProducts.Controls.Add(this.dgvSanPham);
            this.tabProducts.Location = new System.Drawing.Point(4, 24);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabProducts.Size = new System.Drawing.Size(1047, 417);
            this.tabProducts.TabIndex = 2;
            this.tabProducts.Text = "Bánh bán chạy";
            this.tabProducts.UseVisualStyleBackColor = true;
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.AllowUserToDeleteRows = false;
            this.dgvSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgvSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSanPham.Location = new System.Drawing.Point(3, 3);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersVisible = false;
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(1041, 411);
            this.dgvSanPham.TabIndex = 0;
            // 
            // frmBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(250)))), ((int)(((byte)(244)))));
            this.ClientSize = new System.Drawing.Size(1100, 617);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlFilter);
            this.Controls.Add(this.tlpCards);
            this.Controls.Add(this.tabs);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(900, 620);
            this.Name = "frmBaoCaoDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh thu - Le Gâteau";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThu_Load);
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.tlpCards.ResumeLayout(false);
            this.cardDoanhThu.ResumeLayout(false);
            this.cardDoanhThu.PerformLayout();
            this.cardHoaDon.ResumeLayout(false);
            this.cardHoaDon.PerformLayout();
            this.cardGiamGia.ResumeLayout(false);
            this.cardGiamGia.PerformLayout();
            this.cardTruocGiam.ResumeLayout(false);
            this.cardTruocGiam.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabChart.ResumeLayout(false);
            this.tabInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.tabProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilter;
        private System.Windows.Forms.Label lblTuNgay;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.Label lblDenNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private System.Windows.Forms.Panel cardDoanhThu;
        private System.Windows.Forms.Label lblDoanhThuTitle;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Panel cardHoaDon;
        private System.Windows.Forms.Label lblHoaDonTitle;
        private System.Windows.Forms.Label lblHoaDon;
        private System.Windows.Forms.Panel cardGiamGia;
        private System.Windows.Forms.Label lblGiamGiaTitle;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Panel cardTruocGiam;
        private System.Windows.Forms.Label lblTruocGiamTitle;
        private System.Windows.Forms.Label lblTruocGiam;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabChart;
        private System.Windows.Forms.TabPage tabInvoices;
        private System.Windows.Forms.TabPage tabProducts;
        private System.Windows.Forms.Panel pnlBieuDo;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridView dgvSanPham;
    }
}
