using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace QuanLyHocSinh.Data
{
    public class StudentManageContext : DbContext
    {
        public StudentManageContext(DbContextOptions<StudentManageContext> opt) : base(opt)
        {           
        }
        #region DbSet
        public DbSet<Student>? Students { get; set; }
        #endregion
    }
}
