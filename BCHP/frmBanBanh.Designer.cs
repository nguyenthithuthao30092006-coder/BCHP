namespace BCHP
{
    partial class frmBanBanh
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
            this.grpChonBanh = new System.Windows.Forms.GroupBox();
            this.lblMaBanh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKichCo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaBanh = new System.Windows.Forms.TextBox();
            this.cboLoaiBanh = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cboKichCo = new System.Windows.Forms.ComboBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grpChonBanh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // grpChonBanh
            // 
            this.grpChonBanh.Controls.Add(this.checkBox1);
            this.grpChonBanh.Controls.Add(this.txtNoiDung);
            this.grpChonBanh.Controls.Add(this.cboKichCo);
            this.grpChonBanh.Controls.Add(this.nudSoLuong);
            this.grpChonBanh.Controls.Add(this.cboLoaiBanh);
            this.grpChonBanh.Controls.Add(this.txtMaBanh);
            this.grpChonBanh.Controls.Add(this.label5);
            this.grpChonBanh.Controls.Add(this.lblKichCo);
            this.grpChonBanh.Controls.Add(this.label3);
            this.grpChonBanh.Controls.Add(this.label2);
            this.grpChonBanh.Controls.Add(this.lblMaBanh);
            this.grpChonBanh.Location = new System.Drawing.Point(22, 12);
            this.grpChonBanh.Name = "grpChonBanh";
            this.grpChonBanh.Size = new System.Drawing.Size(549, 319);
            this.grpChonBanh.TabIndex = 0;
            this.grpChonBanh.TabStop = false;
            this.grpChonBanh.Text = "Chọn bánh";
            // 
            // lblMaBanh
            // 
            this.lblMaBanh.AutoSize = true;
            this.lblMaBanh.Location = new System.Drawing.Point(17, 40);
            this.lblMaBanh.Name = "lblMaBanh";
            this.lblMaBanh.Size = new System.Drawing.Size(94, 22);
            this.lblMaBanh.TabIndex = 0;
            this.lblMaBanh.Text = "Mã bánh : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại bánh : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng : ";
            // 
            // lblKichCo
            // 
            this.lblKichCo.AutoSize = true;
            this.lblKichCo.Location = new System.Drawing.Point(17, 181);
            this.lblKichCo.Name = "lblKichCo";
            this.lblKichCo.Size = new System.Drawing.Size(89, 22);
            this.lblKichCo.TabIndex = 3;
            this.lblKichCo.Text = "Kích cỡ : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 44);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nội dung ghi \r\ntrên bánh :\r\n";
            // 
            // txtMaBanh
            // 
            this.txtMaBanh.Location = new System.Drawing.Point(145, 30);
            this.txtMaBanh.Multiline = true;
            this.txtMaBanh.Name = "txtMaBanh";
            this.txtMaBanh.Size = new System.Drawing.Size(159, 32);
            this.txtMaBanh.TabIndex = 5;
            // 
            // cboLoaiBanh
            // 
            this.cboLoaiBanh.FormattingEnabled = true;
            this.cboLoaiBanh.Location = new System.Drawing.Point(145, 77);
            this.cboLoaiBanh.Name = "cboLoaiBanh";
            this.cboLoaiBanh.Size = new System.Drawing.Size(291, 30);
            this.cboLoaiBanh.TabIndex = 6;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(145, 125);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(159, 30);
            this.nudSoLuong.TabIndex = 7;
            // 
            // cboKichCo
            // 
            this.cboKichCo.FormattingEnabled = true;
            this.cboKichCo.Location = new System.Drawing.Point(145, 178);
            this.cboKichCo.Name = "cboKichCo";
            this.cboKichCo.Size = new System.Drawing.Size(159, 30);
            this.cboKichCo.TabIndex = 8;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(145, 229);
            this.txtNoiDung.Multiline = true;
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(353, 35);
            this.txtNoiDung.TabIndex = 9;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(43, 349);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(191, 49);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm vào hóa đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(145, 282);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(263, 26);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Bánh đặt trước - đã xác nhận ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // frmBanBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grpChonBanh);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBanBanh";
            this.Text = "Bán bánh - Lập hóa đơn";
            this.grpChonBanh.ResumeLayout(false);
            this.grpChonBanh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChonBanh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblKichCo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMaBanh;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ComboBox cboKichCo;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cboLoaiBanh;
        private System.Windows.Forms.TextBox txtMaBanh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

