using StudentData;
using StudentL.Models;

namespace StudentL.ViewModels
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Sex { get; set; }
        public string? Address { get; set; }
        public Guid LopHocId { get; set; }

    }
}
