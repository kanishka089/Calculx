using AccountingService;
using AuthService;
using Microsoft.EntityFrameworkCore;
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
            base.OnModelCreating(modelBuilder);
            modelBuilder.AddAuthServiceDbSet();
            modelBuilder.AddUserServiceDbSet();
            modelBuilder.AddAccountingServiceDbSet();
        }
    }


}
