using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.ViewModels;

namespace GCControllerShop.Controllers
{
    public class ProductListController : Controller
    {
        public ProductListView productList = new ProductListView("test");

        public IActionResult Index()
        {
            return View(productList);
        }

    }

}