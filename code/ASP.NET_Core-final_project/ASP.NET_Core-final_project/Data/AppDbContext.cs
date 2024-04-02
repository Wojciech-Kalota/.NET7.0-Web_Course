using Microsoft.EntityFrameworkCore;
using ASPNET_Core_final_project.Data.Models;

namespace ASPNET_Core_final_project.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Programmer_Language>()
                .HasOne(p => p.Programmer)
                .WithMany(pl => pl.Programmer_Language)
                .HasForeignKey(pi => pi.ProgrammerId);

            modelBuilder.Entity<Programmer_Language>()
                .HasOne(p => p.Language)
                .WithMany(pl => pl.Programmer_Language)
                .HasForeignKey(pi => pi.LanguageId);

        }

        public DbSet<Programmer> Programmers { get; set; }
        public DbSet<Language> Languages { get; set; }

        public DbSet<Programmer_Language> Programmer_Languages { get; set; }
    }
}
