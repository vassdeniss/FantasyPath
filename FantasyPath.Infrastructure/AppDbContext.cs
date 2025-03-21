using FantasyPath.Infrastructure.Configurations;
using FantasyPath.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FantasyPath.Infrastructure;

public class AppDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
    public DbSet<Book> Books => Set<Book>();
    public DbSet<UserBook> UserBooks => Set<UserBook>();
    public DbSet<Save> Saves => Set<Save>();
    public DbSet<PassageEntry> PassageEntries => Set<PassageEntry>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new BookConfiguration());
        
        builder.Entity<UserBook>()
            .HasKey(ub => new { ub.UserId, ub.BookId });
        
        builder.Entity<Save>()
            .Property(s => s.Inventory)
            .HasConversion(
                v => v.ToString(),
                v => v);   
        
        builder.Entity<Save>()
            .HasIndex(s => new { s.UserId, s.BookId });
        
        builder.Entity<Save>()
            .HasOne(s => s.Book)
            .WithMany(b => b.Saves)
            .HasForeignKey(s => s.BookId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.Entity<Save>()
            .HasOne(s => s.User)
            .WithMany(u => u.Saves)
            .HasForeignKey(s => s.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.Entity<PassageEntry>()
            .HasOne(p => p.Book)
            .WithMany()
            .HasForeignKey(p => p.BookId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.Entity<PassageEntry>()
            .HasOne(p => p.User)
            .WithMany()
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        builder.Entity<PassageEntry>()
            .HasIndex(p => new { p.UserId, p.BookId });
        
        builder.Entity<PassageEntry>()
            .Property(p => p.Details)
            .HasConversion(
                v => v,
                v => v);
    }
}
