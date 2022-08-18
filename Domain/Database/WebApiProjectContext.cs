using Domain.Features.Users.Entities;
using Domain.Features.Users.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Domain.Database
{
    public class WebApiProjectContext : DbContext
    {
        public WebApiProjectContext(DbContextOptions<WebApiProjectContext> options)
            : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ApiConnectionString");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
