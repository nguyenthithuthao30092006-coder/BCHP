namespace BCHP.Forms
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            this.pnlTrai = new System.Windows.Forms.Panel();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.pnlPhai = new System.Windows.Forms.Panel();
            this.lblGoiY = new System.Windows.Forms.Label();
            this.lnkDangKy = new System.Windows.Forms.LinkLabel();
            this.lblChua = new System.Windows.Forms.Label();
            this.lblDem = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.chkHien = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblThuongHieu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lnkQuen = new System.Windows.Forms.LinkLabel();
            this.pnlTrai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).BeginInit();
            this.pnlPhai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTrai
            // 
            this.pnlTrai.Controls.Add(this.picBanner);
            this.pnlTrai.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTrai.Location = new System.Drawing.Point(0, 0);
            this.pnlTrai.Name = "pnlTrai";
            this.pnlTrai.Size = new System.Drawing.Size(390, 438);
            this.pnlTrai.TabIndex = 0;
            // 
            // picBanner
            // 
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(390, 438);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            // 
            // pnlPhai
            // 
            this.pnlPhai.Controls.Add(this.lnkQuen);
            this.pnlPhai.Controls.Add(this.lblGoiY);
            this.pnlPhai.Controls.Add(this.lnkDangKy);
            this.pnlPhai.Controls.Add(this.lblChua);
            this.pnlPhai.Controls.Add(this.lblDem);
            this.pnlPhai.Controls.Add(this.btnThoat);
            this.pnlPhai.Controls.Add(this.btnDangNhap);
            this.pnlPhai.Controls.Add(this.chkHien);
            this.pnlPhai.Controls.Add(this.txtPassword);
            this.pnlPhai.Controls.Add(this.lblPass);
            this.pnlPhai.Controls.Add(this.txtUsername);
            this.pnlPhai.Controls.Add(this.lblUser);
            this.pnlPhai.Controls.Add(this.lblSlogan);
            this.pnlPhai.Controls.Add(this.lblThuongHieu);
            this.pnlPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhai.Location = new System.Drawing.Point(390, 0);
            this.pnlPhai.Name = "pnlPhai";
            this.pnlPhai.Size = new System.Drawing.Size(383, 438);
            this.pnlPhai.TabIndex = 0;
            this.pnlPhai.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPhai_Paint);
            // 
            // lblGoiY
            // 
            this.lblGoiY.AutoSize = true;
            this.lblGoiY.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoiY.Location = new System.Drawing.Point(34, 409);
            this.lblGoiY.Name = "lblGoiY";
            this.lblGoiY.Size = new System.Drawing.Size(254, 15);
            this.lblGoiY.TabIndex = 0;
            this.lblGoiY.Text = "Tài khoản thử : ly hoặc thao (mật khẩu 123456)";
            // 
            // lnkDangKy
            // 
            this.lnkDangKy.AutoSize = true;
            this.lnkDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkDangKy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkDangKy.Location = new System.Drawing.Point(151, 380);
            this.lnkDangKy.Name = "lnkDangKy";
            this.lnkDangKy.Size = new System.Drawing.Size(79, 15);
            this.lnkDangKy.TabIndex = 6;
            this.lnkDangKy.TabStop = true;
            this.lnkDangKy.Text = "Đăng ký ngay";
            this.lnkDangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkDangKy_LinkClicked);
            // 
            // lblChua
            // 
            this.lblChua.AutoSize = true;
            this.lblChua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChua.Location = new System.Drawing.Point(34, 380);
            this.lblChua.Name = "lblChua";
            this.lblChua.Size = new System.Drawing.Size(111, 15);
            this.lblChua.TabIndex = 0;
            this.lblChua.Text = "Chưa có tài khoản ?";
            // 
            // lblDem
            // 
            this.lblDem.AutoSize = true;
            this.lblDem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDem.ForeColor = System.Drawing.Color.Red;
            this.lblDem.Location = new System.Drawing.Point(34, 354);
            this.lblDem.Name = "lblDem";
            this.lblDem.Size = new System.Drawing.Size(0, 17);
            this.lblDem.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(200)))));
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.btnThoat.Location = new System.Drawing.Point(34, 301);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(320, 40);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(100)))));
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatAppearance.BorderSize = 0;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Location = new System.Drawing.Point(34, 246);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(320, 40);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "ĐĂNG NHẬP";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // chkHien
            // 
            this.chkHien.AutoSize = true;
            this.chkHien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHien.Location = new System.Drawing.Point(34, 223);
            this.chkHien.Name = "chkHien";
            this.chkHien.Size = new System.Drawing.Size(95, 17);
            this.chkHien.TabIndex = 3;
            this.chkHien.Text = "Hiện mật khẩu";
            this.chkHien.UseVisualStyleBackColor = true;
            this.chkHien.Click += new System.EventHandler(this.chkHien_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(34, 197);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(320, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblPass.Location = new System.Drawing.Point(34, 170);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(70, 15);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "MẬT KHẨU";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(34, 132);
            this.txtUsername.MaxLength = 30;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblUser.Location = new System.Drawing.Point(34, 105);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(103, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "TÊN ĐĂNG NHẬP";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(122)))), ((int)(((byte)(144)))));
            this.lblSlogan.Location = new System.Drawing.Point(34, 68);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(316, 17);
            this.lblSlogan.TabIndex = 0;
            this.lblSlogan.Text = "Chào mừng trở lại ! Đăng nhập để quản lý cửa hàng.";
            // 
            // lblThuongHieu
            // 
            this.lblThuongHieu.AutoSize = true;
            this.lblThuongHieu.Font = new System.Drawing.Font("Georgia", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThuongHieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblThuongHieu.Location = new System.Drawing.Point(34, 18);
            this.lblThuongHieu.Name = "lblThuongHieu";
            this.lblThuongHieu.Size = new System.Drawing.Size(192, 38);
            this.lblThuongHieu.TabIndex = 0;
            this.lblThuongHieu.Text = "Le Gâteau";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lnkQuen
            // 
            this.lnkQuen.AutoSize = true;
            this.lnkQuen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkQuen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lnkQuen.Location = new System.Drawing.Point(253, 223);
            this.lnkQuen.Name = "lnkQuen";
            this.lnkQuen.Size = new System.Drawing.Size(97, 15);
            this.lnkQuen.TabIndex = 7;
            this.lnkQuen.TabStop = true;
            this.lnkQuen.Text = "Quên mật khẩu ?";
            this.lnkQuen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkQuen_LinkClicked);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(773, 438);
            this.Controls.Add(this.pnlPhai);
            this.Controls.Add(this.pnlTrai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập - Le Gâteau";
            this.pnlTrai.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBanner)).EndInit();
            this.pnlPhai.ResumeLayout(false);
            this.pnlPhai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTrai;
        private System.Windows.Forms.PictureBox picBanner;
        private System.Windows.Forms.Panel pnlPhai;
        private System.Windows.Forms.Label lblThuongHieu;
        private System.Windows.Forms.LinkLabel lnkDangKy;
        private System.Windows.Forms.Label lblChua;
        private System.Windows.Forms.Label lblDem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox chkHien;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblGoiY;
        private System.Windows.Forms.LinkLabel lnkQuen;
    }
}