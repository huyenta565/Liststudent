using Microsoft.EntityFrameworkCore;
using StudentL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentL.ViewModels;

namespace StudentData
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        }

        internal object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public DbSet<Student>? Student { get; set; }
        public DbSet<StudentL.ViewModels.StudentViewModel> StudentViewModel { get; set; }
        public DbSet<StudentL.ViewModels.Create> Create { get; set; }
    }
}
