using ListStudent.Models;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using QuanLyHocSinh.Data;
using System.Data;
using System.Diagnostics;
using Student = QuanLyHocSinh.Data.Student;

namespace ListStudent.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
       
        public IActionResult Index()
        {
            return View();
        }
    }
}