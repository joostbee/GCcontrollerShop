﻿using System;
using System.Collections.Generic;
using System.Text;
using Model.DataTransferObjects;

namespace DataAccesLayer.Interfaces
{
    public interface IProductContext
    {
        public List<ProductDTO> GetProductList();

        public ProductDTO GetProduct();
    }
}
