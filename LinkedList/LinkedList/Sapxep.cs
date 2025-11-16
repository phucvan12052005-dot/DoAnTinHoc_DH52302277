using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedList
{
    public partial class Sapxep : Form
    {
        private DanhMucGPU DanhMuc;
        public Sapxep(DanhMucGPU dm)
        {
            
            InitializeComponent();
            DanhMuc = dm;
            comboBoxSapxep.SelectedIndex = 0;
        }

        public Sapxep()
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void Sapxep_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            bool TangDan = comboBoxSapxep.SelectedItem.ToString() == "Tăng dần";
            if (rbMF.Checked) 
                DanhMuc.SapXepTheoThuocTinh(g => g.Manufacturer, TangDan);
            else if (rbBUS.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.Bus, TangDan);
            else if (rbPN.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.ProductName, TangDan);
            else if (rbMT.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.MemType, TangDan);
            else if (rbGPU.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.GpuChip, TangDan);
            else if (rbyear.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.ReleaseYear, TangDan);
            else if (rbMS.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.MemSize, TangDan);
            else if  (rbBW.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.MemBusWidth, TangDan);
            else if (rbMC.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.MemClock, TangDan);
            else if (rbUS.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.UnifiedShader, TangDan);
            else if (rbTMU.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.Tmu, TangDan);
            else if (rbROP.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.Rop, TangDan);
            else if (rbPS.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.PixelShader, TangDan);
            else if (rbVS.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.VertexShader, TangDan);
            else if(rbGC.Checked)
                DanhMuc.SapXepTheoThuocTinh(g=>g.VertexShader,TangDan);
            else
                DanhMuc.SapXepTheoThuocTinh(g=>g.Igp, TangDan);
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }
    }
}
