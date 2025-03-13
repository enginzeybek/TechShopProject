using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechShopProject.DTOs.ProductDTOs;

namespace TechShopProject.Services
{
    public class ProductOperation
    {
        public List<ResultProductDto> ProductList()
        {
            MongoDbConnection mongoDbConnection = new MongoDbConnection();
            var productCollection = mongoDbConnection.GetProductCollection();

            var product = productCollection.Find(new BsonDocument()).ToList();

            List<ResultProductDto> productList = new List<ResultProductDto>();

			foreach (var item in product)
			{
                productList.Add(new ResultProductDto
                {
                    Category = item["Category"].ToString(),
                    Price = Convert.ToInt32(item["Price"].ToString()),
                    ProductId = item["_id"].ToString(),
                    ProductName = item["ProductName"].ToString(),
                    Unit = Convert.ToInt32(item["Unit"].ToString())
                });
			}

            return productList;
		}

        public void CreateProduct(CreateProductDto createProductDto)
        {
            MongoDbConnection mongoDbConnection = new MongoDbConnection();
            var productCollection = mongoDbConnection.GetProductCollection();

            var document = new BsonDocument
            {
                {"ProductName",createProductDto.ProductName },
                {"Unit",createProductDto.Unit },
                {"Price",createProductDto.Price },
                {"Category",createProductDto.Category }
            };

            productCollection.InsertOne(document);

            MessageBox.Show("ÜRÜN EKLENDİ");
        }

        public void UpdateProduct(UpdateProductDto updateProductDto)
        {
            MongoDbConnection mongoDbConnection = new MongoDbConnection();
            var productCollection = mongoDbConnection.GetProductCollection();

            var updatedProduct = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(updateProductDto.ProductId));

            var value = Builders<BsonDocument>.Update
                .Set("ProductName", updateProductDto.ProductName)
                .Set("Unit", updateProductDto.Unit)
                .Set("Price", updateProductDto.Price)
                .Set("Category", updateProductDto.Category);

            productCollection.UpdateOne(updatedProduct, value);

            MessageBox.Show("ÜRÜN GÜNCELLENDİ");

        }

        public void DeleteProduct(string id)
        {
            MongoDbConnection mongoDbConnection = new MongoDbConnection();
            var productCollection = mongoDbConnection.GetProductCollection();

            var deletedProduct = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));

            productCollection.DeleteOne(deletedProduct);

            MessageBox.Show("ÜRÜN SİLİNDİ");
        }

        public GetProductDto GetProduct(string id)
        {
            MongoDbConnection mongoDbConnection = new MongoDbConnection();
            var productCollection = mongoDbConnection.GetProductCollection();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var value = productCollection.Find(filter).FirstOrDefault();

            return new GetProductDto
            {
                Category = value["Category"].ToString(),
                Price = Convert.ToInt32(value["Price"].ToString()),
                ProductId = value["_id"].ToString(),
                ProductName = value["ProductName"].ToString(),
                Unit = Convert.ToInt32(value["Unit"].ToString())
            };
        }
    }
}
