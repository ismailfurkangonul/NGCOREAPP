using Microsoft.AspNetCore.Mvc;
using NGCOREAPP.Models;
using System.Diagnostics;

namespace NGCOREAPP.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public void Add([FromBody] User _user)
        {

          
        }

    }
}