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
    public partial class SuaGPU : Form
    {
        private GPUClass gpuCu;

        public GPUClass GPU { get; private set; }
        public SuaGPU(GPUClass gpu)
        {
            InitializeComponent();
            gpuCu = gpu;

            // Gán dữ liệu lên các ô nhập
            txtMF.Text = gpu.Manufacturer;
            txtPN.Text = gpu.ProductName;
            txtBUS.Text = gpu.Bus;
            txtMT.Text = gpu.MemType;
            txtGC.Text = gpu.GpuChip;
            txtRY.Text = gpu.ReleaseYear.ToString();
            txtMS.Text = gpu.MemSize.ToString();
            txtBW.Text = gpu.MemBusWidth.ToString();
            txtGC.Text = gpu.GpuClock.ToString();
            txtMC.Text = gpu.MemClock.ToString();
            txtUS.Text = gpu.UnifiedShader.ToString();
            txtTMU.Text = gpu.Tmu.ToString();
            txtROP.Text = gpu.Rop.ToString();
            txtPS.Text = gpu.PixelShader == 0 ? "" : gpu.PixelShader.ToString();
            txtVS.Text = gpu.VertexShader == 0 ? "" : gpu.VertexShader.ToString();
            cbIGP.Checked = gpu.Igp;
        }

        private void SuaGPU_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                GPU = new GPUClass(
                    txtMF.Text,
                    txtPN.Text,
                    txtBUS.Text,
                    txtMT.Text,
                    txtGC.Text,
                    float.Parse(txtRY.Text),
                    float.Parse(txtMS.Text),
                    float.Parse(txtBW.Text),
                    float.Parse(txtGC.Text),
                    float.Parse(txtMC.Text),
                    float.Parse(txtUS.Text),
                    float.Parse(txtTMU.Text),
                    float.Parse(txtROP.Text),
                    string.IsNullOrWhiteSpace(txtPS.Text) ? 0 : float.Parse(txtPS.Text),
                    string.IsNullOrWhiteSpace(txtVS.Text) ? 0 : float.Parse(txtVS.Text),
                    cbIGP.Checked
                );

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập dữ liệu: " + ex.Message);
            }
        }
    }
}
