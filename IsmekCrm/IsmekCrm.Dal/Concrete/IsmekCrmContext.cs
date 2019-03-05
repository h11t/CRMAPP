using IsmekCrm.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace IsmekCrm.Dal.Concrete
{
    public class IsmekCrmContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DENEME24; Database=IsmekCrmDB; Integrated Security=true;");
        }
        public DbSet<User> User { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Status> Status { get; set; }

        
    }
}