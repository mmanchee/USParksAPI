using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace USParksAPI.Models
{
  public class USParksAPIContextFactory : IDesignTimeDbContextFactory<USParksAPIContext>
  {

    USParksAPIContext IDesignTimeDbContextFactory<USParksAPIContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<USParksAPIContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new USParksAPIContext(builder.Options);
    }
  }
}