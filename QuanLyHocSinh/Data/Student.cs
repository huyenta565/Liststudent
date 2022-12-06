using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyHocSinh.Data
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }
        [Range(7, 18)]
        public int Age { get; set; }
        public string? Sex { get; set; }
        [MaxLength(100)]
        public string? Address { get; set; } 
    }
}
