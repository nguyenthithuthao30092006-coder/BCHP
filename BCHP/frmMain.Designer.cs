namespace BCHP
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanBanh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMoCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLuuCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGioiThieu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbBanh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbBanBanh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbMoCSV = new System.Windows.Forms.ToolStripButton();
            this.tsbLuuCSV = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbDoanhThu = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslForm = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslSapHet = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslDongHo = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDanhMuc,
            this.mnuNghiepVu,
            this.mnuBaoCao,
            this.mnuCuaSo,
            this.mnuTroGiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.mnuCuaSo;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "DisplayStyle";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDangXuat,
            this.mnuThoat});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(147, 22);
            this.mnuDangXuat.Text = "Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mnuThoat.Size = new System.Drawing.Size(147, 22);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBanh});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "Danh mục";
            // 
            // mnuBanh
            // 
            this.mnuBanh.Name = "mnuBanh";
            this.mnuBanh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.mnuBanh.Size = new System.Drawing.Size(141, 22);
            this.mnuBanh.Text = "Bánh";
            this.mnuBanh.Click += new System.EventHandler(this.mnuBanh_Click);
            // 
            // mnuNghiepVu
            // 
            this.mnuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBanBanh,
            this.mnuMoCSV,
            this.mnuLuuCSV});
            this.mnuNghiepVu.Name = "mnuNghiepVu";
            this.mnuNghiepVu.Size = new System.Drawing.Size(74, 20);
            this.mnuNghiepVu.Text = "Nghiệp vụ";
            // 
            // mnuBanBanh
            // 
            this.mnuBanBanh.Name = "mnuBanBanh";
            this.mnuBanBanh.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.mnuBanBanh.Size = new System.Drawing.Size(164, 22);
            this.mnuBanBanh.Text = "Bán bánh";
            this.mnuBanBanh.Click += new System.EventHandler(this.mnuBanBanh_Click);
            // 
            // mnuMoCSV
            // 
            this.mnuMoCSV.Name = "mnuMoCSV";
            this.mnuMoCSV.Size = new System.Drawing.Size(164, 22);
            this.mnuMoCSV.Text = "Mở CSV";
            this.mnuMoCSV.Click += new System.EventHandler(this.mnuMoCSV_Click);
            // 
            // mnuLuuCSV
            // 
            this.mnuLuuCSV.Name = "mnuLuuCSV";
            this.mnuLuuCSV.Size = new System.Drawing.Size(164, 22);
            this.mnuLuuCSV.Text = "Lưu CSV";
            this.mnuLuuCSV.Click += new System.EventHandler(this.mnuLuuCSV_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoanhThu});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.mnuBaoCao.Text = "Báo cáo";
            // 
            // mnuDoanhThu
            // 
            this.mnuDoanhThu.Name = "mnuDoanhThu";
            this.mnuDoanhThu.Size = new System.Drawing.Size(130, 22);
            this.mnuDoanhThu.Text = "Doanh thu";
            this.mnuDoanhThu.Click += new System.EventHandler(this.mnuDoanhThu_Click);
            // 
            // mnuCuaSo
            // 
            this.mnuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCascade,
            this.mnuTileH,
            this.mnuTileV});
            this.mnuCuaSo.Name = "mnuCuaSo";
            this.mnuCuaSo.Size = new System.Drawing.Size(55, 20);
            this.mnuCuaSo.Text = "Cửa sổ";
            // 
            // mnuCascade
            // 
            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Size = new System.Drawing.Size(150, 22);
            this.mnuCascade.Text = "Cascade";
            this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click);
            // 
            // mnuTileH
            // 
            this.mnuTileH.Name = "mnuTileH";
            this.mnuTileH.Size = new System.Drawing.Size(150, 22);
            this.mnuTileH.Text = "Tile Horizontal";
            this.mnuTileH.Click += new System.EventHandler(this.mnuTileH_Click);
            // 
            // mnuTileV
            // 
            this.mnuTileV.Name = "mnuTileV";
            this.mnuTileV.Size = new System.Drawing.Size(150, 22);
            this.mnuTileV.Text = "Tile Vertical";
            this.mnuTileV.Click += new System.EventHandler(this.mnuTileV_Click);
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGioiThieu});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(62, 20);
            this.mnuTroGiup.Text = "Trợ giúp";
            // 
            // mnuGioiThieu
            // 
            this.mnuGioiThieu.Name = "mnuGioiThieu";
            this.mnuGioiThieu.Size = new System.Drawing.Size(125, 22);
            this.mnuGioiThieu.Text = "Giới thiệu";
            this.mnuGioiThieu.Click += new System.EventHandler(this.mnuGioiThieu_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBanh,
            this.toolStripSeparator1,
            this.tsbBanBanh,
            this.toolStripSeparator3,
            this.tsbMoCSV,
            this.tsbLuuCSV,
            this.toolStripSeparator2,
            this.tsbDoanhThu});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbBanh
            // 
            this.tsbBanh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBanh.Image = ((System.Drawing.Image)(resources.GetObject("tsbBanh.Image")));
            this.tsbBanh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBanh.Name = "tsbBanh";
            this.tsbBanh.Size = new System.Drawing.Size(38, 22);
            this.tsbBanh.Text = "Bánh";
            this.tsbBanh.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbBanBanh
            // 
            this.tsbBanBanh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbBanBanh.Image = ((System.Drawing.Image)(resources.GetObject("tsbBanBanh.Image")));
            this.tsbBanBanh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBanBanh.Name = "tsbBanBanh";
            this.tsbBanBanh.Size = new System.Drawing.Size(61, 22);
            this.tsbBanBanh.Text = "Bán bánh";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbMoCSV
            // 
            this.tsbMoCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbMoCSV.Image = ((System.Drawing.Image)(resources.GetObject("tsbMoCSV.Image")));
            this.tsbMoCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMoCSV.Name = "tsbMoCSV";
            this.tsbMoCSV.Size = new System.Drawing.Size(53, 22);
            this.tsbMoCSV.Text = "Mở CSV";
            // 
            // tsbLuuCSV
            // 
            this.tsbLuuCSV.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLuuCSV.Image = ((System.Drawing.Image)(resources.GetObject("tsbLuuCSV.Image")));
            this.tsbLuuCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLuuCSV.Name = "tsbLuuCSV";
            this.tsbLuuCSV.Size = new System.Drawing.Size(55, 22);
            this.tsbLuuCSV.Text = "Lưu CSV";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbDoanhThu
            // 
            this.tsbDoanhThu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("tsbDoanhThu.Image")));
            this.tsbDoanhThu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDoanhThu.Name = "tsbDoanhThu";
            this.tsbDoanhThu.Size = new System.Drawing.Size(69, 22);
            this.tsbDoanhThu.Text = "Doanh Thu";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslNguoiDung,
            this.tslForm,
            this.tslSapHet,
            this.tslDongHo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslNguoiDung
            // 
            this.tslNguoiDung.Name = "tslNguoiDung";
            this.tslNguoiDung.Size = new System.Drawing.Size(80, 17);
            this.tslNguoiDung.Text = "Người dùng : ";
            // 
            // tslForm
            // 
            this.tslForm.Name = "tslForm";
            this.tslForm.Size = new System.Drawing.Size(284, 17);
            this.tslForm.Spring = true;
            this.tslForm.Text = "Form : ";
            // 
            // tslSapHet
            // 
            this.tslSapHet.Name = "tslSapHet";
            this.tslSapHet.Size = new System.Drawing.Size(284, 17);
            this.tslSapHet.Spring = true;
            this.tslSapHet.Text = "Sắp hết hàng : ";
            // 
            // tslDongHo
            // 
            this.tslDongHo.Name = "tslDongHo";
            this.tslDongHo.Size = new System.Drawing.Size(136, 17);
            this.tslDongHo.Text = "dd/MM/yyyy HH:mm:ss";
            this.tslDongHo.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm Quản lý Tiệm bánh Le Gâteau";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuBanh;
        private System.Windows.Forms.ToolStripMenuItem mnuBanBanh;
        private System.Windows.Forms.ToolStripMenuItem mnuMoCSV;
        private System.Windows.Forms.ToolStripMenuItem mnuLuuCSV;
        private System.Windows.Forms.ToolStripStatusLabel tslNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel tslForm;
        private System.Windows.Forms.ToolStripStatusLabel tslSapHet;
        private System.Windows.Forms.ToolStripStatusLabel tslDongHo;
        private System.Windows.Forms.ToolStripMenuItem mnuDoanhThu;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileH;
        private System.Windows.Forms.ToolStripMenuItem mnuTileV;
        private System.Windows.Forms.ToolStripMenuItem mnuGioiThieu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbBanh;
        private System.Windows.Forms.ToolStripButton tsbBanBanh;
        private System.Windows.Forms.ToolStripButton tsbMoCSV;
        private System.Windows.Forms.ToolStripButton tsbLuuCSV;
        private System.Windows.Forms.ToolStripButton tsbDoanhThu;
    }
}