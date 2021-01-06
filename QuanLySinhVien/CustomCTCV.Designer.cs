
namespace QuanLySinhVien
{
    partial class CustomCTCV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltencv = new System.Windows.Forms.Label();
            this.lblndcv = new System.Windows.Forms.Label();
            this.lbltgtao = new System.Windows.Forms.Label();
            this.lblngtao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltcv = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltencv
            // 
            this.lbltencv.AutoSize = true;
            this.lbltencv.Location = new System.Drawing.Point(87, 15);
            this.lbltencv.Name = "lbltencv";
            this.lbltencv.Size = new System.Drawing.Size(59, 13);
            this.lbltencv.TabIndex = 0;
            this.lbltencv.Text = "Phòng ban";
            // 
            // lblndcv
            // 
            this.lblndcv.AutoSize = true;
            this.lblndcv.Location = new System.Drawing.Point(19, 134);
            this.lblndcv.Name = "lblndcv";
            this.lblndcv.Size = new System.Drawing.Size(100, 13);
            this.lblndcv.TabIndex = 2;
            this.lblndcv.Text = "Nội dung công việc";
            // 
            // lbltgtao
            // 
            this.lbltgtao.AutoSize = true;
            this.lbltgtao.Location = new System.Drawing.Point(119, 208);
            this.lbltgtao.Name = "lbltgtao";
            this.lbltgtao.Size = new System.Drawing.Size(69, 13);
            this.lbltgtao.TabIndex = 4;
            this.lbltgtao.Text = "Thời gian tạo";
            // 
            // lblngtao
            // 
            this.lblngtao.AutoSize = true;
            this.lblngtao.Location = new System.Drawing.Point(119, 265);
            this.lblngtao.Name = "lblngtao";
            this.lblngtao.Size = new System.Drawing.Size(59, 13);
            this.lblngtao.TabIndex = 5;
            this.lblngtao.Text = "Trạng Thái";
            this.lblngtao.Click += new System.EventHandler(this.lblngtao_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbltcv);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblngtao);
            this.panel1.Controls.Add(this.lbltgtao);
            this.panel1.Controls.Add(this.lblndcv);
            this.panel1.Controls.Add(this.lbltencv);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 362);
            this.panel1.TabIndex = 6;
            // 
            // lbltcv
            // 
            this.lbltcv.AutoSize = true;
            this.lbltcv.Location = new System.Drawing.Point(104, 51);
            this.lbltcv.Name = "lbltcv";
            this.lbltcv.Size = new System.Drawing.Size(78, 13);
            this.lbltcv.TabIndex = 11;
            this.lbltcv.Text = "Tên Công Việc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên công việc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thời gian kết thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nội dung công việc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phòng ban:";
            // 
            // CustomCTCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "CustomCTCV";
            this.Size = new System.Drawing.Size(253, 367);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbltencv;
        private System.Windows.Forms.Label lblndcv;
        private System.Windows.Forms.Label lbltgtao;
        private System.Windows.Forms.Label lblngtao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbltcv;
        private System.Windows.Forms.Label label5;
    }
}
