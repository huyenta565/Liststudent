using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using StudentData;
using StudentL.Models;
using StudentL.ViewModels;
using System.Net;

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

        public ActionResult Delete(int? Id)
        {
            var student = context.Student!.Find(Id);
            return View(student);
        }
        [HttpPost]
        public ActionResult Create(StudentViewModel std)
        {
            var idMax = context.Student!.OrderByDescending(s => s.Id).FirstOrDefault();
            var student = new Student
            {
                Id = idMax.Id + 1,
                Name = std.Name,
                Address = std.Address,
                Age = std.Age,
                Sex = std.Sex,
                LopHocId = std.LopHocId,
            };
            var lophoc = new LopHoc
            {
                Id = Guid.NewGuid(),
                Name = "10A3",
                HocSinh = new List<Student>
                {
                    new Student
                    {
                        Id = student.Id,
                    }
                }
            }
            context.Student!.Add(student);
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

        [HttpPost]
        public ActionResult Delete(int Id)
        {
            Student std = context.Student!.Find(Id);
            context.Student!.Remove(std);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
