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
	public partial class FrmAddCustomer : Form
	{
		public FrmAddCustomer()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			CreateCustomerDto createCustomerDto = new CreateCustomerDto();

			createCustomerDto.FirstName = txtCustomerName.Text;

			createCustomerDto.LastName = txtCustomerSurname.Text;

			createCustomerDto.Email = txtCustomerEmail.Text;

			createCustomerDto.Phone = txtCustomerPhone.Text;

			CustomerOperation customerOperation = new CustomerOperation();

			customerOperation.AddCustomer(createCustomerDto);
		}
	}
}
