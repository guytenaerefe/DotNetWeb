using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotNetWeb.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            var cartSummary = "test\n test\n more test \n some text bro \n yeayeayea \n how many lines\n ok man and now \n";
            var topLines = cartSummary.Split('\n').Take(5).Select(x => x.Replace("\n", "<br />")).ToList();

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

        public IActionResult Error()
        {
            return View();
        }
    }
}
