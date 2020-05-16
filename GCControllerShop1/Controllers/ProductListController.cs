using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.ViewModels;
using Logic;

namespace GCControllerShop.Controllers
{
    public class ProductListController : Controller
    {
        Logic.ProductLogic productLogic = new Logic.ProductLogic();

        public IActionResult Index()
        {
            ProductListView productList = new ProductListView();

            productList = productLogic.GetAllProducts();
            
            return View(productList);
        }

    }

}