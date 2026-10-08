using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        // 1. Model dữ liệu cho từng dòng mặt hàng
        public class MatHang : INotifyPropertyChanged
        {
            private string _tenHang = "Hàng mới";
            private int _soLuong = 1;
            private decimal _trongLuong = 1.0m;
            private decimal _donGia = 50000m;

            public string TenHang
            {
                get => _tenHang;
                set { _tenHang = value; OnPropertyChanged("TenHang"); }
            }

            public int SoLuong
            {
                get => _soLuong;
                set { _soLuong = value; OnPropertyChanged("SoLuong"); OnPropertyChanged("ThanhTien"); }
            }

            public decimal TrongLuong
            {
                get => _trongLuong;
                set { _trongLuong = value; OnPropertyChanged("TrongLuong"); }
            }

            public decimal DonGia
            {
                get => _donGia;
                set { _donGia = value; OnPropertyChanged("DonGia"); OnPropertyChanged("ThanhTien"); }
            }

            // Tự động tính Thành tiền
            public decimal ThanhTien => SoLuong * DonGia;

            public event PropertyChangedEventHandler PropertyChanged;
            protected void OnPropertyChanged(string name)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            }
        }

        private BindingList<MatHang> _dsHangHoa = new BindingList<MatHang>();

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true; // Bắt buộc để Form nhận diện phím F2 và Delete
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cấu hình ComboBox Loại vận chuyển nếu có
            if (cboLoaiVanChuyen != null)
            {
                cboLoaiVanChuyen.Items.Clear();
                cboLoaiVanChuyen.Items.AddRange(new string[] { "Tiêu chuẩn", "Hỏa tốc (2H)", "Tiết kiệm" });
                cboLoaiVanChuyen.SelectedIndex = 0;
            }

            // Cấu hình DataGridView
            CauHinhDataGridView();

            // Nạp dữ liệu mẫu ban đầu
            _dsHangHoa.Add(new MatHang { TenHang = "Chuột không dây", SoLuong = 2, TrongLuong = 0.3m, DonGia = 250000m });
            _dsHangHoa.Add(new MatHang { TenHang = "Bàn phím cơ TKL", SoLuong = 1, TrongLuong = 0.9m, DonGia = 850000m });

            // Cấu hình Timer hiển thị thời gian thực
            timerDongHo.Interval = 1000;
            timerDongHo.Tick += (s, ev) =>
            {
                lblStatusThoiGian.Text = "Thời gian: " + DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
            };
            timerDongHo.Start();

            // Đăng ký các sự kiện tương tác
            _dsHangHoa.ListChanged += (s, ev) => CapNhatThanhTrangThai();
            dgvHangHoa.CellValidating += DgvHangHoa_CellValidating;
            dgvHangHoa.CellEndEdit += DgvHangHoa_CellEndEdit;
            this.KeyDown += Form1_KeyDown;

            CapNhatThanhTrangThai();
        }

        // Cấu hình các cột cho DataGridView
        private void CauHinhDataGridView()
        {
            dgvHangHoa.AutoGenerateColumns = false;
            dgvHangHoa.Columns.Clear();

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tên Hàng Hóa",
                DataPropertyName = "TenHang",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvHangHoa.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Số Lượng",
                DataPropertyName = "SoLuong",
                Width = 90
            });

            var colTL = new DataGridViewTextBoxColumn
            {
                HeaderText = "Trọng Lượng (kg)",
                DataPropertyName = "TrongLuong",
                Width = 130
            };
            colTL.DefaultCellStyle.Format = "N1";
            dgvHangHoa.Columns.Add(colTL);

            var colDG = new DataGridViewTextBoxColumn
            {
                HeaderText = "Đơn Giá (VNĐ)",
                DataPropertyName = "DonGia",
                Width = 120
            };
            colDG.DefaultCellStyle.Format = "N0";
            dgvHangHoa.Columns.Add(colDG);

            var colTT = new DataGridViewTextBoxColumn
            {
                HeaderText = "Thành Tiền",
                DataPropertyName = "ThanhTien",
                Width = 130,
                ReadOnly = true // Không cho sửa ô Thành tiền
            };
            colTT.DefaultCellStyle.Format = "N0";
            dgvHangHoa.Columns.Add(colTT);

            dgvHangHoa.DataSource = _dsHangHoa;
        }

        // ==========================================
        // 1. KIỂM TRA LỖI BẰNG ERRORPROVIDER
        // ==========================================
        private void DgvHangHoa_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            // Cột 1: Số lượng
            if (e.ColumnIndex == 1)
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int sl) || sl <= 0)
                {
                    dgvHangHoa.Rows[e.RowIndex].ErrorText = "Số lượng phải > 0!";
                    errorProvider1.SetError(dgvHangHoa, "Số lượng phải là số nguyên dương lớn hơn 0!");
                    e.Cancel = true;
                }
            }
            // Cột 2: Trọng lượng
            else if (e.ColumnIndex == 2)
            {
                if (!decimal.TryParse(e.FormattedValue.ToString(), out decimal tl) || tl <= 0)
                {
                    dgvHangHoa.Rows[e.RowIndex].ErrorText = "Trọng lượng phải > 0 kg!";
                    errorProvider1.SetError(dgvHangHoa, "Trọng lượng phải lớn hơn 0 kg!");
                    e.Cancel = true;
                }
            }
        }

        private void DgvHangHoa_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgvHangHoa.Rows[e.RowIndex].ErrorText = string.Empty;
            errorProvider1.Clear();
            CapNhatThanhTrangThai();
        }

        // ==========================================
        // 2. CẬP NHẬT TỔNG TRÊN STATUSSTRIP
        // ==========================================
        private void CapNhatThanhTrangThai()
        {
            int tongSL = _dsHangHoa.Sum(x => x.SoLuong);
            decimal tongTL = _dsHangHoa.Sum(x => x.TrongLuong * x.SoLuong);
            decimal tongTien = _dsHangHoa.Sum(x => x.ThanhTien);

            lblStatusSoLuong.Text = $"| Tổng SL: {tongSL} món";
            lblStatusTrongLuong.Text = $"| Tổng TL: {tongTL:N1} kg";
            lblStatusTongTien.Text = $"| Tổng tiền: {tongTien:N0} VNĐ";
        }

        // ==========================================
        // 3. XỬ LÝ PHÍM TẮT: F2 VÀ DELETE
        // ==========================================
        // 3. XỬ LÝ PHÍM TẮT: F2 VÀ DELETE
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // F2: Thêm dòng mới
            if (e.KeyCode == Keys.F2)
            {
                // Kết thúc chế độ sửa ô hiện tại trước khi thêm dòng mới
                dgvHangHoa.EndEdit();

                MatHang itemMoi = new MatHang
                {
                    TenHang = "Mặt hàng " + (_dsHangHoa.Count + 1),
                    SoLuong = 1,
                    TrongLuong = 0.5m,
                    DonGia = 100000m
                };

                _dsHangHoa.Add(itemMoi);

                // Cuộn và chọn ô đầu tiên của dòng vừa tạo
                if (dgvHangHoa.Rows.Count > 0)
                {
                    dgvHangHoa.CurrentCell = dgvHangHoa.Rows[dgvHangHoa.Rows.Count - 1].Cells[0];
                }

                e.Handled = true;
                e.SuppressKeyPress = true; // Ngăn chặn sự kiện F2 mặc định của DataGridView
            }
            // Delete: Xóa dòng đang chọn
            else if (e.KeyCode == Keys.Delete)
            {
                // Chỉ xóa khi người dùng KHÔNG đang gõ dở chữ trong một ô
                if (dgvHangHoa.IsCurrentCellInEditMode)
                {
                    return; // Để phím Delete hoạt động xóa ký tự bình thường
                }

                if (dgvHangHoa.CurrentRow != null)
                {
                    var item = dgvHangHoa.CurrentRow.DataBoundItem as MatHang;
                    if (item != null)
                    {
                        DialogResult confirm = MessageBox.Show(
                            $"Bạn có chắc chắn muốn xóa mặt hàng [{item.TenHang}]?",
                            "Xác nhận xóa",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                        if (confirm == DialogResult.Yes)
                        {
                            _dsHangHoa.Remove(item);
                            CapNhatThanhTrangThai();
                        }
                    }
                }

                e.Handled = true;
            }
        }

        // Các hàm sự kiện click sinh ra ngoài ý muốn giữ nguyên để trống
        private void tabPage1_Click(object sender, EventArgs e) { }
        private void lblStatusThoiGian_Click(object sender, EventArgs e) { }
        private void lblStatusSoLuong_Click(object sender, EventArgs e) { }
        private void lblStatusTrongLuong_Click(object sender, EventArgs e) { }
        private void lblStatusTongTien_Click(object sender, EventArgs e) { }
        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e){}
    }
}