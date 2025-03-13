namespace TechShopProject.Forms.CustomerForms
{
	partial class FrmUpdateCustomer
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
			txtCustomerId = new TextBox();
			lblCustomerId = new Label();
			btnUpdate = new Button();
			txtCustomerPhone = new TextBox();
			txtCustomerEmail = new TextBox();
			txtCustomerSurname = new TextBox();
			txtCustomerName = new TextBox();
			lblCustomerTelefon = new Label();
			lblCustomerEmail = new Label();
			lblCustomerSurname = new Label();
			lblCustomerName = new Label();
			panel1 = new Panel();
			lblCustomerUpdate = new Label();
			label1 = new Label();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(24, 220, 255);
			panel2.Controls.Add(txtCustomerId);
			panel2.Controls.Add(lblCustomerId);
			panel2.Controls.Add(btnUpdate);
			panel2.Controls.Add(txtCustomerPhone);
			panel2.Controls.Add(txtCustomerEmail);
			panel2.Controls.Add(txtCustomerSurname);
			panel2.Controls.Add(txtCustomerName);
			panel2.Controls.Add(lblCustomerTelefon);
			panel2.Controls.Add(lblCustomerEmail);
			panel2.Controls.Add(lblCustomerSurname);
			panel2.Controls.Add(lblCustomerName);
			panel2.Location = new Point(10, 233);
			panel2.Name = "panel2";
			panel2.Size = new Size(1392, 508);
			panel2.TabIndex = 3;
			// 
			// txtCustomerId
			// 
			txtCustomerId.Location = new Point(858, 145);
			txtCustomerId.Name = "txtCustomerId";
			txtCustomerId.Size = new Size(372, 27);
			txtCustomerId.TabIndex = 12;
			// 
			// lblCustomerId
			// 
			lblCustomerId.AutoSize = true;
			lblCustomerId.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblCustomerId.ForeColor = SystemColors.InactiveCaptionText;
			lblCustomerId.Location = new Point(691, 145);
			lblCustomerId.Name = "lblCustomerId";
			lblCustomerId.Size = new Size(120, 31);
			lblCustomerId.TabIndex = 11;
			lblCustomerId.Text = "Müşteri Id";
			// 
			// btnUpdate
			// 
			btnUpdate.BackColor = Color.FromArgb(255, 56, 56);
			btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			btnUpdate.Location = new Point(282, 397);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(194, 48);
			btnUpdate.TabIndex = 10;
			btnUpdate.Text = "Güncelle";
			btnUpdate.UseVisualStyleBackColor = false;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// txtCustomerPhone
			// 
			txtCustomerPhone.Location = new Point(250, 293);
			txtCustomerPhone.Name = "txtCustomerPhone";
			txtCustomerPhone.Size = new Size(372, 27);
			txtCustomerPhone.TabIndex = 9;
			// 
			// txtCustomerEmail
			// 
			txtCustomerEmail.Location = new Point(250, 208);
			txtCustomerEmail.Name = "txtCustomerEmail";
			txtCustomerEmail.Size = new Size(372, 27);
			txtCustomerEmail.TabIndex = 8;
			// 
			// txtCustomerSurname
			// 
			txtCustomerSurname.Location = new Point(250, 119);
			txtCustomerSurname.Name = "txtCustomerSurname";
			txtCustomerSurname.Size = new Size(372, 27);
			txtCustomerSurname.TabIndex = 7;
			// 
			// txtCustomerName
			// 
			txtCustomerName.Location = new Point(250, 40);
			txtCustomerName.Name = "txtCustomerName";
			txtCustomerName.Size = new Size(372, 27);
			txtCustomerName.TabIndex = 6;
			// 
			// lblCustomerTelefon
			// 
			lblCustomerTelefon.AutoSize = true;
			lblCustomerTelefon.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblCustomerTelefon.ForeColor = SystemColors.InactiveCaptionText;
			lblCustomerTelefon.Location = new Point(50, 293);
			lblCustomerTelefon.Name = "lblCustomerTelefon";
			lblCustomerTelefon.Size = new Size(175, 31);
			lblCustomerTelefon.TabIndex = 5;
			lblCustomerTelefon.Text = "Müşteri Telefon\r\n";
			// 
			// lblCustomerEmail
			// 
			lblCustomerEmail.AutoSize = true;
			lblCustomerEmail.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblCustomerEmail.ForeColor = SystemColors.InactiveCaptionText;
			lblCustomerEmail.Location = new Point(50, 208);
			lblCustomerEmail.Name = "lblCustomerEmail";
			lblCustomerEmail.Size = new Size(155, 31);
			lblCustomerEmail.TabIndex = 4;
			lblCustomerEmail.Text = "Müşteri Email";
			// 
			// lblCustomerSurname
			// 
			lblCustomerSurname.AutoSize = true;
			lblCustomerSurname.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblCustomerSurname.ForeColor = SystemColors.InactiveCaptionText;
			lblCustomerSurname.Location = new Point(50, 119);
			lblCustomerSurname.Name = "lblCustomerSurname";
			lblCustomerSurname.Size = new Size(170, 31);
			lblCustomerSurname.TabIndex = 3;
			lblCustomerSurname.Text = "Müşteri Soyadı";
			// 
			// lblCustomerName
			// 
			lblCustomerName.AutoSize = true;
			lblCustomerName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
			lblCustomerName.ForeColor = SystemColors.InactiveCaptionText;
			lblCustomerName.Location = new Point(50, 40);
			lblCustomerName.Name = "lblCustomerName";
			lblCustomerName.Size = new Size(142, 31);
			lblCustomerName.TabIndex = 2;
			lblCustomerName.Text = "Müşteri İsmi\r\n";
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(75, 75, 75);
			panel1.Controls.Add(lblCustomerUpdate);
			panel1.Controls.Add(label1);
			panel1.Location = new Point(10, -3);
			panel1.Name = "panel1";
			panel1.Size = new Size(1392, 230);
			panel1.TabIndex = 2;
			// 
			// lblCustomerUpdate
			// 
			lblCustomerUpdate.AutoSize = true;
			lblCustomerUpdate.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblCustomerUpdate.ForeColor = SystemColors.ButtonHighlight;
			lblCustomerUpdate.Location = new Point(438, 90);
			lblCustomerUpdate.Name = "lblCustomerUpdate";
			lblCustomerUpdate.Size = new Size(460, 46);
			lblCustomerUpdate.TabIndex = 1;
			lblCustomerUpdate.Text = "Müşteri Güncelleme Sayfası";
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
			// FrmUpdateCustomer
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1412, 739);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Name = "FrmUpdateCustomer";
			Text = "FrmUpdateCustomer";
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel2;
		private TextBox txtCustomerId;
		private Label lblCustomerId;
		private Button btnUpdate;
		private TextBox txtCustomerPhone;
		private TextBox txtCustomerEmail;
		private TextBox txtCustomerSurname;
		private TextBox txtCustomerName;
		private Label lblCustomerTelefon;
		private Label lblCustomerEmail;
		private Label lblCustomerSurname;
		private Label lblCustomerName;
		private Panel panel1;
		private Label lblCustomerUpdate;
		private Label label1;
	}
}