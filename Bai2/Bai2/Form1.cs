using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bai2
{
    public partial class Form1 : Form
    {
        private string duongDanAnh = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboLoaiSuCo.Items.Clear();
            cboLoaiSuCo.Items.AddRange(new string[] { "Phần cứng", "Phần mềm", "Mạng", "Tài khoản" });
            cboLoaiSuCo.SelectedIndex = 0;

            rdoTrungBinh.Checked = true;
        }

        private void rdoThap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoKhanCap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh chụp sự cố";
                ofd.Filter = "Tệp hình ảnh (*.jpg;*.png)|*.jpg;*.png";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    duongDanAnh = ofd.FileName;
                    picLoi.SizeMode = PictureBoxSizeMode.StretchImage; // Đúng yêu cầu đề bài
                    picLoi.Image = Image.FromFile(duongDanAnh);
                }
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin bắt buộc
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaPhieu.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập Người yêu cầu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNguoiYeuCau.Focus();
                return;
            }

            // 1. Xác định mức độ ưu tiên
            string mucDoUuTien = "Trung bình";
            if (rdoThap.Checked) mucDoUuTien = "Thấp";
            else if (rdoTrungBinh.Checked) mucDoUuTien = "Trung bình";
            else if (rdoKhanCap.Checked) mucDoUuTien = "Khẩn cấp";

            // 2. Gom danh sách thiết bị ảnh hưởng
            List<string> dsThietBi = new List<string>();
            if (chkMayTinhBan.Checked) dsThietBi.Add("Máy tính bàn");
            if (chkLaptop.Checked) dsThietBi.Add("Laptop");
            if (chkMayIn.Checked) dsThietBi.Add("Máy in");
            if (chkDienThoai.Checked) dsThietBi.Add("Điện thoại");

            string strThietBi = dsThietBi.Count > 0 ? string.Join(", ", dsThietBi) : "Không có";

            // 3. Hiển thị bảng tóm tắt qua MessageBox
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("=== PHIẾU TIẾP NHẬN SỰ CỐ IT ===");
            sb.AppendLine($"- Mã phiếu: {txtMaPhieu.Text.Trim()}");
            sb.AppendLine($"- Người yêu cầu: {txtNguoiYeuCau.Text.Trim()}");
            sb.AppendLine($"- Ngày ghi nhận: {dtpNgayGhiNhan.Value:dd/MM/yyyy}");
            sb.AppendLine($"- Mức độ ưu tiên: {mucDoUuTien}");
            sb.AppendLine($"- Loại sự cố: {cboLoaiSuCo.SelectedItem}");
            sb.AppendLine($"- Thiết bị ảnh hưởng: {strThietBi}");
            sb.AppendLine($"- Ảnh đính kèm: {(string.IsNullOrEmpty(duongDanAnh) ? "Không có" : Path.GetFileName(duongDanAnh))}");

            MessageBox.Show(sb.ToString(), "Thông tin phiếu tiếp nhận", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now;

            rdoTrungBinh.Checked = true;
            if (cboLoaiSuCo.Items.Count > 0) cboLoaiSuCo.SelectedIndex = 0;

            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            if (picLoi.Image != null)
            {
                picLoi.Image.Dispose();
                picLoi.Image = null;
            }
            duongDanAnh = "";

            txtMaPhieu.Focus();
        }
    }
}
