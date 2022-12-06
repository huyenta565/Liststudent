using QuanLyHocSinh.Data;
using QuanLyHocSinh.Models.Requests;
using QuanLyHocSinh.Models.Responses;

namespace QuanLyHocSinh.Services
{
    public interface IStudentService
    {
        public Task<List<StudentResponse>> getAllStudentAsync();
        public Task<StudentResponse> getStudentsAsync(int id);
        public Task AddStudentAsync(GetStudentRequest student);
        public Task UpdateStudentAsync(int id, StudentResponse student);
        public Task DeleteStudentAsync(int id);
    }
}
