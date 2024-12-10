using Microsoft.EntityFrameworkCore;
using AuthService;
using System.Reflection.Emit;
using UserService;
using UserService.Entities;

namespace CalculX.WebApi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddAuthServiceDbSet();
            modelBuilder.AddUserServiceDbSet();

            base.OnModelCreating(modelBuilder);
        }
    }


}
