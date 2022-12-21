using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using StudentData;
using StudentL.Models;
using StudentL.ViewModels;
using System.Diagnostics;

namespace StudentL.Controllers
{
    public class HomeController : Controller
    {
        private readonly StudentDbContext context;

        public HomeController(StudentDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}