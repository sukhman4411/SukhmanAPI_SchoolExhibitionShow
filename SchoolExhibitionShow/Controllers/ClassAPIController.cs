using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SchoolExhibitionShow.Controllers
{
    public class ClassAPIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}