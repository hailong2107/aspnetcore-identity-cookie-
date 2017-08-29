using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPNetCoreIdentityCookie.Models;
using Microsoft.AspNetCore.Authorization;

namespace ASPNetCoreIdentityCookie.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
