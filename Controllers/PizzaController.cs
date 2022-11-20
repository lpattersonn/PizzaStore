using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PizzaStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PizzaStore.Controllers
{
    public class PizzaController : Controller
    {

        // GET: /<controller>/
        public IActionResult Index()
        {
            PizzaViewModel pizza = new PizzaViewModel()
            {
                ID = 1,
                Name = "Vegetarian",
                Price = 10,
                ImageURL = "/images/Pizzas/Vegetarian.png"
            };

            return View(pizza);
        }


    }
}

