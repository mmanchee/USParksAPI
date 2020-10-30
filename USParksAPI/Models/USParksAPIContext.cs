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
    }
}