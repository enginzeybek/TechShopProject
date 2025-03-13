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
	public partial class FrmUpdateProduct : Form
	{
		public FrmUpdateProduct()
		{
			InitializeComponent();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			UpdateProductDto updateProductDto = new UpdateProductDto();

			updateProductDto.Unit = Convert.ToInt32(txtUnit.Text);
			updateProductDto.Price = Convert.ToInt32(txtPrice.Text);
			updateProductDto.Category = txtCategory.Text;
			updateProductDto.ProductName = txtProductName.Text;
			updateProductDto.ProductId = txtProductId.Text;

			ProductOperation productOperation = new ProductOperation();

			productOperation.UpdateProduct(updateProductDto);
		}
	}
}
