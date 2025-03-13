using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShopProject.DTOs.CustomerDTOs
{
    public class GetCustomerDto
    {
		[BsonId]
		[BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
		public string CustomerId { get; set; }
		public string FirstName { get; set; }

		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
	}
}
