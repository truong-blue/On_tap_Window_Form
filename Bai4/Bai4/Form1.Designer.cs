
namespace Bai4
{
    partial class Form1
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
            this.flpSoDo = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboKhungGio = new System.Windows.Forms.ComboBox();
            this.lblSoLuongChon = new System.Windows.Forms.Label();
            this.lblTamTinhTien = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuyChon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSoDo
            // 
            this.flpSoDo.AutoScroll = true;
            this.flpSoDo.Location = new System.Drawing.Point(12, 21);
            this.flpSoDo.Name = "flpSoDo";
            this.flpSoDo.Size = new System.Drawing.Size(460, 360);
            this.flpSoDo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnHuyChon);
            this.groupBox1.Controls.Add(this.btnXacNhan);
            this.groupBox1.Controls.Add(this.lblTamTinhTien);
            this.groupBox1.Controls.Add(this.lblSoLuongChon);
            this.groupBox1.Controls.Add(this.cboKhungGio);
            this.groupBox1.Location = new System.Drawing.Point(478, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đặt chỗ";
            // 
            // cboKhungGio
            // 
            this.cboKhungGio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhungGio.FormattingEnabled = true;
            this.cboKhungGio.Location = new System.Drawing.Point(107, 30);
            this.cboKhungGio.Name = "cboKhungGio";
            this.cboKhungGio.Size = new System.Drawing.Size(148, 21);
            this.cboKhungGio.TabIndex = 0;
            // 
            // lblSoLuongChon
            // 
            this.lblSoLuongChon.AutoSize = true;
            this.lblSoLuongChon.Location = new System.Drawing.Point(6, 67);
            this.lblSoLuongChon.Name = "lblSoLuongChon";
            this.lblSoLuongChon.Size = new System.Drawing.Size(96, 13);
            this.lblSoLuongChon.TabIndex = 1;
            this.lblSoLuongChon.Text = "Số chỗ đang chọn";
            // 
            // lblTamTinhTien
            // 
            this.lblTamTinhTien.AutoSize = true;
            this.lblTamTinhTien.Location = new System.Drawing.Point(6, 100);
            this.lblTamTinhTien.Name = "lblTamTinhTien";
            this.lblTamTinhTien.Size = new System.Drawing.Size(70, 13);
            this.lblTamTinhTien.TabIndex = 2;
            this.lblTamTinhTien.Text = "Tạm tính tiền";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(9, 136);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(113, 23);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận đặt";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuyChon
            // 
            this.btnHuyChon.Location = new System.Drawing.Point(142, 136);
            this.btnHuyChon.Name = "btnHuyChon";
            this.btnHuyChon.Size = new System.Drawing.Size(113, 23);
            this.btnHuyChon.TabIndex = 4;
            this.btnHuyChon.Text = "Hủy chọn tất cả";
            this.btnHuyChon.UseVisualStyleBackColor = true;
            this.btnHuyChon.Click += new System.EventHandler(this.btnHuyChon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chọn khung giờ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flpSoDo);
            this.Name = "Form1";
            this.Text = "Sơ đồ chọn vị trí chỗ ngồi / Đặt bàn hẹn giờ (Interactive Slot Booking)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSoDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyChon;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Label lblTamTinhTien;
        private System.Windows.Forms.Label lblSoLuongChon;
        private System.Windows.Forms.ComboBox cboKhungGio;
    }
}

