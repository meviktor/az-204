using Microsoft.EntityFrameworkCore;

namespace DeploymentSlots.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; } = null!;

        public void Seed()
        {
            if (!Users.Any())
            {
                Users.AddRange(
                    new User { Id = Guid.NewGuid(), Name = "Angela", Division = "Sales" },
                    new User { Id = Guid.NewGuid(), Name = "Rick", Division = "Legal team" }
                );
                SaveChanges();
            }
        }
    }
}
