﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProductShopTutorial.Models;

namespace ProductShopTutorial.Controllers {
    public class ProductController : Controller {
        public IActionResult Detail(string slug) {
            Product product = DataBase.GetProduct(slug);
            return View(product);
        }

        public IActionResult List() {
            List<Product> products = DataBase.GetProducts();
            return View(products);
        }
    }
}
