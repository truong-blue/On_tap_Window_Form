using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Đăng ký sự kiện nạp Form và click chọn dòng trên ListView
            this.Load += Form1_Load;
            this.lsvVatTu.SelectedIndexChanged += LsvVatTu_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Nạp danh sách đơn vị tính
            cboDVT.Items.Clear();
            cboDVT.Items.AddRange(new string[] { "Cái", "Bộ", "Kg", "Mét" });
            cboDVT.SelectedIndex = 0;

            // 2. Nạp sẵn 2 dòng dữ liệu mẫu ban đầu để dễ kiểm tra
            ThemDongVaoListView("VT01", "Cáp mạng Cat6 UTP", "Mét", 8500);
            ThemDongVaoListView("VT02", "Đầu bấm mạng RJ45", "Bộ", 150000);
        }

        // Hàm phụ trợ nạp dòng vào ListView
        private void ThemDongVaoListView(string ma, string ten, string dvt, decimal donGia)
        {
            ListViewItem item = new ListViewItem(ma);        // Cột 0: Mã VT
            item.SubItems.Add(ten);                          // Cột 1: Tên VT
            item.SubItems.Add(dvt);                          // Cột 2: Đơn vị tính
            item.SubItems.Add(donGia.ToString("N0"));         // Cột 3: Đơn giá format N0

            lsvVatTu.Items.Add(item);
        }
        // 1. NÚT THÊM MỚI (VALIDATE ĐẦY ĐỦ + TRÙNG MÃ)
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maVT = txtMaVT.Text.Trim();
            string tenVT = txtTenVT.Text.Trim();

            if (string.IsNullOrWhiteSpace(maVT))
            {
                MessageBox.Show("Mã vật tư không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaVT.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(tenVT))
            {
                MessageBox.Show("Tên vật tư không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenVT.Focus();
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ và không được âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.SelectAll();
                txtDonGia.Focus();
                return;
            }

            // Kiểm tra trùng Mã VT trong danh sách ListView
            foreach (ListViewItem item in lsvVatTu.Items)
            {
                if (item.Text.Trim().Equals(maVT, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Mã vật tư '{maVT}' đã tồn tại! Vui lòng nhập mã khác.", "Trùng mã", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMaVT.SelectAll();
                    txtMaVT.Focus();
                    return;
                }
            }

            // Thêm vào ListView
            ThemDongVaoListView(maVT, tenVT, cboDVT.SelectedItem.ToString(), donGia);
            MessageBox.Show("Thêm mới vật tư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XoaTrangKhungNhap();
        }
        // 2. NÚT CẬP NHẬT DÒNG ĐANG CHỌN
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng vật tư cần cập nhật trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenVT = txtTenVT.Text.Trim();
            if (string.IsNullOrWhiteSpace(tenVT))
            {
                MessageBox.Show("Tên vật tư không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenVT.Focus();
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), out decimal donGia) || donGia < 0)
            {
                MessageBox.Show("Đơn giá phải là số hợp lệ và không âm!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDonGia.SelectAll();
                txtDonGia.Focus();
                return;
            }

            // Cập nhật lại các cột của dòng đang chọn
            ListViewItem selectedItem = lsvVatTu.SelectedItems[0];
            selectedItem.SubItems[1].Text = tenVT;
            selectedItem.SubItems[2].Text = cboDVT.SelectedItem.ToString();
            selectedItem.SubItems[3].Text = donGia.ToString("N0");

            MessageBox.Show("Cập nhật thông tin vật tư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XoaTrangKhungNhap();
        }

        // 3. NÚT XÓA 1 DÒNG (XÁC NHẬN YES/NO)
        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem selectedItem = lsvVatTu.SelectedItems[0];
            string maVT = selectedItem.Text;
            string tenVT = selectedItem.SubItems[1].Text;

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa vật tư [{maVT} - {tenVT}]?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lsvVatTu.Items.Remove(selectedItem);
                XoaTrangKhungNhap();
                MessageBox.Show("Đã xóa dòng vật tư thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // 4. NÚT XÓA TOÀN BỘ (CLEAR ALL)
        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (lsvVatTu.Items.Count == 0)
            {
                MessageBox.Show("Danh sách vật tư đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa TOÀN BỘ danh sách vật tư không?",
                "Cảnh báo xóa hết",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                lsvVatTu.Items.Clear();
                XoaTrangKhungNhap();
                MessageBox.Show("Đã xóa sạch toàn bộ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // 5. CHỌN 1 DÒNG TRÊN LISTVIEW -> ĐẨY LÊN TEXTBOX
        private void LsvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvVatTu.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvVatTu.SelectedItems[0];

                txtMaVT.Text = item.Text;
                txtTenVT.Text = item.SubItems[1].Text;
                cboDVT.SelectedItem = item.SubItems[2].Text;

                // Xóa dấu phẩy phân tách nghìn để hiển thị số thuần trên ô nhập
                string rawPrice = item.SubItems[3].Text.Replace(",", "").Replace(".", "");
                txtDonGia.Text = rawPrice;

                // Khóa ô Mã VT khi đang chọn xem/sửa dòng
                txtMaVT.ReadOnly = true;
            }
        }

        // Hàm dọn trắng ô nhập và reset trạng thái
        private void XoaTrangKhungNhap()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            txtDonGia.Clear();
            txtMaVT.ReadOnly = false;
            if (cboDVT.Items.Count > 0)
            {
                cboDVT.SelectedIndex = 0;
            }
            txtMaVT.Focus();
        }
    }
}