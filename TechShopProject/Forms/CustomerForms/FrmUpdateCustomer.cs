using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechShopProject.DTOs.CustomerDTOs;
using TechShopProject.Services;

namespace TechShopProject.Forms.CustomerForms
{
	public partial class FrmUpdateCustomer : Form
	{
		public FrmUpdateCustomer()
		{
			InitializeComponent();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string id = txtCustomerId.Text;

			UpdateCustomerDto updateCustomerDto = new UpdateCustomerDto();

			updateCustomerDto.CustomerId = id;

			updateCustomerDto.Email = txtCustomerEmail.Text;

			updateCustomerDto.Phone = txtCustomerPhone.Text;

			updateCustomerDto.FirstName = txtCustomerName.Text;

			updateCustomerDto.LastName = txtCustomerSurname.Text;

			CustomerOperation customerOperation = new CustomerOperation();

			customerOperation.UpdateCustomer(updateCustomerDto);
		}
	}
}
