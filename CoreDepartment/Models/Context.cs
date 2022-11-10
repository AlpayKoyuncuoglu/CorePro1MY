using Microsoft.EntityFrameworkCore;

namespace CoreDepartment.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=PC-KOYUNCUOGLU;database=CorePersonel;integrated security=true");
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
