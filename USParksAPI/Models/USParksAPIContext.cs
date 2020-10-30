using Microsoft.EntityFrameworkCore;

namespace USParksAPI.Models
{
  public class USParksAPIContext : DbContext
  {
    public USParksAPIContext(DbContextOptions<USParksAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
          .HasData(
        new Park { ParkId = 1, State = "", City = "", Description = "" }
        
        );
    }
  }
}