﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShopProject.DTOs.ProductDTOs
{
    public class UpdateProductDto
    {
		public string ProductId { get; set; }
		public string ProductName { get; set; }

		public int Unit { get; set; }

		public int Price { get; set; }

		public string Category { get; set; }
	}
}
