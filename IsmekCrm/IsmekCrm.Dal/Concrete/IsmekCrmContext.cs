using IsmekCrm.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace IsmekCrm.Dal.Concrete
{
    public class IsmekCrmContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=DENEME24; Database=IsmekCrmDB; Integrated Security=true;");
            }
        }
        public IsmekCrmContext()
        {

        }
        public IsmekCrmContext(DbContextOptions<IsmekCrmContext> options):base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Task> Task { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Status> Status { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDepartment>().HasKey(x => new { x.DepartmentId, x.UserId });

            modelBuilder.Entity<UserDepartment>().HasOne(x => x.Department).WithMany(x => x.Users).HasForeignKey(x => x.DepartmentId);
            modelBuilder.Entity<UserDepartment>().HasOne(x => x.User).WithMany(x => x.Departments).HasForeignKey(x => x.UserId);

            modelBuilder.Entity<UserRole>().HasKey(x => new { x.RoleId, x.UserId });

            modelBuilder.Entity<UserRole>().HasOne(x => x.Role).WithMany(x => x.Users).HasForeignKey(x => x.RoleId);
            modelBuilder.Entity<UserRole>().HasOne(x => x.User).WithMany(x => x.Roles).HasForeignKey(x => x.UserId);

            modelBuilder.Entity<UserTask>().HasKey(x => new { x.TaskId, x.UserId });

            modelBuilder.Entity<UserTask>().HasOne(x => x.Task).WithMany(x => x.Users).HasForeignKey(x => x.TaskId);
            modelBuilder.Entity<UserTask>().HasOne(x => x.User).WithMany(x => x.Tasks).HasForeignKey(x => x.UserId);
        }

    }
}