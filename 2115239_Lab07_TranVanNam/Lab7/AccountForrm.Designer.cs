namespace Lab7
{
    partial class AccountForrm
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtAccountName = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtFullName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.mtbSDT = new System.Windows.Forms.MaskedTextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.dgvAccount = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmRole = new System.Windows.Forms.ToolStripMenuItem();
			this.xemNhậtKýHoạtĐộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(55, 31);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(76, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Tên tài khoản:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(55, 54);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Mật khẩu:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 76);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Họ tên:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(332, 31);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Email:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(332, 54);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "SĐT:";
			// 
			// txtAccountName
			// 
			this.txtAccountName.Location = new System.Drawing.Point(128, 26);
			this.txtAccountName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtAccountName.Name = "txtAccountName";
			this.txtAccountName.Size = new System.Drawing.Size(130, 20);
			this.txtAccountName.TabIndex = 1;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(128, 49);
			this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtPass.Name = "txtPass";
			this.txtPass.Size = new System.Drawing.Size(130, 20);
			this.txtPass.TabIndex = 1;
			// 
			// txtFullName
			// 
			this.txtFullName.Location = new System.Drawing.Point(128, 72);
			this.txtFullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtFullName.Name = "txtFullName";
			this.txtFullName.Size = new System.Drawing.Size(130, 20);
			this.txtFullName.TabIndex = 1;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(370, 26);
			this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(148, 20);
			this.txtEmail.TabIndex = 1;
			// 
			// mtbSDT
			// 
			this.mtbSDT.Location = new System.Drawing.Point(370, 49);
			this.mtbSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.mtbSDT.Mask = "0000.000.000";
			this.mtbSDT.Name = "mtbSDT";
			this.mtbSDT.Size = new System.Drawing.Size(148, 20);
			this.mtbSDT.TabIndex = 2;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(334, 74);
			this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(70, 19);
			this.btnSave.TabIndex = 3;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(444, 76);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(74, 19);
			this.btnUpdate.TabIndex = 3;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// dgvAccount
			// 
			this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccount.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvAccount.Location = new System.Drawing.Point(9, 98);
			this.dgvAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvAccount.Name = "dgvAccount";
			this.dgvAccount.RowHeadersWidth = 51;
			this.dgvAccount.RowTemplate.Height = 24;
			this.dgvAccount.Size = new System.Drawing.Size(582, 258);
			this.dgvAccount.TabIndex = 4;
			this.dgvAccount.Click += new System.EventHandler(this.dgvAccount_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRole,
            this.xemNhậtKýHoạtĐộngToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(199, 48);
			// 
			// tsmRole
			// 
			this.tsmRole.Name = "tsmRole";
			this.tsmRole.Size = new System.Drawing.Size(198, 22);
			this.tsmRole.Text = "Xem danh sách vai trò";
			this.tsmRole.Click += new System.EventHandler(this.tsmRole_Click);
			// 
			// xemNhậtKýHoạtĐộngToolStripMenuItem
			// 
			this.xemNhậtKýHoạtĐộngToolStripMenuItem.Name = "xemNhậtKýHoạtĐộngToolStripMenuItem";
			this.xemNhậtKýHoạtĐộngToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.xemNhậtKýHoạtĐộngToolStripMenuItem.Text = "Xem nhật ký hoạt động";
			// 
			// AccountForrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.dgvAccount);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.mtbSDT);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtFullName);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtAccountName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "AccountForrm";
			this.Text = "AccountForrm";
			this.Load += new System.EventHandler(this.AccountForrm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtbSDT;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmRole;
        private System.Windows.Forms.ToolStripMenuItem xemNhậtKýHoạtĐộngToolStripMenuItem;
    }
}