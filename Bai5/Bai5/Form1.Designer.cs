
namespace Bai5
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cboLoaiVanChuyen = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatusThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusSoLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTrongLuong = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatusTongTien = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.timerDongHo = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.dgvHangHoa);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 325;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(325, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cboLoaiVanChuyen);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtDiaChi);
            this.tabPage1.Controls.Add(this.txtDienThoai);
            this.tabPage1.Controls.Add(this.txtTenKhach);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(317, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin khách hàng && Vận chuyển";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phương thức vận chuyển";
            // 
            // cboLoaiVanChuyen
            // 
            this.cboLoaiVanChuyen.FormattingEnabled = true;
            this.cboLoaiVanChuyen.Location = new System.Drawing.Point(141, 84);
            this.cboLoaiVanChuyen.Name = "cboLoaiVanChuyen";
            this.cboLoaiVanChuyen.Size = new System.Drawing.Size(170, 21);
            this.cboLoaiVanChuyen.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Địa chỉ giao hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên khách hàng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(141, 58);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(170, 20);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(141, 32);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(170, 20);
            this.txtDienThoai.TabIndex = 1;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(141, 6);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(170, 20);
            this.txtTenKhach.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatusThoiGian,
            this.lblStatusSoLuong,
            this.lblStatusTrongLuong,
            this.lblStatusTongTien});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(471, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblStatusThoiGian
            // 
            this.lblStatusThoiGian.Name = "lblStatusThoiGian";
            this.lblStatusThoiGian.Size = new System.Drawing.Size(56, 17);
            this.lblStatusThoiGian.Text = "Thời gian";
            this.lblStatusThoiGian.Click += new System.EventHandler(this.lblStatusThoiGian_Click);
            // 
            // lblStatusSoLuong
            // 
            this.lblStatusSoLuong.Name = "lblStatusSoLuong";
            this.lblStatusSoLuong.Size = new System.Drawing.Size(54, 17);
            this.lblStatusSoLuong.Text = "Số lượng";
            this.lblStatusSoLuong.Click += new System.EventHandler(this.lblStatusSoLuong_Click);
            // 
            // lblStatusTrongLuong
            // 
            this.lblStatusTrongLuong.Name = "lblStatusTrongLuong";
            this.lblStatusTrongLuong.Size = new System.Drawing.Size(71, 17);
            this.lblStatusTrongLuong.Text = "Trọng lượng";
            this.lblStatusTrongLuong.Click += new System.EventHandler(this.lblStatusTrongLuong_Click);
            // 
            // lblStatusTongTien
            // 
            this.lblStatusTongTien.Name = "lblStatusTongTien";
            this.lblStatusTongTien.Size = new System.Drawing.Size(57, 17);
            this.lblStatusTongTien.Text = "Tổng tiền";
            this.lblStatusTongTien.Click += new System.EventHandler(this.lblStatusTongTien_Click);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AllowUserToAddRows = false;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangHoa.Location = new System.Drawing.Point(0, 0);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.Size = new System.Drawing.Size(471, 450);
            this.dgvHangHoa.TabIndex = 0;
            // 
            // timerDongHo
            // 
            this.timerDongHo.Enabled = true;
            this.timerDongHo.Interval = 1000;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Bảng điều khiển Quản lý Đơn giao hàng (Delivery Order Dashboard)";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboLoaiVanChuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusThoiGian;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusSoLuong;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTrongLuong;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusTongTien;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Timer timerDongHo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

