using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShopProject.DTOs.OrderDTOs
{
    public class ResultOrderDto
    {
		public string OrderId { get; set; }
		public string CustomerName { get; set; }
		public string ProductName { get; set; }
		public int Quantity { get; set; }
		public int TotalPrice { get; set; }
		public DateTime OrderDate { get; set; }
	}
}
