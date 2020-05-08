using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.ViewModels;

namespace GCControllerShop.Controllers
{
    public class ProductDetailsController : Controller
    {
        public IActionResult Index(ProductView product)
        {
            return View(product);
        }
    }
}