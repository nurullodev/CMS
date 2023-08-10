using CMS.Domain.Enums;
using CMS.Domain.Entities.Users;
using CMS.Domain.Entities.Designs;
using CMS.Domain.Entities.Domains;
using Microsoft.EntityFrameworkCore;
using CMS.Domain.Entities.TimeZones;
using CMS.Domain.Entities.DesignTools;
using CMS.Domain.Entities.DesignCategories;

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
    public DbSet<FontType> FontTypes { get; set; }
    public DbSet<Color> Colors { get; set; }

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

        modelBuilder.Entity<DesignTool>()
            .HasOne(c => c.Color)
            .WithMany()
            .HasForeignKey(c => c.ColorId);
        modelBuilder.Entity<DesignTool>()
            .HasOne(s => s.FontType)
            .WithMany()
            .HasForeignKey(s => s.FontTypeId);


        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, FirstName = "Nurullo", LastName = "Nurmatov", Email = "nurullo@gmail.com",Password = "1234",DamenId = 1 ,CreatedAt = DateTime.UtcNow},
            new User { Id = 2, FirstName = "Asadbek", LastName = "Asadov", Email = "asad@gmail.com", Password = "2564", DamenId = 2, CreatedAt = DateTime.UtcNow },
            new User { Id = 3, FirstName = "Ikrom", LastName = "Ikromov", Email = "ikrom@gmail.com", Password = "4567",DamenId = 3, CreatedAt = DateTime.UtcNow },
            new User { Id = 4, FirstName = "Axror", LastName = "Alimov", Email = "nurullo@gmail.com", Password = "7415",DamenId = 4, CreatedAt = DateTime.UtcNow });
        
        modelBuilder.Entity<Damen>().HasData(
            new Damen {Id = 1, Name = "Uzum", CreatedAt = DateTime.UtcNow },
            new Damen { Id = 2, Name = "laptops", CreatedAt = DateTime.UtcNow },
            new Damen { Id = 3, Name = "Vachach", CreatedAt = DateTime.UtcNow },
            new Damen { Id = 4, Name = "Naura", CreatedAt = DateTime.UtcNow });

        modelBuilder.Entity<UserGroup>().HasData(
            new UserGroup { Id = 1, Email = "john@example@gmail.com", UserId = 1,DamenId = 1, CreatedAt = DateTime.UtcNow },
            new UserGroup { Id = 2, Email = "examp@gmail.com", UserId = 2, DamenId = 2, CreatedAt = DateTime.UtcNow },
            new UserGroup { Id = 3, Email = "exam2p@gmail.com", UserId = 3, DamenId = 3, CreatedAt = DateTime.UtcNow },
            new UserGroup { Id = 4, Email = "examp3@gmail.com", UserId = 4, DamenId = 4, CreatedAt = DateTime.UtcNow });

        modelBuilder.Entity<Color>().HasData(
            new Color { Id = 1, Name = "Red", CreatedAt = DateTime.UtcNow },
            new Color { Id = 2, Name = "Yellow", CreatedAt = DateTime.UtcNow });

        modelBuilder.Entity<FontType>().
            HasData(
            new FontType { Id = 1, Type = "Normal Text", CreatedAt = DateTime.UtcNow },
            new FontType { Id = 2, Type = "\u001b[3mSmaller Text \u001b[0m", CreatedAt = DateTime.UtcNow });


        modelBuilder.Entity<DesignTool>().HasData(
            new DesignTool { Id = 1, ColorId = 1, FontTypeId = 1, CreatedAt = DateTime.UtcNow },
            new DesignTool { Id = 2, ColorId = 2, FontTypeId = 1, CreatedAt = DateTime.UtcNow },
            new DesignTool { Id = 3, ColorId = 2, FontTypeId = 1, CreatedAt = DateTime.UtcNow },
            new DesignTool { Id = 4, ColorId = 1, FontTypeId = 1, CreatedAt = DateTime.UtcNow });

        modelBuilder.Entity<TimeZon>().HasData(
            new TimeZon { Id = 1, Name = "Arabia", Abbreviation = "ADT", OffSet = "UTC +4", CreatedAt = DateTime.UtcNow},
            new TimeZon { Id = 2, Name = "Armenia", Abbreviation = "AMT", OffSet = "UTC +4", CreatedAt = DateTime.UtcNow },
            new TimeZon { Id = 3, Name = "Afganistan", Abbreviation = "AFT", OffSet = "UTC +4:30", CreatedAt = DateTime.UtcNow },
            new TimeZon { Id = 4, Name = "Alma-Ata", Abbreviation = "ALMT", OffSet = "UTC +6", CreatedAt = DateTime.UtcNow },
            new TimeZon { Id = 5, Name = "Uzbekistan ", Abbreviation = "UZT", OffSet = "UTC +5", CreatedAt = DateTime.UtcNow });

        modelBuilder.Entity<Design>().HasData(
            new Design { Id = 1, Name = "Saua", Description = "Good", Attribute = 1, DesignCategoryId = 1, Language = Language.English, DamenId = 1, CreatedAt = DateTime.UtcNow},
             new Design { Id = 2, Name = "One", Description = "Good", Attribute = 2, DesignCategoryId = 2, Language = Language.English, DamenId = 2, CreatedAt = DateTime.UtcNow});
       
        modelBuilder.Entity<DesignCategory>().HasData(
            new DesignCategory { Id = 1, Name = "Movies", CreatedAt = DateTime.UtcNow },
            new DesignCategory { Id = 2, Name = "Fitness", CreatedAt = DateTime.UtcNow},
            new DesignCategory { Id = 3, Name = "Politics", CreatedAt = DateTime.UtcNow },
            new DesignCategory { Id = 4, Name = "World", CreatedAt = DateTime.UtcNow },
            new DesignCategory { Id = 5, Name = "Technology", CreatedAt = DateTime.UtcNow });
    }
}