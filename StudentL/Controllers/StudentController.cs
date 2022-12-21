using Microsoft.AspNetCore.Mvc;
using StudentData;
using StudentL.Models;
using StudentL.ViewModels;

namespace StudentL.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentDbContext context;

        public StudentController(StudentDbContext context)
        {
            this.context = context;
        }
        // GET: Student
        public ActionResult Index()
        {
            var student = this.context?.Student!.Select(m => new Student
            {
                Id = m.Id,
                Name = m.Name,
                Age = m.Age,
                Sex = m.Sex,
                Address = m.Address
            });
            return View(student);
        }       
        public ActionResult Edit(int Id)
        {
            var std = context.Student!.Where(s => s.Id == Id).FirstOrDefault();
            return View(std);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Student std)
        {
            context.Student!.Add(std);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Student std)
        {
            var student = context.Student!.Where(s => s.Id == std.Id).FirstOrDefault();
            student!.Name = std.Name;
            student!.Age = std.Age;
            student!.Sex = std.Sex;
            student!.Address = std.Address;

            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
