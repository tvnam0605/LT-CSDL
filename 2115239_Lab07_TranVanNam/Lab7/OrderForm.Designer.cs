namespace Lab7
{
    partial class OrderForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.lbDoanhThu = new System.Windows.Forms.Label();
			this.dpkTuNgay = new System.Windows.Forms.DateTimePicker();
			this.dgvHoaDon = new System.Windows.Forms.DataGridView();
			this.btnEnter = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dpkDenNgay = new System.Windows.Forms.DateTimePicker();
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Ngày:";
			// 
			// lbDoanhThu
			// 
			this.lbDoanhThu.AutoSize = true;
			this.lbDoanhThu.Location = new System.Drawing.Point(438, 16);
			this.lbDoanhThu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbDoanhThu.Name = "lbDoanhThu";
			this.lbDoanhThu.Size = new System.Drawing.Size(16, 13);
			this.lbDoanhThu.TabIndex = 1;
			this.lbDoanhThu.Text = "...";
			this.lbDoanhThu.Click += new System.EventHandler(this.lbDoanhThu_Click);
			// 
			// dpkTuNgay
			// 
			this.dpkTuNgay.CustomFormat = "dd/MM/yyyy";
			this.dpkTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpkTuNgay.Location = new System.Drawing.Point(62, 14);
			this.dpkTuNgay.Margin = new System.Windows.Forms.Padding(2);
			this.dpkTuNgay.Name = "dpkTuNgay";
			this.dpkTuNgay.Size = new System.Drawing.Size(151, 20);
			this.dpkTuNgay.TabIndex = 2;
			// 
			// dgvHoaDon
			// 
			this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHoaDon.Location = new System.Drawing.Point(9, 118);
			this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2);
			this.dgvHoaDon.Name = "dgvHoaDon";
			this.dgvHoaDon.RowHeadersWidth = 51;
			this.dgvHoaDon.RowTemplate.Height = 24;
			this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHoaDon.Size = new System.Drawing.Size(582, 238);
			this.dgvHoaDon.TabIndex = 3;
			this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
			this.dgvHoaDon.DoubleClick += new System.EventHandler(this.dgvHoaDon_DoubleClick);
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(229, 11);
			this.btnEnter.Margin = new System.Windows.Forms.Padding(2);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(79, 53);
			this.btnEnter.TabIndex = 4;
			this.btnEnter.Text = "Xác nhận";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(331, 16);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tổng doanh thu";
			this.label2.Click += new System.EventHandler(this.lbDoanhThu_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(23, 44);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Ngày:";
			// 
			// dpkDenNgay
			// 
			this.dpkDenNgay.CustomFormat = "dd/MM/yyyy";
			this.dpkDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpkDenNgay.Location = new System.Drawing.Point(62, 44);
			this.dpkDenNgay.Name = "dpkDenNgay";
			this.dpkDenNgay.Size = new System.Drawing.Size(151, 20);
			this.dpkDenNgay.TabIndex = 5;
			this.dpkDenNgay.Value = new System.DateTime(2023, 5, 26, 9, 24, 37, 0);
			// 
			// OrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.dpkDenNgay);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.dgvHoaDon);
			this.Controls.Add(this.dpkTuNgay);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbDoanhThu);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "OrderForm";
			this.Text = "OrderForm";
			this.Load += new System.EventHandler(this.OrderForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbDoanhThu;
        private System.Windows.Forms.DateTimePicker dpkTuNgay;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker dpkDenNgay;
	}
}