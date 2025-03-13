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
	public partial class FrmUpdateOrder : Form
	{
		public FrmUpdateOrder()
		{
			InitializeComponent();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			UpdateOrderDto updateOrderDto = new UpdateOrderDto
			{
				CustomerName = txtCustomerName.Text,
				OrderDate = Convert.ToDateTime(txtOrderDate.Text),
				OrderId = txtOrderId.Text,
				ProductName = txtProductName.Text,
				Quantity = Convert.ToInt32(txtQuantity.Text),
				TotalPrice = Convert.ToInt32(txtTotalPrice.Text)
			};

			OrderOperation orderOperation = new OrderOperation();

			orderOperation.UpdateOrder(updateOrderDto);
		}
	}
}
