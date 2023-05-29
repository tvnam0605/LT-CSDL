namespace Lab7
{
    partial class OrderDetailsForm
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
			this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvOrderDetail
			// 
			this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvOrderDetail.Location = new System.Drawing.Point(0, 0);
			this.dgvOrderDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvOrderDetail.Name = "dgvOrderDetail";
			this.dgvOrderDetail.RowHeadersWidth = 51;
			this.dgvOrderDetail.RowTemplate.Height = 24;
			this.dgvOrderDetail.Size = new System.Drawing.Size(483, 284);
			this.dgvOrderDetail.TabIndex = 0;
			// 
			// OrderDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(483, 284);
			this.Controls.Add(this.dgvOrderDetail);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "OrderDetailsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "OrderDetailsForm";
			this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOrderDetail;
    }
}