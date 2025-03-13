using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using TechShopProject.DTOs.OrderDTOs;

namespace TechShopProject.Services
{
    public class OrderOperation
    {
        public List<ResultOrderDto> OrderList()
        {
            MongoDbConnection dbConnection = new MongoDbConnection();
            var orderCollection = dbConnection.GetOrderCollection();

            var order = orderCollection.Find(new BsonDocument()).ToList();

            List<ResultOrderDto> OrderList = new List<ResultOrderDto>();

			foreach (var item in order)
			{
                OrderList.Add(new ResultOrderDto
                {
                    CustomerName = item["CustomerName"].ToString(),
                    OrderDate = Convert.ToDateTime(item["OrderDate"].ToString()),
                    OrderId = item["_id"].ToString(),
                    ProductName = item["ProductName"].ToString(),
                    Quantity = Convert.ToInt16(item["Quantity"].ToString()),
                    TotalPrice = Convert.ToInt32(item["TotalPrice"].ToString())
                });
			}

            return OrderList;
		}

        public void CreateOrder(CreateOrderDto createOrderDto)
        {
			MongoDbConnection dbConnection = new MongoDbConnection();
			var orderCollection = dbConnection.GetOrderCollection();

            var document = new BsonDocument
            {
                {"CustomerName",createOrderDto.CustomerName },
                {"OrderDate",createOrderDto.OrderDate },
                {"ProductName",createOrderDto.ProductName },
                {"Quantity",createOrderDto.Quantity },
                {"TotalPrice",createOrderDto.TotalPrice }
            };

            orderCollection.InsertOne(document);

            MessageBox.Show("SİPARİŞ EKLENDİ");
		}

        public void UpdateOrder(UpdateOrderDto updateOrderDto)
        {
			MongoDbConnection dbConnection = new MongoDbConnection();
			var orderCollection = dbConnection.GetOrderCollection();

            var updatedOrder = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(updateOrderDto.OrderId));
            var value = Builders<BsonDocument>.Update
                .Set("CustomerName", updateOrderDto.CustomerName)
                .Set("OrderDate", updateOrderDto.OrderDate)
                .Set("ProductName", updateOrderDto.ProductName)
                .Set("Quantity", updateOrderDto.Quantity)
                .Set("TotalPrice", updateOrderDto.TotalPrice);

            orderCollection.UpdateOne(updatedOrder, value);

            MessageBox.Show("SİPARİŞ GÜNCELLENDİ");

		}

        public void DeleteOrder(string id)
        {
			MongoDbConnection dbConnection = new MongoDbConnection();
			var orderCollection = dbConnection.GetOrderCollection();

            var deletedOrder = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            orderCollection.DeleteOne(deletedOrder);

            MessageBox.Show("SİPARİŞ SİLİNDİ");
		}

        public GetOrderDto GetOrder(string id)
        {
			MongoDbConnection dbConnection = new MongoDbConnection();
			var orderCollection = dbConnection.GetOrderCollection();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var value = orderCollection.Find(filter).FirstOrDefault();

            return new GetOrderDto
            {
                CustomerName = value["CustomerName"].ToString(),
                OrderDate = Convert.ToDateTime(value["OrderDate"].ToString()),
                OrderId = value["_id"].ToString(),
                ProductName = value["ProductName"].ToString(),
                Quantity = Convert.ToInt32(value["Quantity"].ToString()),
                TotalPrice = Convert.ToInt32(value["TotalPrice"].ToString()),
			};
            
		}
    }
}
