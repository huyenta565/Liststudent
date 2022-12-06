namespace QuanLyHocSinh.Models.Responses
{
    public class StudentResponse
    {
        public List<StudentInfomation>? StudentInfo { get; set; }
        public int Id { get; set; }
    }

    public class StudentInfomation
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public int Age { get; set; }
        public String? Sex { get; set; }
        public String? Address { get; set; }
    }
}
