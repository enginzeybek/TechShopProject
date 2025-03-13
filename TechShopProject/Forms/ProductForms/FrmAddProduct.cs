using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechShopProject.DTOs.ProductDTOs;
using TechShopProject.Services;

namespace TechShopProject.Forms.ProductForms
{
	public partial class FrmAddProduct : Form
	{
		public FrmAddProduct()
		{
			InitializeComponent();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			CreateProductDto createProductDto = new CreateProductDto();

			createProductDto.ProductName = txtProductName.Text;
			createProductDto.Price = Convert.ToInt32(txtPrice.Text);
			createProductDto.Unit = Convert.ToInt32(txtUnit.Text);
			createProductDto.Category = txtCategory.Text;

			ProductOperation productOperation = new ProductOperation();

			productOperation.CreateProduct(createProductDto);
		}
	}
}
