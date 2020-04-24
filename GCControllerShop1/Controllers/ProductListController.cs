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
        public IActionResult Index()
        {
            ProductListView model;
            // model = new CleaningView();

            model = new ProductListView("test");
            return View(model);
        }
    }
}