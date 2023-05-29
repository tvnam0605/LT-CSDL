
namespace Lab3_Demo
{
    partial class frmTuyChon
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
        public void InitializeComponent()
        {
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhapTT = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.pnDieuKien = new System.Windows.Forms.Panel();
            this.rdNgaySinh = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdMaSV = new System.Windows.Forms.RadioButton();
            this.groupBoxTim = new System.Windows.Forms.GroupBox();
            this.pnDieuKien.SuspendLayout();
            this.groupBoxTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSapXep
            // 
            this.btnSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSapXep.ForeColor = System.Drawing.Color.Violet;
            this.btnSapXep.Location = new System.Drawing.Point(122, 174);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(75, 23);
            this.btnSapXep.TabIndex = 0;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.ForeColor = System.Drawing.Color.Violet;
            this.btnThoat.Location = new System.Drawing.Point(322, 174);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập thông tin";
            // 
            // txtNhapTT
            // 
            this.txtNhapTT.Location = new System.Drawing.Point(75, 31);
            this.txtNhapTT.Name = "txtNhapTT";
            this.txtNhapTT.Size = new System.Drawing.Size(100, 20);
            this.txtNhapTT.TabIndex = 2;
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTim.ForeColor = System.Drawing.Color.Violet;
            this.btnTim.Location = new System.Drawing.Point(181, 28);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // pnDieuKien
            // 
            this.pnDieuKien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnDieuKien.Controls.Add(this.rdNgaySinh);
            this.pnDieuKien.Controls.Add(this.rdHoTen);
            this.pnDieuKien.Controls.Add(this.rdMaSV);
            this.pnDieuKien.Location = new System.Drawing.Point(123, 18);
            this.pnDieuKien.Name = "pnDieuKien";
            this.pnDieuKien.Size = new System.Drawing.Size(274, 49);
            this.pnDieuKien.TabIndex = 4;
            this.pnDieuKien.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDieuKien_Paint);
            // 
            // rdNgaySinh
            // 
            this.rdNgaySinh.AutoSize = true;
            this.rdNgaySinh.Checked = true;
            this.rdNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdNgaySinh.ForeColor = System.Drawing.Color.Blue;
            this.rdNgaySinh.Location = new System.Drawing.Point(171, 13);
            this.rdNgaySinh.Name = "rdNgaySinh";
            this.rdNgaySinh.Size = new System.Drawing.Size(100, 21);
            this.rdNgaySinh.TabIndex = 0;
            this.rdNgaySinh.TabStop = true;
            this.rdNgaySinh.Text = "Ngày Sinh";
            this.rdNgaySinh.UseVisualStyleBackColor = true;
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdHoTen.ForeColor = System.Drawing.Color.Blue;
            this.rdHoTen.Location = new System.Drawing.Point(86, 13);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(79, 21);
            this.rdHoTen.TabIndex = 0;
            this.rdHoTen.Text = "Họ Tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            // 
            // rdMaSV
            // 
            this.rdMaSV.AutoSize = true;
            this.rdMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.rdMaSV.ForeColor = System.Drawing.Color.Blue;
            this.rdMaSV.Location = new System.Drawing.Point(8, 13);
            this.rdMaSV.Name = "rdMaSV";
            this.rdMaSV.Size = new System.Drawing.Size(72, 21);
            this.rdMaSV.TabIndex = 0;
            this.rdMaSV.Text = "Mã SV";
            this.rdMaSV.UseVisualStyleBackColor = true;
            this.rdMaSV.CheckedChanged += new System.EventHandler(this.btnMaSV_CheckedChanged);
            // 
            // groupBoxTim
            // 
            this.groupBoxTim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxTim.Controls.Add(this.btnTim);
            this.groupBoxTim.Controls.Add(this.label1);
            this.groupBoxTim.Controls.Add(this.txtNhapTT);
            this.groupBoxTim.Location = new System.Drawing.Point(122, 83);
            this.groupBoxTim.Name = "groupBoxTim";
            this.groupBoxTim.Size = new System.Drawing.Size(274, 85);
            this.groupBoxTim.TabIndex = 5;
            this.groupBoxTim.TabStop = false;
            this.groupBoxTim.Enter += new System.EventHandler(this.groupBoxTim_Enter);
            // 
            // frmTuyChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 237);
            this.Controls.Add(this.groupBoxTim);
            this.Controls.Add(this.pnDieuKien);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSapXep);
            this.Name = "frmTuyChon";
            this.Text = "frmTuyChon";
            this.Load += new System.EventHandler(this.frmTuyChon_Load);
            this.pnDieuKien.ResumeLayout(false);
            this.pnDieuKien.PerformLayout();
            this.groupBoxTim.ResumeLayout(false);
            this.groupBoxTim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

       public System.Windows.Forms.Button btnSapXep;
       public System.Windows.Forms.Button btnThoat;
       public System.Windows.Forms.Label label1;
       public System.Windows.Forms.TextBox txtNhapTT;
       public System.Windows.Forms.Button btnTim;
       public System.Windows.Forms.Panel pnDieuKien;
       public System.Windows.Forms.RadioButton rdNgaySinh;
       public System.Windows.Forms.RadioButton rdHoTen;
       public System.Windows.Forms.RadioButton rdMaSV;
       public System.Windows.Forms.GroupBox groupBoxTim;
    }
}