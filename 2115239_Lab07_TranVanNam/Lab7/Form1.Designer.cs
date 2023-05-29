namespace Lab7
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCalculateQuantity = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddFood = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUpdateFood = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAccount = new System.Windows.Forms.Button();
            this.bntBills = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn nhóm món ăn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm theo tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Có tất cả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "món ăn thuộc nhóm";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(80, 425);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(16, 16);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "...";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(230, 425);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(16, 16);
            this.lblCatName.TabIndex = 0;
            this.lblCatName.Text = "...";
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Location = new System.Drawing.Point(12, 75);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.RowHeadersWidth = 51;
            this.dgvFoodList.RowTemplate.Height = 24;
            this.dgvFoodList.Size = new System.Drawing.Size(776, 334);
            this.dgvFoodList.TabIndex = 1;
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(142, 31);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(232, 24);
            this.cbbCategory.TabIndex = 2;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(469, 33);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(319, 22);
            this.txtSearchByName.TabIndex = 3;
            this.txtSearchByName.TextChanged += new System.EventHandler(this.txtSearchByName_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCalculateQuantity,
            this.tsmAddFood,
            this.tsmUpdateFood});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 76);
            // 
            // tsmCalculateQuantity
            // 
            this.tsmCalculateQuantity.Name = "tsmCalculateQuantity";
            this.tsmCalculateQuantity.Size = new System.Drawing.Size(218, 24);
            this.tsmCalculateQuantity.Text = "Tính số lượng đã bán";
            this.tsmCalculateQuantity.Click += new System.EventHandler(this.tsmCalculateQuantity_Click);
            // 
            // tsmAddFood
            // 
            this.tsmAddFood.Name = "tsmAddFood";
            this.tsmAddFood.Size = new System.Drawing.Size(218, 24);
            this.tsmAddFood.Text = "Thêm món ăn";
            this.tsmAddFood.Click += new System.EventHandler(this.tsmAddFood_Click);
            // 
            // tsmUpdateFood
            // 
            this.tsmUpdateFood.Name = "tsmUpdateFood";
            this.tsmUpdateFood.Size = new System.Drawing.Size(218, 24);
            this.tsmUpdateFood.Text = "Cập nhật món ăn";
            this.tsmUpdateFood.Click += new System.EventHandler(this.tsmUpdateFood_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(418, 418);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(109, 23);
            this.btnAccount.TabIndex = 4;
            this.btnAccount.Text = "Xem tài khoản";
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // bntBills
            // 
            this.bntBills.Location = new System.Drawing.Point(533, 418);
            this.bntBills.Name = "bntBills";
            this.bntBills.Size = new System.Drawing.Size(109, 23);
            this.bntBills.TabIndex = 4;
            this.bntBills.Text = "Xuất hoá đơn";
            this.bntBills.UseVisualStyleBackColor = true;
            this.bntBills.Click += new System.EventHandler(this.bntBills_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.bntBills);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmCalculateQuantity;
        private System.Windows.Forms.ToolStripMenuItem tsmAddFood;
        private System.Windows.Forms.ToolStripMenuItem tsmUpdateFood;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button bntBills;
    }
}

