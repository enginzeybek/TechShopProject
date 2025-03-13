using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechShopProject.Services
{
    public class MongoDbConnection
    {
        private IMongoDatabase _mongoDatabase;

		public MongoDbConnection()
		{
			var client = new MongoClient("mongodb://localhost:27017");

			_mongoDatabase = client.GetDatabase("ShopDatabase");
		}

		public IMongoCollection<BsonDocument> GetCustomerCollection()
		{
			return _mongoDatabase.GetCollection<BsonDocument>("Customers");
		}

		public IMongoCollection<BsonDocument> GetOrderCollection()
		{
			return _mongoDatabase.GetCollection<BsonDocument>("Orders");
		}

		public IMongoCollection<BsonDocument> GetProductCollection()
		{
			return _mongoDatabase.GetCollection<BsonDocument>("Products");
		}
	}
}
