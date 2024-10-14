using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarker_mvp.Models;
using System.Data;
using Supermarket_mvp.View;
using Supermarket_mvp.Models;
using System.Data.SqlClient;

namespace Supermarket_mvp._Repositories
{
    internal class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(ProductModel productModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetAll()
        {
            var productModelList = new List<ProductModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = connection.CreateCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Product ORDER BY Product_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Id = (int)reader["Product_Id"];
                        productModel.Name = reader["Product_Name"].ToString();
                        productModel.Price = (decimal)reader["Product_Price"];
                        productModel.Stock = (int)reader["Product_Stock"];
                        productModelList.Add(productModel);
                    }
                }
                return productModelList;
            }
        }

        public IEnumerable<ProductModel> GetByValue(string value)
        {
                var productModeList = new List<ProductModel>();
                int productId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
                string productName = value;
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand())
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = @"SELECT * FROM Product
                              WHERE Product_Id=@id or Product_Name LIKE @name+ '%'
                              ORDER By Product_Id DESC";
                    command.Parameters.Add("@id", SqlDbType.Int).Value = productId;
                    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productName;
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var productModel = new ProductModel();
                            productModel.Id = (int)reader["Product_Id"];
                            productModel.Name = reader["Product_Name"].ToString();
                            productModel.Price = (decimal)reader["Product_Price"];
                            productModel.Stock = (int)reader["Product_Stock"];
                            productModeList.Add(productModel);

                        }
                    }
                }
                return productModeList;
        }
    }
}
