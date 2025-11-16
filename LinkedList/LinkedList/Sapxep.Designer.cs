namespace LinkedList
{
    partial class Sapxep
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.rbMF = new System.Windows.Forms.RadioButton();
            this.rbGPU = new System.Windows.Forms.RadioButton();
            this.rbMC = new System.Windows.Forms.RadioButton();
            this.rbPS = new System.Windows.Forms.RadioButton();
            this.rbPN = new System.Windows.Forms.RadioButton();
            this.rbyear = new System.Windows.Forms.RadioButton();
            this.rbUS = new System.Windows.Forms.RadioButton();
            this.rbVS = new System.Windows.Forms.RadioButton();
            this.rbBUS = new System.Windows.Forms.RadioButton();
            this.rbMS = new System.Windows.Forms.RadioButton();
            this.rbMT = new System.Windows.Forms.RadioButton();
            this.rbBW = new System.Windows.Forms.RadioButton();
            this.rbTMU = new System.Windows.Forms.RadioButton();
            this.rbROP = new System.Windows.Forms.RadioButton();
            this.rbGC = new System.Windows.Forms.RadioButton();
            this.rbIGP = new System.Windows.Forms.RadioButton();
            this.btnOK = new System.Windows.Forms.Button();
            this.comboBoxSapxep = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(25, 28);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(243, 24);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = " Chọn trường để sắp xếp";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // rbMF
            // 
            this.rbMF.AutoSize = true;
            this.rbMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbMF.Location = new System.Drawing.Point(29, 76);
            this.rbMF.Name = "rbMF";
            this.rbMF.Size = new System.Drawing.Size(122, 24);
            this.rbMF.TabIndex = 2;
            this.rbMF.Text = "Manufacturer";
            this.rbMF.UseVisualStyleBackColor = true;
            // 
            // rbGPU
            // 
            this.rbGPU.AutoSize = true;
            this.rbGPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbGPU.Location = new System.Drawing.Point(29, 106);
            this.rbGPU.Name = "rbGPU";
            this.rbGPU.Size = new System.Drawing.Size(98, 24);
            this.rbGPU.TabIndex = 2;
            this.rbGPU.Text = "GPU Chip";
            this.rbGPU.UseVisualStyleBackColor = true;
            // 
            // rbMC
            // 
            this.rbMC.AutoSize = true;
            this.rbMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbMC.Location = new System.Drawing.Point(29, 134);
            this.rbMC.Name = "rbMC";
            this.rbMC.Size = new System.Drawing.Size(126, 24);
            this.rbMC.TabIndex = 2;
            this.rbMC.Text = "Memory Clock";
            this.rbMC.UseVisualStyleBackColor = true;
            // 
            // rbPS
            // 
            this.rbPS.AutoSize = true;
            this.rbPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbPS.Location = new System.Drawing.Point(29, 164);
            this.rbPS.Name = "rbPS";
            this.rbPS.Size = new System.Drawing.Size(115, 24);
            this.rbPS.TabIndex = 2;
            this.rbPS.Text = "Pixel Shader";
            this.rbPS.UseVisualStyleBackColor = true;
            // 
            // rbPN
            // 
            this.rbPN.AutoSize = true;
            this.rbPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbPN.Location = new System.Drawing.Point(193, 76);
            this.rbPN.Name = "rbPN";
            this.rbPN.Size = new System.Drawing.Size(126, 24);
            this.rbPN.TabIndex = 2;
            this.rbPN.Text = "Product name";
            this.rbPN.UseVisualStyleBackColor = true;
            // 
            // rbyear
            // 
            this.rbyear.AutoSize = true;
            this.rbyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbyear.Location = new System.Drawing.Point(193, 106);
            this.rbyear.Name = "rbyear";
            this.rbyear.Size = new System.Drawing.Size(124, 24);
            this.rbyear.TabIndex = 2;
            this.rbyear.Text = "Release Year";
            this.rbyear.UseVisualStyleBackColor = true;
            // 
            // rbUS
            // 
            this.rbUS.AutoSize = true;
            this.rbUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbUS.Location = new System.Drawing.Point(193, 134);
            this.rbUS.Name = "rbUS";
            this.rbUS.Size = new System.Drawing.Size(133, 24);
            this.rbUS.TabIndex = 2;
            this.rbUS.Text = "Unified Shader";
            this.rbUS.UseVisualStyleBackColor = true;
            // 
            // rbVS
            // 
            this.rbVS.AutoSize = true;
            this.rbVS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbVS.Location = new System.Drawing.Point(193, 164);
            this.rbVS.Name = "rbVS";
            this.rbVS.Size = new System.Drawing.Size(129, 24);
            this.rbVS.TabIndex = 2;
            this.rbVS.Text = "Vertex Shader";
            this.rbVS.UseVisualStyleBackColor = true;
            // 
            // rbBUS
            // 
            this.rbBUS.AutoSize = true;
            this.rbBUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbBUS.Location = new System.Drawing.Point(363, 76);
            this.rbBUS.Name = "rbBUS";
            this.rbBUS.Size = new System.Drawing.Size(55, 24);
            this.rbBUS.TabIndex = 2;
            this.rbBUS.Text = "Bus";
            this.rbBUS.UseVisualStyleBackColor = true;
            // 
            // rbMS
            // 
            this.rbMS.AutoSize = true;
            this.rbMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbMS.Location = new System.Drawing.Point(363, 106);
            this.rbMS.Name = "rbMS";
            this.rbMS.Size = new System.Drawing.Size(118, 24);
            this.rbMS.TabIndex = 2;
            this.rbMS.Text = "Memory Size";
            this.rbMS.UseVisualStyleBackColor = true;
            // 
            // rbMT
            // 
            this.rbMT.AutoSize = true;
            this.rbMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbMT.Location = new System.Drawing.Point(514, 76);
            this.rbMT.Name = "rbMT";
            this.rbMT.Size = new System.Drawing.Size(117, 24);
            this.rbMT.TabIndex = 2;
            this.rbMT.Text = "Memory type";
            this.rbMT.UseVisualStyleBackColor = true;
            // 
            // rbBW
            // 
            this.rbBW.AutoSize = true;
            this.rbBW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbBW.Location = new System.Drawing.Point(514, 106);
            this.rbBW.Name = "rbBW";
            this.rbBW.Size = new System.Drawing.Size(156, 24);
            this.rbBW.TabIndex = 2;
            this.rbBW.Text = "Memery BusWidth";
            this.rbBW.UseVisualStyleBackColor = true;
            // 
            // rbTMU
            // 
            this.rbTMU.AutoSize = true;
            this.rbTMU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbTMU.Location = new System.Drawing.Point(363, 134);
            this.rbTMU.Name = "rbTMU";
            this.rbTMU.Size = new System.Drawing.Size(61, 24);
            this.rbTMU.TabIndex = 2;
            this.rbTMU.Text = "TMU";
            this.rbTMU.UseVisualStyleBackColor = true;
            // 
            // rbROP
            // 
            this.rbROP.AutoSize = true;
            this.rbROP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbROP.Location = new System.Drawing.Point(514, 134);
            this.rbROP.Name = "rbROP";
            this.rbROP.Size = new System.Drawing.Size(61, 24);
            this.rbROP.TabIndex = 2;
            this.rbROP.Text = "ROP";
            this.rbROP.UseVisualStyleBackColor = true;
            // 
            // rbGC
            // 
            this.rbGC.AutoSize = true;
            this.rbGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbGC.Location = new System.Drawing.Point(363, 164);
            this.rbGC.Name = "rbGC";
            this.rbGC.Size = new System.Drawing.Size(105, 24);
            this.rbGC.TabIndex = 2;
            this.rbGC.Text = "GPU Clock";
            this.rbGC.UseVisualStyleBackColor = true;
            // 
            // rbIGP
            // 
            this.rbIGP.AutoSize = true;
            this.rbIGP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rbIGP.Location = new System.Drawing.Point(514, 164);
            this.rbIGP.Name = "rbIGP";
            this.rbIGP.Size = new System.Drawing.Size(55, 24);
            this.rbIGP.TabIndex = 2;
            this.rbIGP.Text = "IGP";
            this.rbIGP.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(647, 210);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // comboBoxSapxep
            // 
            this.comboBoxSapxep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBoxSapxep.FormattingEnabled = true;
            this.comboBoxSapxep.Items.AddRange(new object[] {
            "Tăng dần",
            "Giảm dần"});
            this.comboBoxSapxep.Location = new System.Drawing.Point(274, 24);
            this.comboBoxSapxep.Name = "comboBoxSapxep";
            this.comboBoxSapxep.Size = new System.Drawing.Size(121, 28);
            this.comboBoxSapxep.TabIndex = 5;
            // 
            // Sapxep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 245);
            this.Controls.Add(this.comboBoxSapxep);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.rbIGP);
            this.Controls.Add(this.rbVS);
            this.Controls.Add(this.rbGC);
            this.Controls.Add(this.rbPS);
            this.Controls.Add(this.rbROP);
            this.Controls.Add(this.rbUS);
            this.Controls.Add(this.rbTMU);
            this.Controls.Add(this.rbMC);
            this.Controls.Add(this.rbBW);
            this.Controls.Add(this.rbMT);
            this.Controls.Add(this.rbyear);
            this.Controls.Add(this.rbMS);
            this.Controls.Add(this.rbPN);
            this.Controls.Add(this.rbBUS);
            this.Controls.Add(this.rbGPU);
            this.Controls.Add(this.rbMF);
            this.Controls.Add(this.lbl1);
            this.Name = "Sapxep";
            this.Text = "Sapxep";
            this.Load += new System.EventHandler(this.Sapxep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RadioButton rbMF;
        private System.Windows.Forms.RadioButton rbGPU;
        private System.Windows.Forms.RadioButton rbMC;
        private System.Windows.Forms.RadioButton rbPS;
        private System.Windows.Forms.RadioButton rbPN;
        private System.Windows.Forms.RadioButton rbyear;
        private System.Windows.Forms.RadioButton rbUS;
        private System.Windows.Forms.RadioButton rbVS;
        private System.Windows.Forms.RadioButton rbBUS;
        private System.Windows.Forms.RadioButton rbMS;
        private System.Windows.Forms.RadioButton rbMT;
        private System.Windows.Forms.RadioButton rbBW;
        private System.Windows.Forms.RadioButton rbTMU;
        private System.Windows.Forms.RadioButton rbROP;
        private System.Windows.Forms.RadioButton rbGC;
        private System.Windows.Forms.RadioButton rbIGP;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox comboBoxSapxep;
    }
}