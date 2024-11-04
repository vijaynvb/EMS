using EMSApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EMSApi.Data
{
    public class EMSDbContext : DbContext 
    {
        // configure our database how it should be ?
        // where to connect connection string 
        // what is schema of the db -> Table object
        public IConfiguration _config { get; }
        public EMSDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Server=(localdb)\\mssqllocaldb;Database=SchoolDb;Trusted_Connection=True;
            optionsBuilder.UseSqlServer(_config.GetConnectionString("db"));
            base.OnConfiguring(optionsBuilder);
        }

        // tables 
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Department> Departments { get; set; }
        
    }
}
