using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<DiaryEntry> diaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "Went Hiking",
                    Content = "Went hiking with Joe",
                    Created = new DateTime(2025, 5, 12)
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Went Climbing",
                    Content = "Went climbing with Sam",
                    Created = new DateTime(2025, 5, 12)
                }
            );
        }
    }
}
