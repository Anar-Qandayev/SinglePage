using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinglePage.Areas.Manage.Controllers
{
    public class InterestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
