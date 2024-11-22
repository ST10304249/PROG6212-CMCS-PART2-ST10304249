using Microsoft.AspNetCore.Mvc;
using Prog_P2.Models;
using System.Diagnostics;
using Prog_P2;

namespace Prog_P2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Welcome()
        {
            return View();
        }
    }

}

