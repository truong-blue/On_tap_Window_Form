using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Nút Tính tiền (đang có tên là button1_Click)
        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra đơn giá
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đơn giá dịch vụ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDonGia.Focus();
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ và không âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.SelectAll();
                txtDonGia.Focus();
                return;
            }

            // 2. Kiểm tra số lượng khách
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                MessageBox.Show("Vui lòng nhập số lượng khách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng khách phải là số nguyên dương (> 0)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSoLuong.SelectAll();
                txtSoLuong.Focus();
                return;
            }

            // 3. Kiểm tra % giảm giá (nếu để trống coi như 0%)
            decimal phanTramGiam = 0;
            if (!string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                if (!decimal.TryParse(txtGiamGia.Text.Trim(), out phanTramGiam) || phanTramGiam < 0 || phanTramGiam > 100)
                {
                    MessageBox.Show("% Giảm giá phải từ 0 đến 100!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtGiamGia.SelectAll();
                    txtGiamGia.Focus();
                    return;
                }
            }

            // 4. Áp dụng công thức tính tổng tiền
            decimal tongTien = (donGia * soLuong) * (100m - phanTramGiam) / 100m;

            // 5. Hiển thị lên Label
            lblTongTien.Text = $"Tổng tiền thanh toán: {tongTien:N0} VNĐ";
        }

        // Nút Làm mới
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            lblTongTien.Text = "0 VNĐ";

            txtDonGia.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
