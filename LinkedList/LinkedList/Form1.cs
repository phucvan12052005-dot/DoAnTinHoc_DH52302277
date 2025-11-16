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
        public Form1()
        {

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
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
                danhMuc.GhiRaFileCSV(saveFileDialog.FileName);
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
                    HienThi(); // cập nhật lại DataGridView sau khi sắp xếp
                }
            }
        }
    }
}
