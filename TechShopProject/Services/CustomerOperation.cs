using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShopProject.DTOs.CustomerDTOs;

namespace TechShopProject.Services
{
    public class CustomerOperation
    {
        public List<ResultCustomerDto> CustomerList()
        {
            MongoDbConnection dbConnection = new MongoDbConnection();
            var customerCollection = dbConnection.GetCustomerCollection();

            var customer = customerCollection.Find(new BsonDocument()).ToList();

            List<ResultCustomerDto> CustomerList = new List<ResultCustomerDto>();

			foreach (var item in customer)
			{
                CustomerList.Add(new ResultCustomerDto
                {
                    Email = item["Email"].ToString(),
                    FirstName = item["FirstName"].ToString(),
                    LastName = item["LastName"].ToString(),
                    Phone = item["Phone"].ToString(),
                    CustomerId = item["_id"].ToString()
                });
			}

			return CustomerList;
		}

        public void AddCustomer(CreateCustomerDto createCustomerDto)
        {
			MongoDbConnection dbConnection = new MongoDbConnection();
			var customerCollection = dbConnection.GetCustomerCollection();

            var document = new BsonDocument
            {
                {"FirstName",createCustomerDto.FirstName },
                {"LastName",createCustomerDto.LastName },
                {"Email",createCustomerDto.Email },
                {"Phone",createCustomerDto.Phone }
            };

            customerCollection.InsertOne(document);

            MessageBox.Show("MÜŞTERİ EKLENDİ");
		}

        public void UpdateCustomer(UpdateCustomerDto updateCustomerDto)
        {
			MongoDbConnection dbConnection = new MongoDbConnection();
			var customerCollection = dbConnection.GetCustomerCollection();

            var updatedCustomer = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(updateCustomerDto.CustomerId));
            var value = Builders<BsonDocument>.Update
                .Set("FirstName", updateCustomerDto.FirstName)
                .Set("LastName", updateCustomerDto.LastName)
                .Set("Email", updateCustomerDto.Email)
                .Set("Phone", updateCustomerDto.Phone);

            customerCollection.UpdateOne(updatedCustomer, value);

            MessageBox.Show("MÜŞTERİ GÜNCELLENDİ");
            
		}

        public void DeleteCustomer(string id)
        {
			MongoDbConnection dbConnection = new MongoDbConnection();
			var customerCollection = dbConnection.GetCustomerCollection();

            var value = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));

            customerCollection.DeleteOne(value);

            MessageBox.Show("MÜŞTERİ SİLİNDİ");
		}

        public GetCustomerDto GetCustomer(string id)
        {
			MongoDbConnection dbConnection = new MongoDbConnection();
			var customerCollection = dbConnection.GetCustomerCollection();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var value = customerCollection.Find(filter).FirstOrDefault();

            return new GetCustomerDto
            {
                CustomerId = value["_id"].ToString(),
                Email = value["Email"].ToString(),
                FirstName = value["FirstName"].ToString(),
                LastName = value["LastName"].ToString(),
                Phone = value["Phone"].ToString()
            };
            
		}
    }
}
