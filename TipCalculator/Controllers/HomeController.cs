using Microsoft.AspNetCore.Mvc;
using TipCalculator.Models;
using System;

namespace TipCalculator.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Cost = 0;
            ViewBag.FifteenPerTip = 0;
            ViewBag.TwentyPerTip = 0;
            ViewBag.TwentyFivePerTip = 0;

            return View();
        }

        [HttpPost]
        public IActionResult Index(Calculator calculator)
        {

                if (ModelState.IsValid)
                {
                    ViewBag.FifteenPerTip = calculator.GetTip(15);
                    ViewBag.TwentyPerTip = calculator.GetTip(20);
                    ViewBag.TwentyFivePerTip = calculator.GetTip(25);
                }
                else
                {
                    ViewBag.FifteenPerTip = 0;
                    ViewBag.TwentyPerTip = 0;
                    ViewBag.TwentyFivePerTip = 0;
                }
                return View(calculator);
        }
    }
}
