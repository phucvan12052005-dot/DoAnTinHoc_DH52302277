namespace LinkedList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDoc = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.Tittle = new System.Windows.Forms.Label();
            this.btnSapxep = new System.Windows.Forms.Button();
            this.txtTim1 = new System.Windows.Forms.TextBox();
            this.btnTimKiem1 = new System.Windows.Forms.Button();
            this.txtTim2 = new System.Windows.Forms.TextBox();
            this.btnTimKiem2 = new System.Windows.Forms.Button();
            this.txtTim3 = new System.Windows.Forms.TextBox();
            this.btnTimKiem3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            this.comboBoxThuocTinh = new System.Windows.Forms.ComboBox();
            this.btnTroVe2 = new System.Windows.Forms.Button();
            this.btnThoat2 = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoc
            // 
            this.btnDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDoc.Location = new System.Drawing.Point(10, 228);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(121, 32);
            this.btnDoc.TabIndex = 0;
            this.btnDoc.Text = "Đọc File CSV";
            this.btnDoc.UseVisualStyleBackColor = true;
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGhi.Location = new System.Drawing.Point(10, 266);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(121, 32);
            this.btnGhi.TabIndex = 0;
            this.btnGhi.Text = "Ghi File";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(178, 228);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 32);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1654, 644);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnXoa.Location = new System.Drawing.Point(178, 266);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 32);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSua.Location = new System.Drawing.Point(271, 228);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 32);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(364, 266);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(87, 32);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Tittle
            // 
            this.Tittle.AutoSize = true;
            this.Tittle.BackColor = System.Drawing.Color.Gray;
            this.Tittle.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tittle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Tittle.Location = new System.Drawing.Point(172, 9);
            this.Tittle.Name = "Tittle";
            this.Tittle.Size = new System.Drawing.Size(1360, 86);
            this.Tittle.TabIndex = 2;
            this.Tittle.Text = "Thông số GPU phát hành theo từng năm ";
            this.Tittle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSapxep
            // 
            this.btnSapxep.Location = new System.Drawing.Point(364, 228);
            this.btnSapxep.Name = "btnSapxep";
            this.btnSapxep.Size = new System.Drawing.Size(87, 32);
            this.btnSapxep.TabIndex = 3;
            this.btnSapxep.Text = "Sắp xếp";
            this.btnSapxep.UseVisualStyleBackColor = true;
            this.btnSapxep.Click += new System.EventHandler(this.btnSapxep_Click);
            // 
            // txtTim1
            // 
            this.txtTim1.Location = new System.Drawing.Point(1156, 206);
            this.txtTim1.Name = "txtTim1";
            this.txtTim1.Size = new System.Drawing.Size(415, 20);
            this.txtTim1.TabIndex = 4;
            // 
            // btnTimKiem1
            // 
            this.btnTimKiem1.Location = new System.Drawing.Point(1577, 199);
            this.btnTimKiem1.Name = "btnTimKiem1";
            this.btnTimKiem1.Size = new System.Drawing.Size(87, 32);
            this.btnTimKiem1.TabIndex = 5;
            this.btnTimKiem1.Text = "Tìm";
            this.btnTimKiem1.UseVisualStyleBackColor = true;
            this.btnTimKiem1.Click += new System.EventHandler(this.btnTimKiem1_Click);
            // 
            // txtTim2
            // 
            this.txtTim2.Location = new System.Drawing.Point(1156, 244);
            this.txtTim2.Name = "txtTim2";
            this.txtTim2.Size = new System.Drawing.Size(415, 20);
            this.txtTim2.TabIndex = 4;
            // 
            // btnTimKiem2
            // 
            this.btnTimKiem2.Location = new System.Drawing.Point(1577, 237);
            this.btnTimKiem2.Name = "btnTimKiem2";
            this.btnTimKiem2.Size = new System.Drawing.Size(87, 32);
            this.btnTimKiem2.TabIndex = 5;
            this.btnTimKiem2.Text = "Tìm";
            this.btnTimKiem2.UseVisualStyleBackColor = true;
            this.btnTimKiem2.Click += new System.EventHandler(this.btnTimKiem2_Click);
            // 
            // txtTim3
            // 
            this.txtTim3.Location = new System.Drawing.Point(1156, 282);
            this.txtTim3.Name = "txtTim3";
            this.txtTim3.Size = new System.Drawing.Size(415, 20);
            this.txtTim3.TabIndex = 4;
            this.txtTim3.TextChanged += new System.EventHandler(this.txtTim3_TextChanged);
            this.txtTim3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTim3_KeyPress);
            // 
            // btnTimKiem3
            // 
            this.btnTimKiem3.Location = new System.Drawing.Point(1577, 275);
            this.btnTimKiem3.Name = "btnTimKiem3";
            this.btnTimKiem3.Size = new System.Drawing.Size(87, 32);
            this.btnTimKiem3.TabIndex = 5;
            this.btnTimKiem3.Text = "Tìm";
            this.btnTimKiem3.UseVisualStyleBackColor = true;
            this.btnTimKiem3.Click += new System.EventHandler(this.btnTimKiem3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1034, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nhập Tên Hãng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1034, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nhập Tên GPU";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1017, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập Năm phát hành";
            // 
            // btnTroVe
            // 
            this.btnTroVe.Location = new System.Drawing.Point(1577, 161);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(87, 32);
            this.btnTroVe.TabIndex = 7;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = true;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(271, 266);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Xóa tất cả";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoc.Location = new System.Drawing.Point(10, 190);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(121, 32);
            this.btnLoc.TabIndex = 10;
            this.btnLoc.Text = "Lọc Danh Sách";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(10, 331);
            this.dgv2.Name = "dgv2";
            this.dgv2.ReadOnly = true;
            this.dgv2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv2.Size = new System.Drawing.Size(797, 644);
            this.dgv2.TabIndex = 11;
            this.dgv2.Visible = false;
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(813, 331);
            this.dgv3.Name = "dgv3";
            this.dgv3.ReadOnly = true;
            this.dgv3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv3.Size = new System.Drawing.Size(851, 644);
            this.dgv3.TabIndex = 12;
            this.dgv3.Visible = false;
            // 
            // comboBoxThuocTinh
            // 
            this.comboBoxThuocTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxThuocTinh.FormattingEnabled = true;
            this.comboBoxThuocTinh.Items.AddRange(new object[] {
            "Manufacturer",
            "ProductName",
            "Bus",
            "MemType",
            "GpuChip",
            "ReleaseYear",
            "MemSize",
            "MemBusWidth",
            "GpuClock",
            "MemClock",
            "UnifiedShader",
            "Tmu",
            "Rop",
            "PixelShader",
            "VertexShader",
            "Igp"});
            this.comboBoxThuocTinh.Location = new System.Drawing.Point(178, 197);
            this.comboBoxThuocTinh.Name = "comboBoxThuocTinh";
            this.comboBoxThuocTinh.Size = new System.Drawing.Size(273, 24);
            this.comboBoxThuocTinh.TabIndex = 13;
            // 
            // btnTroVe2
            // 
            this.btnTroVe2.Location = new System.Drawing.Point(25, 228);
            this.btnTroVe2.Name = "btnTroVe2";
            this.btnTroVe2.Size = new System.Drawing.Size(87, 32);
            this.btnTroVe2.TabIndex = 14;
            this.btnTroVe2.Text = "Trở về";
            this.btnTroVe2.UseVisualStyleBackColor = true;
            this.btnTroVe2.Click += new System.EventHandler(this.btnTroVe2_Click);
            // 
            // btnThoat2
            // 
            this.btnThoat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat2.Location = new System.Drawing.Point(25, 266);
            this.btnThoat2.Name = "btnThoat2";
            this.btnThoat2.Size = new System.Drawing.Size(87, 32);
            this.btnThoat2.TabIndex = 15;
            this.btnThoat2.Text = "Thoát";
            this.btnThoat2.UseVisualStyleBackColor = true;
            this.btnThoat2.Click += new System.EventHandler(this.btnThoat2_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(12, 312);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(44, 16);
            this.lbl4.TabIndex = 16;
            this.lbl4.Text = "label4";
            this.lbl4.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(810, 312);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(44, 16);
            this.lbl5.TabIndex = 17;
            this.lbl5.Text = "label4";
            this.lbl5.Visible = false;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl6.Location = new System.Drawing.Point(184, 237);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(44, 16);
            this.lbl6.TabIndex = 18;
            this.lbl6.Text = "label4";
            this.lbl6.Visible = false;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbl7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl7.Location = new System.Drawing.Point(184, 275);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(44, 16);
            this.lbl7.TabIndex = 19;
            this.lbl7.Text = "label4";
            this.lbl7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1678, 987);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.btnThoat2);
            this.Controls.Add(this.btnTroVe2);
            this.Controls.Add(this.comboBoxThuocTinh);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem3);
            this.Controls.Add(this.btnTimKiem2);
            this.Controls.Add(this.btnTimKiem1);
            this.Controls.Add(this.txtTim3);
            this.Controls.Add(this.txtTim2);
            this.Controls.Add(this.txtTim1);
            this.Controls.Add(this.btnSapxep);
            this.Controls.Add(this.Tittle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnDoc);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quản Lý GPU";
            this.TransparencyKey = System.Drawing.Color.Cyan;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label Tittle;
        private System.Windows.Forms.Button btnSapxep;
        private System.Windows.Forms.TextBox txtTim1;
        private System.Windows.Forms.Button btnTimKiem1;
        private System.Windows.Forms.TextBox txtTim2;
        private System.Windows.Forms.Button btnTimKiem2;
        private System.Windows.Forms.TextBox txtTim3;
        private System.Windows.Forms.Button btnTimKiem3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridView dgv3;
        private System.Windows.Forms.ComboBox comboBoxThuocTinh;
        private System.Windows.Forms.Button btnTroVe2;
        private System.Windows.Forms.Button btnThoat2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
    }
}

