using Microsoft.EntityFrameworkCore;
using TrainingApp.Domain.Entities;

namespace TrainingApp.EF
{
    public class TrainingAppEFContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityHistory> ActivityHistories { get; set; }

        public TrainingAppEFContext(DbContextOptions options) : base(options)
        {
        }
    }
}
