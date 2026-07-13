using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Studentapi2.Models;

namespace Studentapi2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
        
        }
        


        public DbSet<Student>Students { get; set; }

    }
}
