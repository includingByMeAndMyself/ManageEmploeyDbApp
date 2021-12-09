using Microsoft.EntityFrameworkCore;

namespace ManageEmploeyDbApp.Model.Data
{
    public class ApplicationContext: DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Position> Positios { get; set; }
        public DbSet<Department> Departments { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ManageEmployeeDbApp;Trusted_Connection=True;");
        }
    }
}
