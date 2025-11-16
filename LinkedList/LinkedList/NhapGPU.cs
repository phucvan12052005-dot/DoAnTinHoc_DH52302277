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
    public partial class NhapGPU : Form
    {
        public NhapGPU()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public GPUClass GPU
        {
            get; private set;
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
                    txtChip.Text,
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void NhapGPU_Load(object sender, EventArgs e)
        {

        }
    }
}
