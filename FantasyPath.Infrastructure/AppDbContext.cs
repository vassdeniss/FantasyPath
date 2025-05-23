﻿using System.Text.Json;
using FantasyPath.Infrastructure.Configurations;
using FantasyPath.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FantasyPath.Infrastructure;

public class AppDbContext(DbContextOptions<AppDbContext> options)
        : IdentityDbContext<User, IdentityRole<Guid>, Guid>(options)
{
    public DbSet<Book> Books => Set<Book>();
    public DbSet<UserBook> UserBooks => Set<UserBook>();
    public DbSet<Save> Saves => Set<Save>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ApplyConfiguration(new BookConfiguration());
        
        builder.Entity<UserBook>()
            .HasKey(ub => new { ub.UserId, ub.BookId });

        builder.Entity<Save>()
            .Property(s => s.Inventory)
            .HasColumnType("nvarchar(max)")
            .HasConversion(
                s => JsonSerializer.Serialize(s, (JsonSerializerOptions)null),
                s => JsonSerializer.Deserialize<List<string>>(s, (JsonSerializerOptions)null));
        
        builder.Entity<Save>()
            .HasIndex(s => new { s.UserId, s.BookId });
        
        builder.Entity<Save>()
            .HasOne(s => s.User)
            .WithMany(u => u.Saves)
            .HasForeignKey(s => s.UserId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
