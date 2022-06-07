using Microsoft.AspNetCore.Mvc;
using SinglePage.DAL;
using SinglePage.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SinglePage.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Abouts =  _context.Abouts.Take(1).ToList(),
                Experiences = _context.Experiences.Take(1).ToList(),
                Educations = _context.Educations.Take(1).ToList(),
                Awards = _context.Awards.Take(1).ToList(),
                Interests = _context.Interests.Take(1).ToList(),
                Skills = _context.Skills.Take(1).ToList()

            };
            return View(homeVM);
        }
    }
}
