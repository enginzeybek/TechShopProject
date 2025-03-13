﻿namespace TechShopProject.Forms.ProductForms
{
	partial class FrmUpdateProduct
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
			btnUpdate = new Button();
			txtCategory = new TextBox();
			txtPrice = new TextBox();
			txtUnit = new TextBox();
			txtProductName = new TextBox();
			lblCategory = new Label();
			lblPrice = new Label();
			lblUnit = new Label();
			lblProductName = new Label();
			panel1 = new Panel();
			lblProductUpdate = new Label();
			label1 = new Label();
			txtProductId = new TextBox();
			lblProductId = new Label();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(154, 236, 219);
			panel2.Controls.Add(txtProductId);
			panel2.Controls.Add(lblProductId);
			panel2.Controls.Add(btnUpdate);
			panel2.Controls.Add(txtCategory);
			panel2.Controls.Add(txtPrice);
			panel2.Controls.Add(txtUnit);
			panel2.Controls.Add(txtProductName);
			panel2.Controls.Add(lblCategory);
			panel2.Controls.Add(lblPrice);
			panel2.Controls.Add(lblUnit);
			panel2.Controls.Add(lblProductName);
			panel2.Location = new Point(11, 231);
			panel2.Name = "panel2";
			panel2.Size = new Size(1392, 508);
			panel2.TabIndex = 7;
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.FromArgb(214, 162, 232);
			btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			btnUpdate.Location = new Point(268, 394);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(194, 48);
			btnUpdate.TabIndex = 10;
			btnUpdate.Text = "Güncelle";
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// txtCategory
			// 
			txtCategory.Location = new Point(250, 293);
			txtCategory.Name = "txtCategory";
			txtCategory.Size = new Size(372, 27);
			txtCategory.TabIndex = 9;
			// 
			// txtPrice
			// 
			txtPrice.Location = new Point(250, 208);
			txtPrice.Name = "txtPrice";
			txtPrice.Size = new Size(372, 27);
			txtPrice.TabIndex = 8;
			// 
			// txtUnit
			// 
			txtUnit.Location = new Point(250, 119);
			txtUnit.Name = "txtUnit";
			txtUnit.Size = new Size(372, 27);
			txtUnit.TabIndex = 7;
			// 
			// txtProductName
			// 
			txtProductName.Location = new Point(250, 40);
			txtProductName.Name = "txtProductName";
			txtProductName.Size = new Size(372, 27);
			txtProductName.TabIndex = 6;
			// 
			// lblCategory
			// 
			lblCategory.AutoSize = true;
			lblCategory.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblCategory.ForeColor = SystemColors.ControlLightLight;
			lblCategory.Location = new Point(50, 293);
			lblCategory.Name = "lblCategory";
			lblCategory.Size = new Size(103, 31);
			lblCategory.TabIndex = 5;
			lblCategory.Text = "Kategori";
			// 
			// lblPrice
			// 
			lblPrice.AutoSize = true;
			lblPrice.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblPrice.ForeColor = SystemColors.ControlLightLight;
			lblPrice.Location = new Point(50, 208);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(64, 31);
			lblPrice.TabIndex = 4;
			lblPrice.Text = "Fiyat";
			// 
			// lblUnit
			// 
			lblUnit.AutoSize = true;
			lblUnit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblUnit.ForeColor = SystemColors.ControlLightLight;
			lblUnit.Location = new Point(50, 119);
			lblUnit.Name = "lblUnit";
			lblUnit.Size = new Size(63, 31);
			lblUnit.TabIndex = 3;
			lblUnit.Text = "Adet";
			// 
			// lblProductName
			// 
			lblProductName.AutoSize = true;
			lblProductName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblProductName.ForeColor = SystemColors.ControlLightLight;
			lblProductName.Location = new Point(50, 40);
			lblProductName.Name = "lblProductName";
			lblProductName.Size = new Size(114, 31);
			lblProductName.TabIndex = 2;
			lblProductName.Text = "Ürün İsmi\r\n";
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(27, 156, 252);
			panel1.Controls.Add(lblProductUpdate);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(11, -5);
			panel1.Name = "panel1";
			panel1.Size = new Size(1392, 230);
			panel1.TabIndex = 6;
			// 
			// lblProductUpdate
			// 
			lblProductUpdate.AutoSize = true;
			lblProductUpdate.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblProductUpdate.ForeColor = SystemColors.ButtonHighlight;
			lblProductUpdate.Location = new Point(438, 90);
			lblProductUpdate.Name = "lblProductUpdate";
			lblProductUpdate.Size = new Size(417, 46);
			lblProductUpdate.TabIndex = 1;
			lblProductUpdate.Text = "Ürün Güncelleme Sayfası";
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
			// txtProductId
			// 
			txtProductId.Location = new Point(882, 157);
			txtProductId.Name = "txtProductId";
			txtProductId.Size = new Size(372, 27);
			txtProductId.TabIndex = 12;
			// 
			// lblProductId
			// 
			lblProductId.AutoSize = true;
			lblProductId.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblProductId.ForeColor = SystemColors.ControlLightLight;
			lblProductId.Location = new Point(733, 157);
			lblProductId.Name = "lblProductId";
			lblProductId.Size = new Size(95, 31);
			lblProductId.TabIndex = 11;
			lblProductId.Text = "Ürün ID";
			// 
			// FrmUpdateProduct
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1414, 735);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "FrmUpdateProduct";
			Text = "FrmUpdateProduct";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private Button btnUpdate;
		private TextBox txtCategory;
		private TextBox txtPrice;
		private TextBox txtUnit;
		private TextBox txtProductName;
		private Label lblCategory;
		private Label lblPrice;
		private Label lblUnit;
		private Label lblProductName;
		private Panel panel1;
		private Label lblProductUpdate;
		private Label label1;
		private TextBox txtProductId;
		private Label lblProductId;
	}
}