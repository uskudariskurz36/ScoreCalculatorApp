using Microsoft.AspNetCore.Mvc;
using ScoreCalculatorApp.Models;
using System.Diagnostics;

namespace ScoreCalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(/*new IndexViewModel()*/);
        }

        [HttpPost]
        public IActionResult Index(IndexViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Percent1 + model.Percent2 != 100)
                {
                    ModelState.AddModelError(nameof(model.Percent1), "Percent 1 ve Percent 2 toplamı 100 olmalıdır.");
                    ModelState.AddModelError(nameof(model.Percent2), "Percent 1 ve Percent 2 toplamı 100 olmalıdır.");
                }
                else
                {
                    model.CalculatedScore = (model.Score1 * model.Percent1 / 100) + (model.Score2 * model.Percent2 / 100);
                }
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}