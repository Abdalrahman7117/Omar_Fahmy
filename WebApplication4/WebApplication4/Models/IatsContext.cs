using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class IatsContext : DbContext
    {
        public DbSet<Taasks> Taasks { get; set; }
        public DbSet<Projects> projects { get; set; }
        public DbSet<TeamMembers> teamMembers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Tasksssss;Persist Security Info=True;User ID=sa;Password=abdo01229149621;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
