using Microsoft.EntityFrameworkCore;

namespace DatingApp.Data
{
  public class DataContext : DbContext
  {
    public DbSet<AppUser> AppUsers;
    public DataContext(DbContextOptions options) : base(options)
    { 
    }
  }
}