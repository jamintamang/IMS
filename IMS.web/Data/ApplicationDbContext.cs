using IMS.web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IMS.web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContext)
            : base(dbContext) { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        protected override void OnModelCreating (ModelBuilder builder)
        {
            base.OnModelCreating (builder);
           

                builder.Entity<ApplicationUser>()
                    .Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(250);
                builder.Entity<ApplicationUser>()
                    .Property(e => e.MiddleName)
                    .IsRequired()
                    .HasMaxLength(250);
                builder.Entity<ApplicationUser>()
                    .Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(250);
                builder.Entity<ApplicationUser>()
                    .Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(250);
                builder.Entity<ApplicationUser>()
                    .Property(e => e.StoreId)
                    .IsRequired()
                    .HasMaxLength(250);
                builder.Entity<ApplicationUser>()
                    .Property(e => e.ProfileUrl)
                    .HasMaxLength(250);
                builder.Entity<ApplicationUser>()
                    .Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValue(true);
                builder.Entity<ApplicationUser>()
                    .Property(e => e.CreatedDate)
                    .IsRequired()
                    .HasDefaultValueSql("GETDATE()");
                builder.Entity<IdentityRole>()
                    .ToTable("Roles")
                    .Property(p => p.Id)
                    .HasColumnName("RoleID");

            
        }


     
      
  
    
   
    }
}