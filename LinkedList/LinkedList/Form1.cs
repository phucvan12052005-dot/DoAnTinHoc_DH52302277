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
using System.Globalization;

namespace LinkedList
{
    public partial class Form1 : Form
    {
        private DanhMucGPU danhMuc = new DanhMucGPU();
        private void HienThi()
        {
            BindingList<GPUClass> bindingList = new BindingList<GPUClass>();
            var current = danhMuc.DanhSachGPU.GetHead();

            while (current != null)
            {
                bindingList.Add(current.Data);
                current = current.Next;
            }

            dataGridView1.DataSource = bindingList;
        }

        private Func<GPUClass, IComparable> lastSelector;
        private bool lastTangDan;
        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog.Title = "Chọn file GPU CSV";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                // Kiểm tra nếu đã có dữ liệu
                if (danhMuc.SoLuong() > 0)
                {
                    DialogResult result = MessageBox.Show(
                        "Danh sách hiện tại đã có dữ liệu. Bạn có muốn ghi đè bằng dữ liệu mới từ file?",
                        "Xác nhận ghi đè",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (result != DialogResult.Yes)
                    {
                        return; // người dùng không muốn ghi đè
                    }

                    // Xóa dữ liệu cũ
                    danhMuc.XoaToanBo(); 
                }

                // Đọc dữ liệu mới
                danhMuc.DocTuFileCSV(filePath);

                // Hiển thị lên DataGridView
                HienThi();

                // Tùy chỉnh giao diện bảng
                dataGridView1.EnableHeadersVisualStyles = false;
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkSlateGray;
                dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để ghi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.Title = "Lưu danh sách GPU";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    // Ghi dòng tiêu đề
                    writer.WriteLine("manufacturer,productName,releaseYear,memSize,memBusWidth,gpuClock,memClock,unifiedShader,tmu,rop,pixelShader,vertexShader,igp,bus,memType,gpuChip");

                    // Duyệt qua tất cả các dòng trong DataGridView
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.DataBoundItem is GPUClass gpu)
                        {
                            string line = string.Join(",",
                                gpu.Manufacturer,
                                gpu.ProductName,
                                gpu.ReleaseYear.ToString(),
                                gpu.MemSize.ToString(),
                                gpu.MemBusWidth.ToString(),
                                gpu.GpuClock.ToString(),
                                gpu.MemClock.ToString(),
                                gpu.UnifiedShader.ToString(),
                                gpu.Tmu.ToString(),
                                gpu.Rop.ToString(),
                                gpu.PixelShader == 0 ? "" : gpu.PixelShader.ToString(),
                                gpu.VertexShader == 0 ? "" : gpu.VertexShader.ToString(),
                                gpu.Igp ? "Yes" : "No",
                                gpu.Bus,
                                gpu.MemType,
                                gpu.GpuChip
                            );

                            writer.WriteLine(line);
                        }
                    }
                }

                MessageBox.Show("Đã ghi file thành công!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa các dòng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.DataBoundItem is GPUClass gpu)
                {
                    danhMuc.XoaGPU(gpu);
                }
            }

            HienThi(); 
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhapGPU formNhap = new NhapGPU();
            var result = formNhap.ShowDialog();

            if (result == DialogResult.OK && formNhap.GPU != null)
            {
                danhMuc.ThemGPU(formNhap.GPU);
                HienThi();
                MessageBox.Show("Đã thêm GPU thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (lastSelector != null)
                    danhMuc.SapXepTheoThuocTinh(lastSelector, lastTangDan);

                HienThi();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa!", "Thông báo");
                return;
            }

            GPUClass gpuCu = dataGridView1.SelectedRows[0].DataBoundItem as GPUClass;
            if (gpuCu == null) return;

            SuaGPU formSua = new SuaGPU(gpuCu); // truyền dữ liệu từ dòng đang chọn

            if (formSua.ShowDialog() == DialogResult.OK)
            {
                GPUClass gpuMoi = formSua.GPU;
                danhMuc.SuaGPU(gpuCu, gpuMoi); // cập nhật node trong danh sách liên kết
                HienThi(); // cập nhật lại bảng
                if (lastSelector != null)
                    danhMuc.SapXepTheoThuocTinh(lastSelector, lastTangDan);

                HienThi();
            }
        }

        private void btnSapxep_Click(object sender, EventArgs e)
        {
            if (danhMuc.SoLuong() == 0)
                MessageBox.Show("Danh sách chưa có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Sapxep sapxep = new Sapxep(danhMuc);
                if (sapxep.ShowDialog() == DialogResult.OK)
                {
                    lastSelector = sapxep.Selector;
                    lastTangDan = sapxep.TangDan;

                    danhMuc.SapXepTheoThuocTinh(lastSelector, lastTangDan);
                    HienThi();
                }
            }
        }

        private void btnTimKiem1_Click(object sender, EventArgs e)
        {
            string hang = txtTim1.Text.Trim(); // lấy tên hãng từ TextBox
            var dsKetQua = danhMuc.TimKiemTheoHang(hang);

            if (dsKetQua.IsEmpty())
            {
                MessageBox.Show("Không tìm thấy GPU nào của hãng " + hang);
            }
            else
            {
                // Hiển thị kết quả lên DataGridView
                BindingList<GPUClass> bindingList = new BindingList<GPUClass>();
                var current = dsKetQua.GetHead();
                while (current != null)
                {
                    bindingList.Add(current.Data);
                    current = current.Next;
                }
                dataGridView1.DataSource = bindingList;
            }
            txtTim1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=null;
            danhMuc.XoaToanBo();
        }

        private void btnTimKiem2_Click(object sender, EventArgs e)
        {
            string tenSP = txtTim2.Text.Trim();
            var dsKetQua = danhMuc.TimKiemTheoTen(tenSP);

            if (dsKetQua.IsEmpty())
            {
                MessageBox.Show("Không tìm thấy GPU nào có tên chứa: " + tenSP);
            }
            else
            {
                BindingList<GPUClass> bindingList = new BindingList<GPUClass>();
                var current = dsKetQua.GetHead();
                while (current != null)
                {
                    bindingList.Add(current.Data);
                    current = current.Next;
                }
                dataGridView1.DataSource = bindingList;
            }
            txtTim2.Text = "";
        }

        private void txtTim3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTim3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // chặn ký tự không hợp lệ
            }
        }

        private void btnTimKiem3_Click(object sender, EventArgs e)
        {

            if (float.TryParse(txtTim3.Text.Trim(), out float nam))
            {
                var dsKetQua = danhMuc.TimKiemTheoNam(nam);

                if (dsKetQua.IsEmpty())
                {
                    MessageBox.Show("Không tìm thấy GPU nào phát hành năm " + nam);
                }
                else
                {
                    BindingList<GPUClass> bindingList = new BindingList<GPUClass>();
                    var current = dsKetQua.GetHead();
                    while (current != null)
                    {
                        bindingList.Add(current.Data);
                        current = current.Next;
                    }
                    dataGridView1.DataSource = bindingList;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập năm hợp lệ!");
            }
            txtTim3.Text = "";
        }

    }

}
