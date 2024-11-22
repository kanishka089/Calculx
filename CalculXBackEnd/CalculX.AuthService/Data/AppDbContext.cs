using CalculX.AuthService.Models;
using Microsoft.EntityFrameworkCore;

namespace CalculX.AuthService.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Auth> Auth { get; set; }
    }
}
