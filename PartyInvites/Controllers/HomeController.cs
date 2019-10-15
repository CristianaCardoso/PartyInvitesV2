using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(GuestResponse response)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(response);

                return View("ThankYou", response);
            } else
            {
                return View();
            }
        }

        public IActionResult GuestList()
        {
            var responses = Repository.GuestResponses().Where(r => r.WillAttend == true);

            //if (responses.Count == 0)
            //{
            //    return View("OfferSpecialDrink");
            //}

            return View(responses);
        }
    }
}
