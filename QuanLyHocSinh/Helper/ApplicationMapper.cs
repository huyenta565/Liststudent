using AutoMapper;
using QuanLyHocSinh.Data;
using QuanLyHocSinh.Models;
using QuanLyHocSinh.Models.Requests;

namespace QuanLyHocSinh.Helper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Student, GetStudentRequest>().ReverseMap();
        }
    }
}
