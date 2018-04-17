using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestIpAddress.Models;

namespace TestIpAddress.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor _accessor;

        public HomeController(IHttpContextAccessor accessor)
        {
            _accessor = accessor;
        }

        public IActionResult Index()
        {
            var ipaddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();

            return Json(ipaddress);
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
