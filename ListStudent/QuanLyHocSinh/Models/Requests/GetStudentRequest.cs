using QuanLyHocSinh.Models.Responses;
namespace QuanLyHocSinh.Models.Requests
{
    public class GetStudentRequest
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Sex { get; set; }
        public string? Adrress { get; set; }
    }
}
