using Microsoft.EntityFrameworkCore;
using QuanLyHocSinh.Data;

namespace QuanLyHocSinh.Middleware
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddDbContext<StudentManageContext>((opt) =>
                {
                    opt.UseNpgsql(configuration.GetConnectionString("StudentManage"),
                        opts => opts.CommandTimeout((int)TimeSpan.FromMinutes(10).TotalSeconds));
                });
        }
    }
}

