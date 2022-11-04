using fakture_backend.Models;
using Microsoft.EntityFrameworkCore;
using VisioForge.Libs.MediaFoundation.OPM;

namespace fakture_backend.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Facture>()
                .HasMany(b => b.Artikli)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
        
        public DbSet<User> User { get; set; }
        public DbSet<Facture> Facture { get; set; }
        public DbSet<Article> Article { get; set; }


    }
}
