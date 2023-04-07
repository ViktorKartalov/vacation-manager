using Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using vacation_manager.Data.Entity;

namespace vacation_manager.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext() { }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB; Initial Catalog=VacationsDB; Integrated Security=true");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Vacation>().HasOne(v => v.RequestUser).WithMany(u => u.Vacations).HasForeignKey(v => v.RequestUserID);
            builder.Entity<User>().HasOne(u => u.Team).WithMany(t => t.Users).HasForeignKey(u => u.TeamId);
            builder.Entity<Team>().HasOne(t => t.Project).WithMany(p => p.Teams).HasForeignKey(t => t.ProjectId);

            base.OnModelCreating(builder);
        }

    }
}