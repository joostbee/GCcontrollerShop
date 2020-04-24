using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ViewModels
{
    public class ProductListView
    {
        public List<ProductView> ProductList { get; set; }

        public ProductListView()
        {

        }

        /*
        public ProductListView(string test)
        {
            ProductList = new List<ProductView>();
            ProductView Product1 = new ProductView() { Description = "2", ProductName = "2", Price = 2 };
            ProductList.Add(Product1);
        }
        */
        public ProductListView(string test)
        {
            ProductList = new List<ProductView>()
            {
                new ProductView() { Description = "1", ProductName = "1", Price = 1},
                new ProductView() { Description = "2", ProductName = "2", Price = 2},
                new ProductView() { Description = "3", ProductName = "3", Price = 3},
                new ProductView() { Description = "4", ProductName = "4", Price = 4},
                new ProductView() { Description = "5", ProductName = "5", Price = 5},
            };
        }
    }
}
