using EF_Test.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Test
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Connections.sqlConStr);

        }
        public DbSet<Student> Students { get; set; }
    }
}
