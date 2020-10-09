using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PartialView.Models;

namespace PartialView.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AuthController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return Ok();
        }

        public ActionResult Registration()
        {
            return Ok();
        }
    }
}
