using BurgerApp.DataAccess;
using BurgerApp.Domain;
using BurgerApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BurgerApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.MostPurchasedBurger = InMemoryDataBase.MostPurchasedBurger;
            ViewBag.AveragePriceOfAnOrder = InMemoryDataBase.AveragePriceOfAnOrder;
            ViewBag.NumberOfOrdersServiced = InMemoryDataBase.NumberOfOrdersServiced;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Menu()
        {
            List<Burger> burgersForOrder = new List<Burger>();
            ViewBag.Burgers = InMemoryDataBase.Burgers;

            return View();
        }

        public void ReturnBurger(List<Burger> list, Burger burger)
        {
            list.Add(burger);
            Console.WriteLine("Lmao");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
