using Microsoft.EntityFrameworkCore;
using UserService;

namespace tress_backend;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.AddUserServiceDbSet();

        base.OnModelCreating(modelBuilder);
    }
} 
