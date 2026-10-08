using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        // 1. Định nghĩa bảng màu trạng thái
        private readonly Color COLOR_TRONG = Color.WhiteSmoke;     // Trắng/Xám nhạt: Trống
        private readonly Color COLOR_DANG_CHON = Color.LightGreen; // Xanh lá: Đang chọn
        private readonly Color COLOR_DA_DAT = Color.Crimson;        // Đỏ: Đã có người đặt / Đã khóa

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cấu hình ComboBox chọn Khung giờ
            cboKhungGio.Items.Clear();
            cboKhungGio.Items.Add("Sáng (100.000đ)");
            cboKhungGio.Items.Add("Tối (150.000đ)");
            cboKhungGio.SelectedIndex = 0;
            cboKhungGio.SelectedIndexChanged += (s, ev) => CapNhatThongKe();

            // Khởi tạo động sơ đồ 20 Button vị trí (4 x 5)
            KhoiTaoSoDoChoNgoi();

            CapNhatThongKe();
        }

        // Tạo 20 nút động bằng vòng lặp for
        private void KhoiTaoSoDoChoNgoi()
        {
            flpSoDo.Controls.Clear();

            for (int i = 1; i <= 20; i++)
            {
                Button btn = new Button();
                btn.Name = "btnSlot_" + i;
                btn.Text = "Bàn " + i.ToString("D2");
                btn.Size = new Size(80, 60);
                btn.Margin = new Padding(5);
                btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;

                // Giả lập sẵn Bàn 03 và Bàn 08 đã có người đặt trước
                if (i == 3 || i == 8)
                {
                    btn.BackColor = COLOR_DA_DAT;
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.BackColor = COLOR_TRONG;
                    btn.ForeColor = Color.Black;
                }

                // Gán chung 1 hàm xử lý sự kiện Click cho cả 20 nút
                btn.Click += BtnSlot_Click;

                flpSoDo.Controls.Add(btn);
            }
        }

        // Hàm sự kiện Click dùng chung (Event Aggregation)
        private void BtnSlot_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            // Nếu vị trí đã bị khóa/đã đặt màu đỏ -> thông báo không cho chọn
            if (btn.BackColor == COLOR_DA_DAT)
            {
                MessageBox.Show($"Vị trí [{btn.Text}] đã có người đặt trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Đổi trạng thái: Trống <-> Đang chọn
            if (btn.BackColor == COLOR_TRONG)
            {
                btn.BackColor = COLOR_DANG_CHON;
            }
            else if (btn.BackColor == COLOR_DANG_CHON)
            {
                btn.BackColor = COLOR_TRONG;
            }

            // Cập nhật lại số lượng và tạm tính tiền
            CapNhatThongKe();
        }

        // Lấy đơn giá theo ComboBox Khung giờ
        private decimal LayDonGiaKhungGio()
        {
            return cboKhungGio.SelectedIndex == 1 ? 150000m : 100000m;
        }

        // Cập nhật nhãn thống kê thời gian thực
        private void CapNhatThongKe()
        {
            int soChoDangChon = 0;

            foreach (Control c in flpSoDo.Controls)
            {
                if (c is Button btn && btn.BackColor == COLOR_DANG_CHON)
                {
                    soChoDangChon++;
                }
            }

            decimal donGia = LayDonGiaKhungGio();
            decimal tongTien = soChoDangChon * donGia;

            lblSoLuongChon.Text = $"Số vị trí đang chọn: {soChoDangChon}";
            lblTamTinhTien.Text = $"Tạm tính tiền: {tongTien:N0} VNĐ";
        }

        // Sự kiện nút "Xác nhận đặt"
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int soLuong = 0;
            foreach (Control c in flpSoDo.Controls)
            {
                if (c is Button btn && btn.BackColor == COLOR_DANG_CHON)
                {
                    soLuong++;
                }
            }

            if (soLuong == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 vị trí bàn trước khi xác nhận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Xác nhận đặt {soLuong} vị trí với {lblTamTinhTien.Text}?",
                "Xác nhận đặt chỗ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                // Đổi toàn bộ nút đang chọn (xanh) thành đã đặt (đỏ)
                foreach (Control c in flpSoDo.Controls)
                {
                    if (c is Button btn && btn.BackColor == COLOR_DANG_CHON)
                    {
                        btn.BackColor = COLOR_DA_DAT;
                        btn.ForeColor = Color.White;
                    }
                }

                CapNhatThongKe();
                MessageBox.Show("Đặt vị trí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Sự kiện nút "Hủy chọn tất cả"
        private void btnHuyChon_Click(object sender, EventArgs e)
        {
            foreach (Control c in flpSoDo.Controls)
            {
                if (c is Button btn && btn.BackColor == COLOR_DANG_CHON)
                {
                    btn.BackColor = COLOR_TRONG;
                }
            }

            CapNhatThongKe();
        }
    }
}