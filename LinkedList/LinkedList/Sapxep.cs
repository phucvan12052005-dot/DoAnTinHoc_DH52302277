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
        public Func<GPUClass, IComparable> Selector { get; private set; }
        public bool TangDan { get; private set; }
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
            if (comboBoxSapxep.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chiều sắp xếp!");
                return;
            }

            TangDan = comboBoxSapxep.SelectedItem.ToString() == "Tăng dần";

            if (rbMF.Checked) Selector = g => g.Manufacturer;
            else if (rbBUS.Checked) Selector = g => g.Bus;
            else if (rbPN.Checked) Selector = g => g.ProductName;
            else if (rbMT.Checked) Selector = g => g.MemType;
            else if (rbGPU.Checked) Selector = g => g.GpuChip;
            else if (rbyear.Checked) Selector = g => g.ReleaseYear;
            else if (rbMS.Checked) Selector = g => g.MemSize;
            else if (rbBW.Checked) Selector = g => g.MemBusWidth;
            else if (rbMC.Checked) Selector = g => g.MemClock;
            else if (rbUS.Checked) Selector = g => g.UnifiedShader;
            else if (rbTMU.Checked) Selector = g => g.Tmu;
            else if (rbROP.Checked) Selector = g => g.Rop;
            else if (rbPS.Checked) Selector = g => g.PixelShader;
            else if (rbVS.Checked) Selector = g => g.VertexShader;
            else if (rbGC.Checked) Selector = g => g.GpuClock;
            else Selector = g => g.Igp;

            this.DialogResult = DialogResult.OK; // KHÔNG gọi Close()
        }

    }
}
