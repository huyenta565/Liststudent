using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuanLyHocSinh.Data;
using QuanLyHocSinh.Models.Requests;
using QuanLyHocSinh.Models.Responses;
using QuanLyHocSinh.Repositories;
using System.Security.AccessControl;

namespace QuanLyHocSinh.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentManageContext _context;
        private readonly IMapper _mapper;

        public StudentService(StudentManageContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task AddStudentAsync(GetStudentRequest student)
        {
            var newStudent = _mapper.Map<Student>(student);
            await _context.Students!.AddAsync(newStudent);

        }

        public async Task DeleteStudentAsync(int id)
        {
            var deleteStudent = _context.Students!.SingleOrDefault(s => s.Id == id);
            if (deleteStudent != null)
            {
                _context.Students!.Remove(deleteStudent);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<StudentResponse>> getAllStudentAsync()
        {
            var students = await _context.Students!.ToListAsync();
            return _mapper.Map<List<StudentResponse>>(students);
        }

        public async Task<StudentResponse> getStudentsAsync(int id)
        {
            var students = await _context.Students!.FindAsync(id);
            return _mapper.Map<StudentResponse>(students);
        }

        public async Task UpdateStudentAsync(int id, StudentResponse model)
        {
            if (id == model.Id)
            {
                var updateStudent = _mapper.Map<Student>(model);
                _context.Students!.Update(updateStudent);
                await _context.SaveChangesAsync();
            }
        }
    }
}
