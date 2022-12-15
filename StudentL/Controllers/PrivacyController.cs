using Microsoft.AspNetCore.Mvc;
using StudentData;
using StudentL.Models;
using StudentL.ViewModels;

namespace StudentL.Controllers
{
    public class PrivacyController : Controller
    {
        private readonly StudentDbContext context;

        public PrivacyController(StudentDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add([FromBody] StudentViewModel stv)
        {
            Student student = new Student();
            student.Id = stv.Id;
            student.Name = stv.Name;
            student.Age = stv.Age;
            student.Sex = stv.Sex;
            student.Address = stv.Address;
            context?.Student!.Add(student);
            context?.SaveChanges();
            if (student.Id > 0)
            {
                return RedirectToAction("Index","StudentViewModel");
            }
            else
            {
                ModelState.AddModelError("", "Thêm sinh viên thành công");
                return View("Index");
            }
        }
    }
}
