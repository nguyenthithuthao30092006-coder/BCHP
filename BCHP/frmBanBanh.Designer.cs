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
            this.SuspendLayout();
            // 
            // grpChonBanh
            // 
            this.grpChonBanh.Location = new System.Drawing.Point(22, 12);
            this.grpChonBanh.Name = "grpChonBanh";
            this.grpChonBanh.Size = new System.Drawing.Size(461, 239);
            this.grpChonBanh.TabIndex = 0;
            this.grpChonBanh.TabStop = false;
            this.grpChonBanh.Text = "Chọn bánh";
            // 
            // frmBanBanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 619);
            this.Controls.Add(this.grpChonBanh);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBanBanh";
            this.Text = "Bán bánh - Lập hóa đơn";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpChonBanh;
    }
}

