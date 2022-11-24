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
        List<PizzaViewModel> pizza = new List<PizzaViewModel>() {
            new PizzaViewModel {
                ID = 1,
                Name = "Vegetarian",
                Price = 10,
                ImageURL = "/images/Pizzas/Vegetarian.png"
            },
            new PizzaViewModel {
                ID = 2,
                Name = "Seafood",
                Price = 10,
                ImageURL = "/images/Pizzas/Seafood.png"
            },
            new PizzaViewModel {
                ID = 3,
                Name = "Pepperoni",
                Price = 13,
                ImageURL = "/images/Pizzas/Pepperoni.png"
            },
            new PizzaViewModel {
                ID = 4,
                Name = "Meat Feast",
                Price = 15,
                ImageURL = "/images/Pizzas/MeatFeast.png"
            },
            new PizzaViewModel {
                ID = 4,
                Name = "Hawaiian",
                Price = 15,
                ImageURL = "/images/Pizzas/Hawaiian.png"
            },
            };

            return View(pizza);
        }


    }
}

