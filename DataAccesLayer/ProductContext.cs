using Model.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using DataAccesLayer.Interfaces;

namespace DataAccesLayer
{
    //moet nog inheriten van een interface, dit word nog een losse laag ipv map in DAL
    public class ProductContext : IProductContext
    {
        private readonly ConnectionClass _connect;

        public ProductContext(ConnectionClass connect)
        {
            _connect = connect;
        }
        
        public ProductContext()
        {
            _connect = new ConnectionClass();
        }

        public List<ProductDTO> GetProductList()
        {
            List<ProductDTO> productList = new List<ProductDTO>();

                try
                {
                    _connect.Con.Open();
                    string query = " SELECT * FROM product";
                    MySqlCommand cmd = new MySqlCommand(query, _connect.Con);
                    var Datareader = cmd.ExecuteReader();

                    if (Datareader.HasRows)
                    {
                        while (Datareader.Read())
                        {
                            ProductDTO product = new ProductDTO
                            {
                                ProductName = Datareader.GetString("Name"),
                                Description = Datareader.GetString("Description"),
                                Price = Datareader.GetInt32("Price")
                            };
                            productList.Add(product);
                        }
                    }
                }

                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    _connect.Con.Close();
                }

            return productList;
        }

        public ProductDTO GetProduct()
        {
            ProductDTO product = new ProductDTO();
            return product;
        }
    }
}
