namespace BCHP.Forms
{
    partial class frmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            this.pnlTrai = new System.Windows.Forms.Panel();
            this.picBanner = new System.Windows.Forms.PictureBox();
            this.pnlPhai = new System.Windows.Forms.Panel();
            this.chkHien = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.rdoNu = new System.Windows.Forms.RadioButton();
            this.rdoNam = new System.Windows.Forms.RadioButton();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtNhapLai = new System.Windows.Forms.TextBox();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.lblPhu = new System.Windows.Forms.Label();
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
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
            this.pnlTrai.Size = new System.Drawing.Size(393, 511);
            this.pnlTrai.TabIndex = 0;
            // 
            // picBanner
            // 
            this.picBanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBanner.Image = ((System.Drawing.Image)(resources.GetObject("picBanner.Image")));
            this.picBanner.Location = new System.Drawing.Point(0, 0);
            this.picBanner.Name = "picBanner";
            this.picBanner.Size = new System.Drawing.Size(393, 511);
            this.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBanner.TabIndex = 0;
            this.picBanner.TabStop = false;
            // 
            // pnlPhai
            // 
            this.pnlPhai.Controls.Add(this.chkHien);
            this.pnlPhai.Controls.Add(this.txtPassword);
            this.pnlPhai.Controls.Add(this.lblPass);
            this.pnlPhai.Controls.Add(this.txtUsername);
            this.pnlPhai.Controls.Add(this.lblUser);
            this.pnlPhai.Controls.Add(this.btnHuy);
            this.pnlPhai.Controls.Add(this.btnDangKy);
            this.pnlPhai.Controls.Add(this.txtEmail);
            this.pnlPhai.Controls.Add(this.lblEmail);
            this.pnlPhai.Controls.Add(this.rdoNu);
            this.pnlPhai.Controls.Add(this.rdoNam);
            this.pnlPhai.Controls.Add(this.lblGioiTinh);
            this.pnlPhai.Controls.Add(this.txtHoTen);
            this.pnlPhai.Controls.Add(this.lblHoTen);
            this.pnlPhai.Controls.Add(this.txtNhapLai);
            this.pnlPhai.Controls.Add(this.lblNhapLai);
            this.pnlPhai.Controls.Add(this.lblPhu);
            this.pnlPhai.Controls.Add(this.lblTieuDe);
            this.pnlPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhai.Location = new System.Drawing.Point(393, 0);
            this.pnlPhai.Name = "pnlPhai";
            this.pnlPhai.Size = new System.Drawing.Size(384, 511);
            this.pnlPhai.TabIndex = 0;
            // 
            // chkHien
            // 
            this.chkHien.AutoSize = true;
            this.chkHien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHien.Location = new System.Drawing.Point(265, 222);
            this.chkHien.Name = "chkHien";
            this.chkHien.Size = new System.Drawing.Size(95, 17);
            this.chkHien.TabIndex = 0;
            this.chkHien.Text = "Hiện mật khẩu";
            this.chkHien.UseVisualStyleBackColor = true;
            this.chkHien.Click += new System.EventHandler(this.chkHien_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(34, 186);
            this.txtPassword.MaxLength = 64;
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
            this.lblPass.Location = new System.Drawing.Point(34, 159);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(70, 15);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "MẬT KHẨU";
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Location = new System.Drawing.Point(34, 126);
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
            this.lblUser.Location = new System.Drawing.Point(34, 99);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(103, 15);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "TÊN ĐĂNG NHẬP";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(200)))));
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(100)))));
            this.btnHuy.Location = new System.Drawing.Point(204, 445);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(150, 56);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "HỦY";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(136)))), ((int)(((byte)(100)))));
            this.btnDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDangKy.ForeColor = System.Drawing.Color.White;
            this.btnDangKy.Location = new System.Drawing.Point(34, 445);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(153, 56);
            this.btnDangKy.TabIndex = 6;
            this.btnDangKy.Text = "ĐĂNG KÝ";
            this.btnDangKy.UseVisualStyleBackColor = false;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(34, 410);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblEmail.Location = new System.Drawing.Point(34, 383);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 15);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "EMAIL";
            // 
            // rdoNu
            // 
            this.rdoNu.AutoSize = true;
            this.rdoNu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoNu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNu.Location = new System.Drawing.Point(269, 347);
            this.rdoNu.Name = "rdoNu";
            this.rdoNu.Size = new System.Drawing.Size(41, 19);
            this.rdoNu.TabIndex = 0;
            this.rdoNu.Text = "Nữ";
            this.rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            this.rdoNam.AutoSize = true;
            this.rdoNam.Checked = true;
            this.rdoNam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdoNam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNam.Location = new System.Drawing.Point(159, 347);
            this.rdoNam.Name = "rdoNam";
            this.rdoNam.Size = new System.Drawing.Size(51, 19);
            this.rdoNam.TabIndex = 0;
            this.rdoNam.TabStop = true;
            this.rdoNam.Text = "Nam";
            this.rdoNam.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblGioiTinh.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblGioiTinh.Location = new System.Drawing.Point(34, 347);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(65, 15);
            this.lblGioiTinh.TabIndex = 0;
            this.lblGioiTinh.Text = "GIỚI TÍNH";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Location = new System.Drawing.Point(34, 308);
            this.txtHoTen.MaxLength = 50;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(320, 20);
            this.txtHoTen.TabIndex = 4;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblHoTen.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHoTen.Location = new System.Drawing.Point(34, 281);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(68, 15);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "HỌ VÀ TÊN";
            // 
            // txtNhapLai
            // 
            this.txtNhapLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhapLai.Location = new System.Drawing.Point(34, 245);
            this.txtNhapLai.MaxLength = 64;
            this.txtNhapLai.Name = "txtNhapLai";
            this.txtNhapLai.PasswordChar = '*';
            this.txtNhapLai.Size = new System.Drawing.Size(320, 20);
            this.txtNhapLai.TabIndex = 3;
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNhapLai.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblNhapLai.Location = new System.Drawing.Point(34, 222);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(127, 15);
            this.lblNhapLai.TabIndex = 0;
            this.lblNhapLai.Text = "NHẬP LẠI MẬT KHẨU";
            // 
            // lblPhu
            // 
            this.lblPhu.AutoSize = true;
            this.lblPhu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(122)))), ((int)(((byte)(144)))));
            this.lblPhu.Location = new System.Drawing.Point(34, 62);
            this.lblPhu.Name = "lblPhu";
            this.lblPhu.Size = new System.Drawing.Size(276, 15);
            this.lblPhu.TabIndex = 0;
            this.lblPhu.Text = "Điền thông tin để đăng ký tài khoản vào Le Gâteau.";
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Georgia", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblTieuDe.Location = new System.Drawing.Point(34, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(220, 34);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Tạo tài khoản";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(777, 511);
            this.Controls.Add(this.pnlPhai);
            this.Controls.Add(this.pnlTrai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Ký - Le Gâteau";
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
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.RadioButton rdoNu;
        private System.Windows.Forms.RadioButton rdoNam;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtNhapLai;
        private System.Windows.Forms.Label lblNhapLai;
        private System.Windows.Forms.Label lblPhu;
        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkHien;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}