using AuthService;
using CalculX.Base.Services;
using Microsoft.EntityFrameworkCore;
using TenantService.Entities;
using UserService;
using UserService.Entities;

namespace CalculX.WebApi
{
    public class ApplicationDbContext : DbContext
    {
        private readonly TenantProvider _tenantProvider;
        private readonly int _tenantId;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,TenantProvider tenantProvider) : base(options)
        {
            _tenantProvider = tenantProvider;
           // _tenantId = tenantProvider.Ge
        }

        public DbSet<User> User { get; set; }
        public DbSet<Tenant> Tenant { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.AddAuthServiceDbSet();
        //    modelBuilder.AddUserServiceDbSet(_tenantId);
        //    modelBuilder.AddTenantServiceDbSet();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           // int tenantId = _tenantProvider.GetTenantId();
            // modelBuilder.AddUserServiceDbSet(tenantId); // Pass tenant ID dynamically
            modelBuilder.AddUserServiceDbSet();
            modelBuilder.AddTenantServiceDbSet();
        }
    }


}
