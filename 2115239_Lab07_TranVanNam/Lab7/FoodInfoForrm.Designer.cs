namespace Lab7
{
    partial class FoodInfoForrm
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.cbbCatName = new System.Windows.Forms.ComboBox();
			this.nudPrice = new System.Windows.Forms.NumericUpDown();
			this.btnUpdateFood = new System.Windows.Forms.Button();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnAddFood = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 25);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã món ăn:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(25, 48);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(67, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Tên món ăn:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(25, 71);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Số lượng:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(25, 95);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Tên nhóm:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 118);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Giá:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(25, 141);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "Ghi chú:";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(86, 20);
			this.txtID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtID.Name = "txtID";
			this.txtID.ReadOnly = true;
			this.txtID.Size = new System.Drawing.Size(254, 20);
			this.txtID.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(86, 43);
			this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(254, 20);
			this.txtName.TabIndex = 1;
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(86, 66);
			this.txtUnit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(254, 20);
			this.txtUnit.TabIndex = 1;
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(86, 136);
			this.txtNotes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(254, 20);
			this.txtNotes.TabIndex = 1;
			// 
			// cbbCatName
			// 
			this.cbbCatName.FormattingEnabled = true;
			this.cbbCatName.Location = new System.Drawing.Point(86, 88);
			this.cbbCatName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbbCatName.Name = "cbbCatName";
			this.cbbCatName.Size = new System.Drawing.Size(184, 21);
			this.cbbCatName.TabIndex = 2;
			// 
			// nudPrice
			// 
			this.nudPrice.Location = new System.Drawing.Point(86, 113);
			this.nudPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.nudPrice.Name = "nudPrice";
			this.nudPrice.Size = new System.Drawing.Size(253, 20);
			this.nudPrice.TabIndex = 3;
			// 
			// btnUpdateFood
			// 
			this.btnUpdateFood.Location = new System.Drawing.Point(187, 167);
			this.btnUpdateFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnUpdateFood.Name = "btnUpdateFood";
			this.btnUpdateFood.Size = new System.Drawing.Size(61, 20);
			this.btnUpdateFood.TabIndex = 4;
			this.btnUpdateFood.Text = "Cập nhật";
			this.btnUpdateFood.UseVisualStyleBackColor = true;
			this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
			// 
			// btnAddNew
			// 
			this.btnAddNew.Location = new System.Drawing.Point(274, 87);
			this.btnAddNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(65, 20);
			this.btnAddNew.TabIndex = 4;
			this.btnAddNew.Text = "Thêm nhóm";
			this.btnAddNew.UseVisualStyleBackColor = true;
			this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(283, 167);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(56, 20);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Đóng";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnAddFood
			// 
			this.btnAddFood.Location = new System.Drawing.Point(86, 167);
			this.btnAddFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(62, 20);
			this.btnAddFood.TabIndex = 4;
			this.btnAddFood.Text = "Thêm món";
			this.btnAddFood.UseVisualStyleBackColor = true;
			this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
			// 
			// FoodInfoForrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(352, 203);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.btnAddFood);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnUpdateFood);
			this.Controls.Add(this.nudPrice);
			this.Controls.Add(this.cbbCatName);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.txtUnit);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FoodInfoForrm";
			this.Text = "FoodInfoForrm";
			this.Load += new System.EventHandler(this.FoodInfoForrm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cbbCatName;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddFood;
    }
}