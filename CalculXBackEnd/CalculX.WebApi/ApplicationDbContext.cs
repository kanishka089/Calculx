using Microsoft.EntityFrameworkCore;
using AuthService;
using System.Reflection.Emit;

namespace CalculX.WebApi
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddAuthServiceDbSet();

            base.OnModelCreating(modelBuilder);
        }
    }
}
