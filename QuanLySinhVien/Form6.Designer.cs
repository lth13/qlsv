
namespace QuanLySinhVien
{
    partial class Form6
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
            this.lblTitlle = new System.Windows.Forms.Label();
            this.lblMKcu = new System.Windows.Forms.Label();
            this.lblMKmoi = new System.Windows.Forms.Label();
            this.lblNhapLai = new System.Windows.Forms.Label();
            this.tbxMKcu = new System.Windows.Forms.TextBox();
            this.tbxMKmoi = new System.Windows.Forms.TextBox();
            this.tbxNhapLai = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitlle
            // 
            this.lblTitlle.AutoSize = true;
            this.lblTitlle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlle.Location = new System.Drawing.Point(195, 38);
            this.lblTitlle.Name = "lblTitlle";
            this.lblTitlle.Size = new System.Drawing.Size(227, 32);
            this.lblTitlle.TabIndex = 0;
            this.lblTitlle.Text = "ĐỔI MẬT KHẨU";
            // 
            // lblMKcu
            // 
            this.lblMKcu.AutoSize = true;
            this.lblMKcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKcu.Location = new System.Drawing.Point(120, 106);
            this.lblMKcu.Name = "lblMKcu";
            this.lblMKcu.Size = new System.Drawing.Size(127, 24);
            this.lblMKcu.TabIndex = 1;
            this.lblMKcu.Text = "Mật khẩu cũ : ";
            // 
            // lblMKmoi
            // 
            this.lblMKmoi.AutoSize = true;
            this.lblMKmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMKmoi.Location = new System.Drawing.Point(110, 173);
            this.lblMKmoi.Name = "lblMKmoi";
            this.lblMKmoi.Size = new System.Drawing.Size(137, 24);
            this.lblMKmoi.TabIndex = 2;
            this.lblMKmoi.Text = "Mật khẩu mới : ";
            // 
            // lblNhapLai
            // 
            this.lblNhapLai.AutoSize = true;
            this.lblNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapLai.Location = new System.Drawing.Point(41, 228);
            this.lblNhapLai.Name = "lblNhapLai";
            this.lblNhapLai.Size = new System.Drawing.Size(206, 24);
            this.lblNhapLai.TabIndex = 3;
            this.lblNhapLai.Text = "Nhập lại mât khẩu mới: ";
            // 
            // tbxMKcu
            // 
            this.tbxMKcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMKcu.Location = new System.Drawing.Point(253, 106);
            this.tbxMKcu.Name = "tbxMKcu";
            this.tbxMKcu.PasswordChar = '*';
            this.tbxMKcu.Size = new System.Drawing.Size(208, 28);
            this.tbxMKcu.TabIndex = 4;
            // 
            // tbxMKmoi
            // 
            this.tbxMKmoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMKmoi.Location = new System.Drawing.Point(253, 170);
            this.tbxMKmoi.Name = "tbxMKmoi";
            this.tbxMKmoi.PasswordChar = '*';
            this.tbxMKmoi.Size = new System.Drawing.Size(208, 28);
            this.tbxMKmoi.TabIndex = 5;
            // 
            // tbxNhapLai
            // 
            this.tbxNhapLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNhapLai.Location = new System.Drawing.Point(253, 228);
            this.tbxNhapLai.Name = "tbxNhapLai";
            this.tbxNhapLai.PasswordChar = '*';
            this.tbxNhapLai.Size = new System.Drawing.Size(208, 28);
            this.tbxNhapLai.TabIndex = 6;
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(225, 306);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(129, 37);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Thay đổi";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 414);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.tbxNhapLai);
            this.Controls.Add(this.tbxMKmoi);
            this.Controls.Add(this.tbxMKcu);
            this.Controls.Add(this.lblNhapLai);
            this.Controls.Add(this.lblMKmoi);
            this.Controls.Add(this.lblMKcu);
            this.Controls.Add(this.lblTitlle);
            this.Name = "Form6";
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlle;
        private System.Windows.Forms.Label lblMKcu;
        private System.Windows.Forms.Label lblMKmoi;
        private System.Windows.Forms.Label lblNhapLai;
        private System.Windows.Forms.TextBox tbxMKcu;
        private System.Windows.Forms.TextBox tbxMKmoi;
        private System.Windows.Forms.TextBox tbxNhapLai;
        private System.Windows.Forms.Button btnLuu;
    }
}