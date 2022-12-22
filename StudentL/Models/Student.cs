using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentL.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "Không được để trống tên")]
        public string? Name { get; set; }

        [Range(18, 27, ErrorMessage = "Mời nhập lại")]
        public int Age { get; set; }

        public string? Sex { get; set; }

        [MaxLength(100, ErrorMessage = "Không được để trống địa chỉ")]
        public string? Address { get; set; }
        public Guid LopHocId { get; set; }
        [ForeignKey("LopHocId")]
        public virtual LopHoc LopHoc { get; set; }
    }
}
