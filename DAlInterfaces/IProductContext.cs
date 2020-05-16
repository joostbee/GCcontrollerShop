using System;
using System.Collections.Generic;
using System.Text;

namespace DAlInterfaces
{
        public interface IProductContext
        {
            public List<ProductDTO> GetProductList();

            public ProductDTO GetProduct();
        }
    }
}

