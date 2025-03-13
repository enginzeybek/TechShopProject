using TechShopProject.DTOs.CustomerDTOs;
using TechShopProject.DTOs.OrderDTOs;
using TechShopProject.DTOs.ProductDTOs;
using TechShopProject.Forms.CustomerForms;
using TechShopProject.Forms.OrderForms;
using TechShopProject.Forms.ProductForms;
using TechShopProject.Services;

namespace TechShopProject
{
	public partial class MainPage : Form
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void BtnCustomerList_Click(object sender, EventArgs e)
		{
			CustomerOperation customerOperation = new CustomerOperation();

			var value = customerOperation.CustomerList();

			dataGridView1.DataSource = value;
		}

		private void btnAddCustomer_Click(object sender, EventArgs e)
		{
			FrmAddCustomer frmAddCustomer = new FrmAddCustomer();

			frmAddCustomer.ShowDialog();
		}

		private void btnCustomerUpdate_Click(object sender, EventArgs e)
		{
			FrmUpdateCustomer frmUpdateCustomer = new FrmUpdateCustomer();

			frmUpdateCustomer.ShowDialog();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count > 0)
			{
				string id = dataGridView1.SelectedRows[0].Cells["CustomerId"].Value.ToString();

				CustomerOperation customerOperation = new CustomerOperation();

				customerOperation.DeleteCustomer(id);
			}


		}

		private void btnGetByIdCustomer_Click(object sender, EventArgs e)
		{
			string id = txtGetByIdCustomer.Text;

			CustomerOperation customerOperation = new CustomerOperation();

			GetCustomerDto getCustomerDto = customerOperation.GetCustomer(id);

			dataGridView1.DataSource = new List<GetCustomerDto> { getCustomerDto };
		}

		private void btnOrderList_Click(object sender, EventArgs e)
		{
			OrderOperation orderOperation = new OrderOperation();

			var value = orderOperation.OrderList();

			dataGridView1.DataSource = value;
		}

		private void btnOrderAdd_Click(object sender, EventArgs e)
		{
			FrmAddOrder frmAddOrder = new FrmAddOrder();

			frmAddOrder.ShowDialog();
		}

		private void btnOrderUpdate_Click(object sender, EventArgs e)
		{
			FrmUpdateOrder frmUpdateOrder = new FrmUpdateOrder();

			frmUpdateOrder.ShowDialog();
		}

		private void btnOrderDelete_Click(object sender, EventArgs e)
		{
			string id = dataGridView1.SelectedRows[0].Cells["OrderId"].Value.ToString();

			OrderOperation orderOperation = new OrderOperation();

			orderOperation.DeleteOrder(id);
		}

		private void btnGetByIdOrder_Click(object sender, EventArgs e)
		{
			string id = txtGetByIdOrder.Text;

			OrderOperation orderOperation = new OrderOperation();

			GetOrderDto getOrderDto = orderOperation.GetOrder(id);

			dataGridView1.DataSource = new List<GetOrderDto> { getOrderDto };
		}

		private void btnProductList_Click(object sender, EventArgs e)
		{
			ProductOperation productOperation = new ProductOperation();

			dataGridView1.DataSource = productOperation.ProductList();
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			FrmAddProduct frmAddProduct = new FrmAddProduct();

			frmAddProduct.ShowDialog();
		}

		private void btnUpdateProduct_Click(object sender, EventArgs e)
		{
			FrmUpdateProduct frmUpdateProduct = new FrmUpdateProduct();

			frmUpdateProduct.ShowDialog();
		}

		private void btnDeleteProduct_Click(object sender, EventArgs e)
		{
			string id = dataGridView1.SelectedRows[0].Cells["ProductId"].Value.ToString();

			ProductOperation productOperation = new ProductOperation();

			productOperation.DeleteProduct(id);
		}

		private void btnGetByIdProduct_Click(object sender, EventArgs e)
		{
			string id = txtGetByIdProduct.Text;

			ProductOperation productOperation = new ProductOperation();

			GetProductDto getProductDto = productOperation.GetProduct(id);

			dataGridView1.DataSource = new List<GetProductDto> { getProductDto };
		}
	}
}
