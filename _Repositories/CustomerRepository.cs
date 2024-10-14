using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using System.Data;
using Supermarker_mvp.Models;
using System.Data.SqlClient;
using System.CodeDom;

namespace Supermarket_mvp._Repositories
{
    internal class CustomerRepository : BaseRepository, ICustomerRepository
    {
        public CustomerRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }
        public void Add(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Customers VALUES (@Document_Number, @First_Name, @Last_Name, @Address, @Birthday, @Phone_Number, @Email)";
                command.Parameters.Add("@Document_Number", SqlDbType.Int).Value = customerModel.Document_Number;
                command.Parameters.Add("@First_Name", SqlDbType.NVarChar).Value = customerModel.First_Name;
                command.Parameters.Add("@Last_Name", SqlDbType.NVarChar).Value = customerModel.Last_Name;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = customerModel.Address;
                command.Parameters.Add("@Birthday", SqlDbType.DateTime).Value = customerModel.Birthday;
                command.Parameters.Add("@Phone_Number", SqlDbType.Int).Value = customerModel.Phone_Number;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CustomerModel customerModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Customers
                                      SET Customer_Document_Number = @Document_Number,
                                      Customer_First_Name = @First_Name,
                                      Customer_Last_Name = @Last_Name,
                                      Customer_Address = @Address,
                                      Customer_Birthday = @Birthday,
                                      Customer_Phone_Number = @Phone_Number,
                                      Customer_Email = @Email
                                      WHERE Customer_Id = @Id";
                command.Parameters.Add("Document_Number", SqlDbType.NVarChar).Value = customerModel.Document_Number;
                command.Parameters.Add("@First_Name", SqlDbType.NVarChar).Value = customerModel.First_Name;
                command.Parameters.Add("@Last_Name", SqlDbType.NVarChar).Value = customerModel.Last_Name;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = customerModel.Address;
                command.Parameters.Add("@Birthday", SqlDbType.NVarChar).Value = customerModel.Birthday;
                command.Parameters.Add("@Phone_Number", SqlDbType.NVarChar).Value = customerModel.Phone_Number;
                command.Parameters.Add("@Email", SqlDbType.NVarChar).Value = customerModel.Email;
                command.ExecuteNonQuery();
            }

        }

        public IEnumerable<CustomerModel> GetAll()
        {
            var customerList = new List<CustomerModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customer ORDER BY Customer_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.Id = (int)reader["Customer_Id"];
                        customerModel.Document_Number = (int)reader["Customer_Document_Number"];
                        customerModel.First_Name = reader["Customer_First_Name"].ToString();
                        customerModel.Last_Name = reader["Customer_Last_Name"].ToString();
                        customerModel.Address = reader["Customer_Address"].ToString();
                        customerModel.Birthday = reader["Customer_Birthday"].ToString();
                        customerModel.Phone_Number = (char)reader["Customer_Phone_Number"];
                        customerModel.Email = reader["Customer_Email"].ToString();
                        customerList.Add(customerModel);
                    }
                }
            }
            return customerList;
        }

        public IEnumerable<CustomerModel> GetByValue(string value)
        {
            var customerList = new List<CustomerModel>();
            int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customerDocument_Number = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Customer
                                        WHERE Customer_Id=@id or Customer_Document_Number Like @document+ '%'
                                        ORDER By Customer_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerId;
                command.Parameters.Add("@document", SqlDbType.NVarChar).Value = customerDocument_Number;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomerModel();
                        customerModel.Id = (int)reader["Customer_Id"];
                        customerModel.Document_Number = (int)reader["Customer_Document_Number"];
                        customerList.Add(customerModel);
                    }
                }
            }

            return customerList;
        }
    }
}
