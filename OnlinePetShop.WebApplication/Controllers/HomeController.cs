using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlinePetShop.Domain.Core;
using OnlinePetShop.Domain.Interfaces;
using OnlinePetShop.Services.Interfaces;

namespace OnlinePetShop.WebApplication.Controllers
{
    public class HomeController : Controller
    {
        IAnimalRepository repo;
        IOrder order;
        public HomeController(IAnimalRepository r, IOrder o)
        {
            repo = r;
            order = o;
        }
        public ActionResult Index()
        {
            var animals = repo.GetAnimalList();
            return View(animals);
        }
        public ActionResult Buy(int id)
        {
            Animal animal = repo.GetAnimalId(id);
            order.MakeOrder(animal);
            return View();
        }
        protected override void Dispose(bool disposing)
        {
            repo.Dispose();
            base.Dispose(disposing);
        }
    }
}