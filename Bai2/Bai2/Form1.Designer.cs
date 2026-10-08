
namespace Bai2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.txtNguoiYeuCau = new System.Windows.Forms.TextBox();
            this.dtpNgayGhiNhan = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboLoaiSuCo = new System.Windows.Forms.ComboBox();
            this.chkMayTinhBan = new System.Windows.Forms.CheckBox();
            this.chkLaptop = new System.Windows.Forms.CheckBox();
            this.chkMayIn = new System.Windows.Forms.CheckBox();
            this.chkDienThoai = new System.Windows.Forms.CheckBox();
            this.picLoi = new System.Windows.Forms.PictureBox();
            this.btnTaiAnh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuiYeuCau = new System.Windows.Forms.Button();
            this.btnNhapLai = new System.Windows.Forms.Button();
            this.rdoThap = new System.Windows.Forms.RadioButton();
            this.rdoTrungBinh = new System.Windows.Forms.RadioButton();
            this.rdoKhanCap = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoi)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNgayGhiNhan);
            this.groupBox1.Controls.Add(this.txtNguoiYeuCau);
            this.groupBox1.Controls.Add(this.txtMaPhieu);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(110, 19);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.Size = new System.Drawing.Size(170, 20);
            this.txtMaPhieu.TabIndex = 0;
            // 
            // txtNguoiYeuCau
            // 
            this.txtNguoiYeuCau.Location = new System.Drawing.Point(110, 45);
            this.txtNguoiYeuCau.Name = "txtNguoiYeuCau";
            this.txtNguoiYeuCau.Size = new System.Drawing.Size(170, 20);
            this.txtNguoiYeuCau.TabIndex = 1;
            // 
            // dtpNgayGhiNhan
            // 
            this.dtpNgayGhiNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayGhiNhan.Location = new System.Drawing.Point(110, 71);
            this.dtpNgayGhiNhan.Name = "dtpNgayGhiNhan";
            this.dtpNgayGhiNhan.Size = new System.Drawing.Size(170, 20);
            this.dtpNgayGhiNhan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Người yêu cầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày ghi nhận";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnTaiAnh);
            this.groupBox2.Controls.Add(this.picLoi);
            this.groupBox2.Controls.Add(this.chkDienThoai);
            this.groupBox2.Controls.Add(this.chkMayIn);
            this.groupBox2.Controls.Add(this.chkLaptop);
            this.groupBox2.Controls.Add(this.chkMayTinhBan);
            this.groupBox2.Controls.Add(this.cboLoaiSuCo);
            this.groupBox2.Location = new System.Drawing.Point(369, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 188);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân loại && Chi tiết";
            // 
            // cboLoaiSuCo
            // 
            this.cboLoaiSuCo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiSuCo.FormattingEnabled = true;
            this.cboLoaiSuCo.Location = new System.Drawing.Point(68, 19);
            this.cboLoaiSuCo.Name = "cboLoaiSuCo";
            this.cboLoaiSuCo.Size = new System.Drawing.Size(230, 21);
            this.cboLoaiSuCo.TabIndex = 0;
            // 
            // chkMayTinhBan
            // 
            this.chkMayTinhBan.AutoSize = true;
            this.chkMayTinhBan.Location = new System.Drawing.Point(9, 51);
            this.chkMayTinhBan.Name = "chkMayTinhBan";
            this.chkMayTinhBan.Size = new System.Drawing.Size(89, 17);
            this.chkMayTinhBan.TabIndex = 1;
            this.chkMayTinhBan.Text = "Máy tính bàn";
            this.chkMayTinhBan.UseVisualStyleBackColor = true;
            // 
            // chkLaptop
            // 
            this.chkLaptop.AutoSize = true;
            this.chkLaptop.Location = new System.Drawing.Point(9, 78);
            this.chkLaptop.Name = "chkLaptop";
            this.chkLaptop.Size = new System.Drawing.Size(59, 17);
            this.chkLaptop.TabIndex = 2;
            this.chkLaptop.Text = "Laptop";
            this.chkLaptop.UseVisualStyleBackColor = true;
            // 
            // chkMayIn
            // 
            this.chkMayIn.AutoSize = true;
            this.chkMayIn.Location = new System.Drawing.Point(9, 101);
            this.chkMayIn.Name = "chkMayIn";
            this.chkMayIn.Size = new System.Drawing.Size(57, 17);
            this.chkMayIn.TabIndex = 3;
            this.chkMayIn.Text = "Máy in";
            this.chkMayIn.UseVisualStyleBackColor = true;
            // 
            // chkDienThoai
            // 
            this.chkDienThoai.AutoSize = true;
            this.chkDienThoai.Location = new System.Drawing.Point(9, 127);
            this.chkDienThoai.Name = "chkDienThoai";
            this.chkDienThoai.Size = new System.Drawing.Size(74, 17);
            this.chkDienThoai.TabIndex = 4;
            this.chkDienThoai.Text = "Điện thoại";
            this.chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // picLoi
            // 
            this.picLoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLoi.Location = new System.Drawing.Point(148, 52);
            this.picLoi.Name = "picLoi";
            this.picLoi.Size = new System.Drawing.Size(150, 100);
            this.picLoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLoi.TabIndex = 5;
            this.picLoi.TabStop = false;
            // 
            // btnTaiAnh
            // 
            this.btnTaiAnh.Location = new System.Drawing.Point(188, 158);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.Size = new System.Drawing.Size(75, 23);
            this.btnTaiAnh.TabIndex = 6;
            this.btnTaiAnh.Text = "Tải ảnh lỗi";
            this.btnTaiAnh.UseVisualStyleBackColor = true;
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Loại sự cố";
            // 
            // btnGuiYeuCau
            // 
            this.btnGuiYeuCau.Location = new System.Drawing.Point(248, 222);
            this.btnGuiYeuCau.Name = "btnGuiYeuCau";
            this.btnGuiYeuCau.Size = new System.Drawing.Size(75, 23);
            this.btnGuiYeuCau.TabIndex = 8;
            this.btnGuiYeuCau.Text = "Gửi yêu cầu";
            this.btnGuiYeuCau.UseVisualStyleBackColor = true;
            this.btnGuiYeuCau.Click += new System.EventHandler(this.btnGuiYeuCau_Click);
            // 
            // btnNhapLai
            // 
            this.btnNhapLai.Location = new System.Drawing.Point(369, 222);
            this.btnNhapLai.Name = "btnNhapLai";
            this.btnNhapLai.Size = new System.Drawing.Size(75, 23);
            this.btnNhapLai.TabIndex = 9;
            this.btnNhapLai.Text = "Nhập lại";
            this.btnNhapLai.UseVisualStyleBackColor = true;
            this.btnNhapLai.Click += new System.EventHandler(this.btnNhapLai_Click);
            // 
            // rdoThap
            // 
            this.rdoThap.AutoSize = true;
            this.rdoThap.Location = new System.Drawing.Point(6, 25);
            this.rdoThap.Name = "rdoThap";
            this.rdoThap.Size = new System.Drawing.Size(50, 17);
            this.rdoThap.TabIndex = 0;
            this.rdoThap.TabStop = true;
            this.rdoThap.Text = "Thấp";
            this.rdoThap.UseVisualStyleBackColor = true;
            this.rdoThap.CheckedChanged += new System.EventHandler(this.rdoThap_CheckedChanged);
            // 
            // rdoTrungBinh
            // 
            this.rdoTrungBinh.AutoSize = true;
            this.rdoTrungBinh.Location = new System.Drawing.Point(84, 25);
            this.rdoTrungBinh.Name = "rdoTrungBinh";
            this.rdoTrungBinh.Size = new System.Drawing.Size(76, 17);
            this.rdoTrungBinh.TabIndex = 1;
            this.rdoTrungBinh.TabStop = true;
            this.rdoTrungBinh.Text = "Trung bình";
            this.rdoTrungBinh.UseVisualStyleBackColor = true;
            // 
            // rdoKhanCap
            // 
            this.rdoKhanCap.AutoSize = true;
            this.rdoKhanCap.Location = new System.Drawing.Point(176, 26);
            this.rdoKhanCap.Name = "rdoKhanCap";
            this.rdoKhanCap.Size = new System.Drawing.Size(71, 17);
            this.rdoKhanCap.TabIndex = 2;
            this.rdoKhanCap.TabStop = true;
            this.rdoKhanCap.Text = "Khẩn cấp";
            this.rdoKhanCap.UseVisualStyleBackColor = true;
            this.rdoKhanCap.CheckedChanged += new System.EventHandler(this.rdoKhanCap_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoKhanCap);
            this.groupBox3.Controls.Add(this.rdoThap);
            this.groupBox3.Controls.Add(this.rdoTrungBinh);
            this.groupBox3.Location = new System.Drawing.Point(16, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 62);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mức độ ưu tiên";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNhapLai);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGuiYeuCau);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form Tiếp nhận & Phân loại sự cố IT (IT Support Ticket Form)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoi)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayGhiNhan;
        private System.Windows.Forms.TextBox txtNguoiYeuCau;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.RadioButton rdoKhanCap;
        private System.Windows.Forms.RadioButton rdoTrungBinh;
        private System.Windows.Forms.RadioButton rdoThap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTaiAnh;
        private System.Windows.Forms.PictureBox picLoi;
        private System.Windows.Forms.CheckBox chkDienThoai;
        private System.Windows.Forms.CheckBox chkMayIn;
        private System.Windows.Forms.CheckBox chkLaptop;
        private System.Windows.Forms.CheckBox chkMayTinhBan;
        private System.Windows.Forms.ComboBox cboLoaiSuCo;
        private System.Windows.Forms.Button btnGuiYeuCau;
        private System.Windows.Forms.Button btnNhapLai;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

