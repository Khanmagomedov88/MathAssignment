using Microsoft.EntityFrameworkCore;
using System.IO;
using System.Windows;

namespace Maths.DateBase
{
    class MathDbContext : DbContext
    {
        public DbSet<MathTask> MathTasks { get; set; }
        public DbSet<MathExample> MathExamples { get; set; }
        public DbSet<MathEquation> MathEquations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "mathApp.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }
    }
}
