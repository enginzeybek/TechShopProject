namespace TechShopProject.Forms.OrderForms
{
	partial class FrmAddOrder
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
			btnAdd = new Button();
			txtTotalPrice = new TextBox();
			txtQuantity = new TextBox();
			txtProductName = new TextBox();
			txtCustomerName = new TextBox();
			lblTotalPrice = new Label();
			lblQuantity = new Label();
			lblProductName = new Label();
			lblCustomerName = new Label();
			panel1 = new Panel();
			lblOrderAdd = new Label();
			label1 = new Label();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(183, 21, 64);
			panel2.Controls.Add(txtOrderDate);
			panel2.Controls.Add(lblOrderDate);
			panel2.Controls.Add(btnAdd);
			panel2.Controls.Add(txtTotalPrice);
			panel2.Controls.Add(txtQuantity);
			panel2.Controls.Add(txtProductName);
			panel2.Controls.Add(txtCustomerName);
			panel2.Controls.Add(lblTotalPrice);
			panel2.Controls.Add(lblQuantity);
			panel2.Controls.Add(lblProductName);
			panel2.Controls.Add(lblCustomerName);
			panel2.Location = new Point(4, 236);
			panel2.Name = "panel2";
			panel2.Size = new Size(1392, 508);
			panel2.TabIndex = 3;
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
			lblOrderDate.ForeColor = SystemColors.ControlLightLight;
			lblOrderDate.Location = new Point(50, 372);
			lblOrderDate.Name = "lblOrderDate";
			lblOrderDate.Size = new Size(147, 31);
			lblOrderDate.TabIndex = 11;
			lblOrderDate.Text = "Sipariş Tarihi";
			// 
			// btnAdd
			// 
			btnAdd.BackColor = Color.FromArgb(255, 56, 56);
			btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			btnAdd.Location = new Point(266, 436);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(194, 48);
			btnAdd.TabIndex = 10;
			btnAdd.Text = "Ekle";
			btnAdd.UseVisualStyleBackColor = false;
			btnAdd.Click += btnAdd_Click;
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
			lblTotalPrice.ForeColor = SystemColors.ControlLightLight;
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
			lblQuantity.ForeColor = SystemColors.ControlLightLight;
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
			lblProductName.ForeColor = SystemColors.ControlLightLight;
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
			lblCustomerName.ForeColor = SystemColors.ControlLightLight;
			lblCustomerName.Location = new Point(50, 40);
			lblCustomerName.Name = "lblCustomerName";
			lblCustomerName.Size = new Size(142, 31);
			lblCustomerName.TabIndex = 2;
			lblCustomerName.Text = "Müşteri İsmi\r\n";
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(60, 99, 130);
			panel1.Controls.Add(lblOrderAdd);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(4, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1392, 230);
			panel1.TabIndex = 2;
			// 
			// lblOrderAdd
			// 
			lblOrderAdd.AutoSize = true;
			lblOrderAdd.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblOrderAdd.ForeColor = SystemColors.ButtonHighlight;
			lblOrderAdd.Location = new Point(438, 90);
			lblOrderAdd.Name = "lblOrderAdd";
			lblOrderAdd.Size = new Size(370, 46);
			lblOrderAdd.TabIndex = 1;
			lblOrderAdd.Text = "Sipariş Ekleme Sayfası";
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
			// FrmAddOrder
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1400, 744);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "FrmAddOrder";
			Text = "FrmAddOrder";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private Button btnAdd;
		private TextBox txtTotalPrice;
		private TextBox txtQuantity;
		private TextBox txtProductName;
		private TextBox txtCustomerName;
		private Label lblTotalPrice;
		private Label lblQuantity;
		private Label lblProductName;
		private Label lblCustomerName;
		private Panel panel1;
		private Label lblOrderAdd;
		private Label label1;
		private TextBox txtOrderDate;
		private Label lblOrderDate;
	}
}