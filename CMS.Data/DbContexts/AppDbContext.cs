using CMS.Domain.Entities.DesignCategories;
using CMS.Domain.Entities.Designs;
using CMS.Domain.Entities.DesignTools;
using CMS.Domain.Entities.Domains;
using CMS.Domain.Entities.TimeZones;
using CMS.Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace CMS.Data.DbContexts;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = @"Host=localhost; Port=5432; User Id=postgres; database=CMSDb; password=4401";
        optionsBuilder.UseNpgsql(connectionString);
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<UserGroup> Groups { get; set; }
    public DbSet<Damen> Damens { get; set; }
    public DbSet<Design> Designs { get; set; }
    public DbSet<TimeZon> TimeZons { get; set; }
    public DbSet<DesignCategory> DesignCategories { get; set; }
    public DbSet<DesignTool> DesignTools { get; set; }  
    public DbSet<FontSize> FontSizes { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<Page> Pages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserGroup>()
            .HasOne(u => u.User)
            .WithMany()
            .HasForeignKey(u => u.UserId);

        modelBuilder.Entity<Design>()
            .HasOne(d => d.DesignCategory)
            .WithMany()
            .HasForeignKey(d => d.DesignCategoryId);
        modelBuilder.Entity<Design>()
            .HasOne(t => t.TimeZon)
            .WithMany()
            .HasForeignKey(t => t.TimeZonId);

        modelBuilder.Entity<DesignTool>()
            .HasOne(c => c.Color)
            .WithMany()
            .HasForeignKey(c => c.ColorId);
        modelBuilder.Entity<DesignTool>()
            .HasOne(s => s.FontSize)
            .WithMany()
            .HasForeignKey(s => s.FontSizeId);
        modelBuilder.Entity<DesignTool>()
            .HasOne(p => p.Page)
            .WithMany()
            .HasForeignKey(p => p.PageId);
    }
}