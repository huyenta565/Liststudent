using QuanLyHocSinh.Data;
using QuanLyHocSinh.Models;
using QuanLyHocSinh.Models.Requests;
using QuanLyHocSinh.Models.Responses;

namespace QuanLyHocSinh.Repositories
{
    public interface IStudentRepository
    {
        public Task<List<StudentResponse>> getAllStudentAsync();
        public Task<StudentResponse> getStudentsAsync(int id);
        public Task AddStudentAsync(GetStudentRequest student);
        public Task UpdateStudentAsync(int id, StudentResponse student);
        public Task DeleteStudentAsync(int id);
    }
}
