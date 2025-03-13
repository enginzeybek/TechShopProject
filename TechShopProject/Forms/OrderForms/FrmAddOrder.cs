using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechShopProject.DTOs.OrderDTOs;
using TechShopProject.Services;

namespace TechShopProject.Forms.OrderForms
{
	public partial class FrmAddOrder : Form
	{
		public FrmAddOrder()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			CreateOrderDto createOrderDto = new CreateOrderDto();

			createOrderDto.ProductName = txtProductName.Text;

			createOrderDto.CustomerName = txtCustomerName.Text;

			createOrderDto.OrderDate = Convert.ToDateTime(txtOrderDate.Text);

			createOrderDto.Quantity = Convert.ToInt32(txtQuantity.Text);

			createOrderDto.TotalPrice = Convert.ToInt32(txtTotalPrice.Text);

			OrderOperation orderOperation = new OrderOperation();

			orderOperation.CreateOrder(createOrderDto);
		}
	}
}
