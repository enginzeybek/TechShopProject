namespace TechShopProject
{
    partial class MainPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			dataGridView1 = new DataGridView();
			BtnCustomerList = new Button();
			panel2 = new Panel();
			lblMainPage = new Label();
			btnAddCustomer = new Button();
			btnCustomerUpdate = new Button();
			btnDelete = new Button();
			btnGetByIdCustomer = new Button();
			txtGetByIdCustomer = new TextBox();
			btnOrderList = new Button();
			btnOrderAdd = new Button();
			btnOrderUpdate = new Button();
			btnOrderDelete = new Button();
			btnGetByIdOrder = new Button();
			txtGetByIdOrder = new TextBox();
			txtGetByIdProduct = new TextBox();
			btnGetByIdProduct = new Button();
			btnDeleteProduct = new Button();
			btnUpdateProduct = new Button();
			btnAddProduct = new Button();
			btnProductList = new Button();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(44, 58, 71);
			panel1.Controls.Add(dataGridView1);
			panel1.Location = new Point(806, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(590, 745);
			panel1.TabIndex = 0;
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(3, 3);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowHeadersWidth = 51;
			dataGridView1.Size = new Size(584, 734);
			dataGridView1.TabIndex = 1;
			// 
			// BtnCustomerList
			// 
			BtnCustomerList.BackColor = Color.FromArgb(205, 132, 241);
			BtnCustomerList.Location = new Point(12, 175);
			BtnCustomerList.Name = "BtnCustomerList";
			BtnCustomerList.Size = new Size(195, 45);
			BtnCustomerList.TabIndex = 2;
			BtnCustomerList.Text = "Müşteri Listele";
			BtnCustomerList.UseVisualStyleBackColor = false;
			BtnCustomerList.Click += BtnCustomerList_Click;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(248, 239, 186);
			panel2.Controls.Add(lblMainPage);
			panel2.Location = new Point(2, 0);
			panel2.Name = "panel2";
			panel2.Size = new Size(801, 137);
			panel2.TabIndex = 3;
			// 
			// lblMainPage
			// 
			lblMainPage.AutoSize = true;
			lblMainPage.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
			lblMainPage.ForeColor = Color.FromArgb(252, 66, 123);
			lblMainPage.Location = new Point(248, 36);
			lblMainPage.Name = "lblMainPage";
			lblMainPage.Size = new Size(211, 54);
			lblMainPage.TabIndex = 4;
			lblMainPage.Text = "Ana Sayfa";
			// 
			// btnAddCustomer
			// 
			btnAddCustomer.BackColor = Color.FromArgb(255, 204, 204);
			btnAddCustomer.Location = new Point(12, 254);
			btnAddCustomer.Name = "btnAddCustomer";
			btnAddCustomer.Size = new Size(195, 45);
			btnAddCustomer.TabIndex = 4;
			btnAddCustomer.Text = "Müşteri Ekle";
			btnAddCustomer.UseVisualStyleBackColor = false;
			btnAddCustomer.Click += btnAddCustomer_Click;
			// 
			// btnCustomerUpdate
			// 
			btnCustomerUpdate.BackColor = Color.FromArgb(255, 159, 26);
			btnCustomerUpdate.Location = new Point(12, 335);
			btnCustomerUpdate.Name = "btnCustomerUpdate";
			btnCustomerUpdate.Size = new Size(195, 45);
			btnCustomerUpdate.TabIndex = 5;
			btnCustomerUpdate.Text = "Müşteri Güncelle";
			btnCustomerUpdate.UseVisualStyleBackColor = false;
			btnCustomerUpdate.Click += btnCustomerUpdate_Click;
			// 
			// btnDelete
			// 
			btnDelete.BackColor = Color.FromArgb(245, 59, 87);
			btnDelete.Location = new Point(12, 422);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(195, 45);
			btnDelete.TabIndex = 6;
			btnDelete.Text = "Müşteri Sil";
			btnDelete.UseVisualStyleBackColor = false;
			btnDelete.Click += btnDelete_Click;
			// 
			// btnGetByIdCustomer
			// 
			btnGetByIdCustomer.BackColor = Color.FromArgb(255, 221, 89);
			btnGetByIdCustomer.Location = new Point(12, 502);
			btnGetByIdCustomer.Name = "btnGetByIdCustomer";
			btnGetByIdCustomer.Size = new Size(195, 45);
			btnGetByIdCustomer.TabIndex = 7;
			btnGetByIdCustomer.Text = "Müşteriyi ID'ye göre getir";
			btnGetByIdCustomer.UseVisualStyleBackColor = false;
			btnGetByIdCustomer.Click += btnGetByIdCustomer_Click;
			// 
			// txtGetByIdCustomer
			// 
			txtGetByIdCustomer.Location = new Point(12, 588);
			txtGetByIdCustomer.Name = "txtGetByIdCustomer";
			txtGetByIdCustomer.Size = new Size(195, 27);
			txtGetByIdCustomer.TabIndex = 8;
			// 
			// btnOrderList
			// 
			btnOrderList.BackColor = Color.FromArgb(120, 224, 143);
			btnOrderList.Location = new Point(266, 175);
			btnOrderList.Name = "btnOrderList";
			btnOrderList.Size = new Size(195, 45);
			btnOrderList.TabIndex = 9;
			btnOrderList.Text = "Sipariş Listele";
			btnOrderList.UseVisualStyleBackColor = false;
			btnOrderList.Click += btnOrderList_Click;
			// 
			// btnOrderAdd
			// 
			btnOrderAdd.BackColor = Color.FromArgb(229, 80, 57);
			btnOrderAdd.Location = new Point(266, 254);
			btnOrderAdd.Name = "btnOrderAdd";
			btnOrderAdd.Size = new Size(195, 45);
			btnOrderAdd.TabIndex = 10;
			btnOrderAdd.Text = "Sipariş Ekle";
			btnOrderAdd.UseVisualStyleBackColor = false;
			btnOrderAdd.Click += btnOrderAdd_Click;
			// 
			// btnOrderUpdate
			// 
			btnOrderUpdate.BackColor = Color.FromArgb(246, 185, 59);
			btnOrderUpdate.Location = new Point(266, 335);
			btnOrderUpdate.Name = "btnOrderUpdate";
			btnOrderUpdate.Size = new Size(195, 45);
			btnOrderUpdate.TabIndex = 11;
			btnOrderUpdate.Text = "Sipariş Güncelle";
			btnOrderUpdate.UseVisualStyleBackColor = false;
			btnOrderUpdate.Click += btnOrderUpdate_Click;
			// 
			// btnOrderDelete
			// 
			btnOrderDelete.BackColor = Color.FromArgb(106, 137, 204);
			btnOrderDelete.Location = new Point(266, 422);
			btnOrderDelete.Name = "btnOrderDelete";
			btnOrderDelete.Size = new Size(195, 45);
			btnOrderDelete.TabIndex = 12;
			btnOrderDelete.Text = "Sipariş Sil";
			btnOrderDelete.UseVisualStyleBackColor = false;
			btnOrderDelete.Click += btnOrderDelete_Click;
			// 
			// btnGetByIdOrder
			// 
			btnGetByIdOrder.BackColor = Color.FromArgb(130, 204, 221);
			btnGetByIdOrder.Location = new Point(266, 502);
			btnGetByIdOrder.Name = "btnGetByIdOrder";
			btnGetByIdOrder.Size = new Size(195, 45);
			btnGetByIdOrder.TabIndex = 13;
			btnGetByIdOrder.Text = "Sipariş ID'ye göre getir";
			btnGetByIdOrder.UseVisualStyleBackColor = false;
			btnGetByIdOrder.Click += btnGetByIdOrder_Click;
			// 
			// txtGetByIdOrder
			// 
			txtGetByIdOrder.Location = new Point(266, 588);
			txtGetByIdOrder.Name = "txtGetByIdOrder";
			txtGetByIdOrder.Size = new Size(195, 27);
			txtGetByIdOrder.TabIndex = 14;
			// 
			// txtGetByIdProduct
			// 
			txtGetByIdProduct.Location = new Point(542, 588);
			txtGetByIdProduct.Name = "txtGetByIdProduct";
			txtGetByIdProduct.Size = new Size(195, 27);
			txtGetByIdProduct.TabIndex = 20;
			// 
			// btnGetByIdProduct
			// 
			btnGetByIdProduct.BackColor = Color.FromArgb(248, 239, 186);
			btnGetByIdProduct.Location = new Point(542, 502);
			btnGetByIdProduct.Name = "btnGetByIdProduct";
			btnGetByIdProduct.Size = new Size(195, 45);
			btnGetByIdProduct.TabIndex = 19;
			btnGetByIdProduct.Text = "Ürün ID'ye göre getir";
			btnGetByIdProduct.UseVisualStyleBackColor = false;
			btnGetByIdProduct.Click += btnGetByIdProduct_Click;
			// 
			// btnDeleteProduct
			// 
			btnDeleteProduct.BackColor = Color.FromArgb(59, 59, 152);
			btnDeleteProduct.Location = new Point(542, 422);
			btnDeleteProduct.Name = "btnDeleteProduct";
			btnDeleteProduct.Size = new Size(195, 45);
			btnDeleteProduct.TabIndex = 18;
			btnDeleteProduct.Text = "Ürün Sil";
			btnDeleteProduct.UseVisualStyleBackColor = false;
			btnDeleteProduct.Click += btnDeleteProduct_Click;
			// 
			// btnUpdateProduct
			// 
			btnUpdateProduct.BackColor = Color.FromArgb(252, 66, 123);
			btnUpdateProduct.Location = new Point(542, 335);
			btnUpdateProduct.Name = "btnUpdateProduct";
			btnUpdateProduct.Size = new Size(195, 45);
			btnUpdateProduct.TabIndex = 17;
			btnUpdateProduct.Text = "Ürün Güncelle";
			btnUpdateProduct.UseVisualStyleBackColor = false;
			btnUpdateProduct.Click += btnUpdateProduct_Click;
			// 
			// btnAddProduct
			// 
			btnAddProduct.BackColor = Color.FromArgb(179, 55, 113);
			btnAddProduct.Location = new Point(542, 254);
			btnAddProduct.Name = "btnAddProduct";
			btnAddProduct.Size = new Size(195, 45);
			btnAddProduct.TabIndex = 16;
			btnAddProduct.Text = "Ürün Ekle";
			btnAddProduct.UseVisualStyleBackColor = false;
			btnAddProduct.Click += btnAddProduct_Click;
			// 
			// btnProductList
			// 
			btnProductList.BackColor = Color.FromArgb(249, 127, 81);
			btnProductList.Location = new Point(542, 175);
			btnProductList.Name = "btnProductList";
			btnProductList.Size = new Size(195, 45);
			btnProductList.TabIndex = 15;
			btnProductList.Text = "Ürün Listele";
			btnProductList.UseVisualStyleBackColor = false;
			btnProductList.Click += btnProductList_Click;
			// 
			// MainPage
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1400, 749);
			Controls.Add(txtGetByIdProduct);
			Controls.Add(btnGetByIdProduct);
			Controls.Add(btnDeleteProduct);
			Controls.Add(btnUpdateProduct);
			Controls.Add(btnAddProduct);
			Controls.Add(btnProductList);
			Controls.Add(txtGetByIdOrder);
			Controls.Add(btnGetByIdOrder);
			Controls.Add(btnOrderDelete);
			Controls.Add(btnOrderUpdate);
			Controls.Add(btnOrderAdd);
			Controls.Add(btnOrderList);
			Controls.Add(txtGetByIdCustomer);
			Controls.Add(btnGetByIdCustomer);
			Controls.Add(btnDelete);
			Controls.Add(btnCustomerUpdate);
			Controls.Add(btnAddCustomer);
			Controls.Add(panel2);
			Controls.Add(BtnCustomerList);
			Controls.Add(panel1);
			Name = "MainPage";
			Text = "Ana Sayfa";
			panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private DataGridView dataGridView1;
		private Button BtnCustomerList;
		private Panel panel2;
		private Label lblMainPage;
		private Button btnAddCustomer;
		private Button btnCustomerUpdate;
		private Button btnDelete;
		private Button btnGetByIdCustomer;
		private TextBox txtGetByIdCustomer;
		private Button btnOrderList;
		private Button btnOrderAdd;
		private Button btnOrderUpdate;
		private Button btnOrderDelete;
		private Button btnGetByIdOrder;
		private TextBox txtGetByIdOrder;
		private TextBox txtGetByIdProduct;
		private Button btnGetByIdProduct;
		private Button btnDeleteProduct;
		private Button btnUpdateProduct;
		private Button btnAddProduct;
		private Button btnProductList;
	}
}
