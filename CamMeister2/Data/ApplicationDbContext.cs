using CamMeister2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CamMeister2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Camera> Cameras { get; set; }
        
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public string CameraPhotoURL { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
            .HasMany(au => au.Cameras)
            .WithOne(c => c.ApplicationUser)
            .HasForeignKey(au => au.ApplicationUserId)
            .OnDelete(DeleteBehavior.Cascade);
        }



    }
}