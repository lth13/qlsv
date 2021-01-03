
namespace QuanLySinhVien
{
    partial class Form4
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.grbThongTin = new System.Windows.Forms.GroupBox();
            this.txbQuanLy = new System.Windows.Forms.TextBox();
            this.lblQuanLy = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.grbCongViec = new System.Windows.Forms.GroupBox();
            this.grbThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(267, 31);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(266, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ PHÒNG BAN";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Phòng kế toán",
            "Phòng sale",
            "Phòng kỹ thuật"});
            this.comboBox1.Location = new System.Drawing.Point(350, 90);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(181, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhongBan.Location = new System.Drawing.Point(239, 94);
            this.lblPhongBan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(98, 20);
            this.lblPhongBan.TabIndex = 2;
            this.lblPhongBan.Text = "Phòng ban : ";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.txbQuanLy);
            this.grbThongTin.Controls.Add(this.lblQuanLy);
            this.grbThongTin.Controls.Add(this.txbID);
            this.grbThongTin.Controls.Add(this.lblID);
            this.grbThongTin.Location = new System.Drawing.Point(140, 150);
            this.grbThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongTin.Size = new System.Drawing.Size(494, 87);
            this.grbThongTin.TabIndex = 3;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Thông tin phòng ban";
            // 
            // txbQuanLy
            // 
            this.txbQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuanLy.Location = new System.Drawing.Point(329, 36);
            this.txbQuanLy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbQuanLy.Name = "txbQuanLy";
            this.txbQuanLy.Size = new System.Drawing.Size(132, 26);
            this.txbQuanLy.TabIndex = 3;
            // 
            // lblQuanLy
            // 
            this.lblQuanLy.AutoSize = true;
            this.lblQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLy.Location = new System.Drawing.Point(206, 38);
            this.lblQuanLy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuanLy.Name = "lblQuanLy";
            this.lblQuanLy.Size = new System.Drawing.Size(116, 20);
            this.lblQuanLy.TabIndex = 2;
            this.lblQuanLy.Text = "Người quản lý : ";
            this.lblQuanLy.Click += new System.EventHandler(this.label1_Click);
            // 
            // txbID
            // 
            this.txbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbID.Location = new System.Drawing.Point(58, 33);
            this.txbID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(126, 26);
            this.txbID.TabIndex = 1;
            this.txbID.TextChanged += new System.EventHandler(this.txbID_TextChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(19, 38);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(38, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID : ";
            // 
            // grbCongViec
            // 
            this.grbCongViec.Location = new System.Drawing.Point(140, 270);
            this.grbCongViec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCongViec.Name = "grbCongViec";
            this.grbCongViec.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCongViec.Size = new System.Drawing.Size(494, 283);
            this.grbCongViec.TabIndex = 4;
            this.grbCongViec.TabStop = false;
            this.grbCongViec.Text = "Thông tin công việc";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 609);
            this.Controls.Add(this.grbCongViec);
            this.Controls.Add(this.grbThongTin);
            this.Controls.Add(this.lblPhongBan);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form4";
            this.Text = "Quản lý phòng ban";
            this.grbThongTin.ResumeLayout(false);
            this.grbThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.GroupBox grbThongTin;
        private System.Windows.Forms.TextBox txbQuanLy;
        private System.Windows.Forms.Label lblQuanLy;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox grbCongViec;
    }
}