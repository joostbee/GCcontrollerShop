using System;
using System.Collections.Generic;
using Model.DataTransferObjects;
using Model.ViewModels;
using DataAccesLayer.Interfaces;

namespace Logic
{
    public class ProductLogic
    {
        private IProductContext iDataProduct;

        public ProductLogic()
        {
            this.iDataProduct = new DataAccesLayer.ProductContext();
        }
        //productlistview is tijdelijke oplossing, uiteindelijk naar list van productviews
        public ProductListView GetAllProducts()
        {
            ProductListView productList = new ProductListView();
            List<ProductDTO> allProducts = iDataProduct.GetProductList();

            if (allProducts.Count > 0)
            {
                foreach (ProductDTO product in allProducts)
                {
                    productList.ProductList.Add(TransferDTOtoViewModel(product));
                }
            }

            return productList;
        }

        private ProductView TransferDTOtoViewModel(ProductDTO productDTO)
        {
            ProductView productView = new ProductView();
            productView.Description = productDTO.Description;
            productView.Price = productDTO.Price.ToString();
            productView.ProductName = productDTO.ProductName;

            return productView;
        }
    }
}
