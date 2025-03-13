namespace TechShopProject.Forms.OrderForms
{
	partial class FrmUpdateOrder
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
			panel2 = new Panel();
			txtOrderDate = new TextBox();
			lblOrderDate = new Label();
			btnUpdate = new Button();
			txtTotalPrice = new TextBox();
			txtQuantity = new TextBox();
			txtProductName = new TextBox();
			txtCustomerName = new TextBox();
			lblTotalPrice = new Label();
			lblQuantity = new Label();
			lblProductName = new Label();
			lblCustomerName = new Label();
			panel1 = new Panel();
			lblOrderUpdate = new Label();
			label1 = new Label();
			txtOrderId = new TextBox();
			lblOrderId = new Label();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(245, 246, 250);
			panel2.Controls.Add(txtOrderId);
			panel2.Controls.Add(lblOrderId);
			panel2.Controls.Add(txtOrderDate);
			panel2.Controls.Add(lblOrderDate);
			panel2.Controls.Add(btnUpdate);
			panel2.Controls.Add(txtTotalPrice);
			panel2.Controls.Add(txtQuantity);
			panel2.Controls.Add(txtProductName);
			panel2.Controls.Add(txtCustomerName);
			panel2.Controls.Add(lblTotalPrice);
			panel2.Controls.Add(lblQuantity);
			panel2.Controls.Add(lblProductName);
			panel2.Controls.Add(lblCustomerName);
			panel2.Location = new Point(8, 231);
			panel2.Name = "panel2";
			panel2.Size = new Size(1392, 508);
			panel2.TabIndex = 5;
			// 
			// txtOrderDate
			// 
			txtOrderDate.Location = new Point(250, 372);
			txtOrderDate.Name = "txtOrderDate";
			txtOrderDate.Size = new Size(372, 27);
			txtOrderDate.TabIndex = 12;
			// 
			// lblOrderDate
			// 
			lblOrderDate.AutoSize = true;
			lblOrderDate.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblOrderDate.ForeColor = SystemColors.ActiveCaptionText;
			lblOrderDate.Location = new Point(50, 372);
			lblOrderDate.Name = "lblOrderDate";
			lblOrderDate.Size = new Size(147, 31);
			lblOrderDate.TabIndex = 11;
			lblOrderDate.Text = "Sipariş Tarihi";
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.Lime;
			btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			btnUpdate.Location = new Point(266, 436);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(194, 48);
			btnUpdate.TabIndex = 10;
			btnUpdate.Text = "Güncelle";
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// txtTotalPrice
			// 
			txtTotalPrice.Location = new Point(250, 293);
			txtTotalPrice.Name = "txtTotalPrice";
			txtTotalPrice.Size = new Size(372, 27);
			txtTotalPrice.TabIndex = 9;
			// 
			// txtQuantity
			// 
			txtQuantity.Location = new Point(250, 208);
			txtQuantity.Name = "txtQuantity";
			txtQuantity.Size = new Size(372, 27);
			txtQuantity.TabIndex = 8;
			// 
			// txtProductName
			// 
			txtProductName.Location = new Point(250, 119);
			txtProductName.Name = "txtProductName";
			txtProductName.Size = new Size(372, 27);
			txtProductName.TabIndex = 7;
			// 
			// txtCustomerName
			// 
			txtCustomerName.Location = new Point(250, 40);
			txtCustomerName.Name = "txtCustomerName";
			txtCustomerName.Size = new Size(372, 27);
			txtCustomerName.TabIndex = 6;
			// 
			// lblTotalPrice
			// 
			lblTotalPrice.AutoSize = true;
			lblTotalPrice.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblTotalPrice.ForeColor = SystemColors.ActiveCaptionText;
			lblTotalPrice.Location = new Point(50, 293);
			lblTotalPrice.Name = "lblTotalPrice";
			lblTotalPrice.Size = new Size(64, 31);
			lblTotalPrice.TabIndex = 5;
			lblTotalPrice.Text = "Fiyat";
			// 
			// lblQuantity
			// 
			lblQuantity.AutoSize = true;
			lblQuantity.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblQuantity.ForeColor = SystemColors.ActiveCaptionText;
			lblQuantity.Location = new Point(50, 208);
			lblQuantity.Name = "lblQuantity";
			lblQuantity.Size = new Size(63, 31);
			lblQuantity.TabIndex = 4;
			lblQuantity.Text = "Adet";
			// 
			// lblProductName
			// 
			lblProductName.AutoSize = true;
			lblProductName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblProductName.ForeColor = SystemColors.ActiveCaptionText;
			lblProductName.Location = new Point(50, 119);
			lblProductName.Name = "lblProductName";
			lblProductName.Size = new Size(114, 31);
			lblProductName.TabIndex = 3;
			lblProductName.Text = "Ürün İsmi";
			// 
			// lblCustomerName
			// 
			lblCustomerName.AutoSize = true;
			lblCustomerName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblCustomerName.ForeColor = SystemColors.ActiveCaptionText;
			lblCustomerName.Location = new Point(50, 40);
			lblCustomerName.Name = "lblCustomerName";
			lblCustomerName.Size = new Size(142, 31);
			lblCustomerName.TabIndex = 2;
			lblCustomerName.Text = "Müşteri İsmi\r\n";
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(140, 122, 230);
			panel1.Controls.Add(lblOrderUpdate);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(8, -5);
			panel1.Name = "panel1";
			panel1.Size = new Size(1392, 230);
			panel1.TabIndex = 4;
			// 
			// lblOrderUpdate
			// 
			lblOrderUpdate.AutoSize = true;
			lblOrderUpdate.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblOrderUpdate.ForeColor = SystemColors.ButtonHighlight;
			lblOrderUpdate.Location = new Point(438, 90);
			lblOrderUpdate.Name = "lblOrderUpdate";
			lblOrderUpdate.Size = new Size(443, 46);
			lblOrderUpdate.TabIndex = 1;
			lblOrderUpdate.Text = "Sipariş Güncelleme Sayfası";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(50, 20);
			label1.TabIndex = 0;
			label1.Text = "label1";
			// 
			// txtOrderId
			// 
			txtOrderId.Location = new Point(878, 170);
			txtOrderId.Name = "txtOrderId";
			txtOrderId.Size = new Size(372, 27);
			txtOrderId.TabIndex = 14;
			// 
			// lblOrderId
			// 
			lblOrderId.AutoSize = true;
			lblOrderId.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblOrderId.ForeColor = SystemColors.ActiveCaptionText;
			lblOrderId.Location = new Point(678, 170);
			lblOrderId.Name = "lblOrderId";
			lblOrderId.Size = new Size(114, 31);
			lblOrderId.TabIndex = 13;
			lblOrderId.Text = "Sipariş ID";
			// 
			// FrmUpdateOrder
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1409, 735);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "FrmUpdateOrder";
			Text = "FrmUpdateOrder";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private TextBox txtOrderDate;
		private Label lblOrderDate;
		private Button btnUpdate;
		private TextBox txtTotalPrice;
		private TextBox txtQuantity;
		private TextBox txtProductName;
		private TextBox txtCustomerName;
		private Label lblTotalPrice;
		private Label lblQuantity;
		private Label lblProductName;
		private Label lblCustomerName;
		private Panel panel1;
		private Label lblOrderUpdate;
		private Label label1;
		private TextBox txtOrderId;
		private Label lblOrderId;
	}
}