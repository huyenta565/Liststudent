using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuanLyHocSinh.Data;
using QuanLyHocSinh.Repositories;

namespace QuanLyHocSinh.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentRepository _studentRepo;

        public StudentsController(IStudentRepository str)
        {
            _studentRepo = str;
        }
    }
    [HttpGet(Name = "ListStudent")]
    public IEnumerable<ListStudent> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new ListStudent
        {
            
        })
        .ToArray();
    }
}
