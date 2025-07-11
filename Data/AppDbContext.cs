using Microsoft.EntityFrameworkCore;
using StudentManagementApi.Models;

namespace StudentManagementApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        
        public DbSet<Student> Students { get; set; }
    }
}