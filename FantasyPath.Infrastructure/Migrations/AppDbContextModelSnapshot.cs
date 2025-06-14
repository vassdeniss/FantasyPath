﻿// <auto-generated />
using System;
using FantasyPath.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FantasyPath.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FantasyPath.Infrastructure.Models.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e89a3706-4fca-46c7-962f-3ac4f9f76765"),
                            Author = "Steve Jackson & Ian Livingstone",
                            Isbn = "9780743475112",
                            Order = 1,
                            Title = "The Warlock of Firetop Mountain"
                        },
                        new
                        {
                            Id = new Guid("d70d4649-e8fc-4e80-995f-2ac304a13267"),
                            Author = "Steve Jackson",
                            Isbn = "9780140316032 ",
                            Order = 2,
                            Title = "The Citadel of Chaos"
                        },
                        new
                        {
                            Id = new Guid("bcb875ee-1010-4734-9447-226eea947e7e"),
                            Author = "Ian Livingstone",
                            Isbn = "9781840464290",
                            Order = 3,
                            Title = "The Forest of Doom"
                        },
                        new
                        {
                            Id = new Guid("e076483a-40c1-4f4c-9a16-942cf2a9a04d"),
                            Author = "Steve Jackson",
                            Isbn = "9781840465525",
                            Order = 4,
                            Title = "Starship Traveller"
                        },
                        new
                        {
                            Id = new Guid("d1efb3fc-0107-4488-8c6a-bb9c6472f236"),
                            Author = "Ian Livingstone",
                            Isbn = "9780140316452",
                            Order = 5,
                            Title = "City of Thieves"
                        },
                        new
                        {
                            Id = new Guid("4fa26a30-91b5-4d84-9a43-59be57cbfbe0"),
                            Author = "Ian Livingstone",
                            Isbn = "9780140317084",
                            Order = 6,
                            Title = "Deathtrap Dungeon"
                        },
                        new
                        {
                            Id = new Guid("c073fcde-dc4d-4c32-a969-17cf3f9f2e52"),
                            Author = "Ian Livingstone",
                            Isbn = "9780140317435",
                            Order = 7,
                            Title = "Island of the Lizard King"
                        },
                        new
                        {
                            Id = new Guid("f29ad60c-e3a1-4f52-82d6-16b5c40fc646"),
                            Author = "Steve Jackson",
                            Isbn = "9780140318296",
                            Order = 8,
                            Title = "Scorpion Swamp"
                        },
                        new
                        {
                            Id = new Guid("58b8465d-3486-421b-b377-b5634319745b"),
                            Author = "Ian Livingstone",
                            Isbn = "9780140318302",
                            Order = 9,
                            Title = "Caverns of the Snow Witch"
                        },
                        new
                        {
                            Id = new Guid("960865ba-6f8d-419e-ab80-35fe35e8009f"),
                            Author = "Steve Jackson",
                            Isbn = "9780140318319",
                            Order = 10,
                            Title = "House of Hell"
                        },
                        new
                        {
                            Id = new Guid("60474947-8c00-4389-92e6-b8ee861b338d"),
                            Author = "Mark Smith & Jamie Thomson",
                            Isbn = "9781840465662",
                            Order = 11,
                            Title = "Talisman of Death"
                        },
                        new
                        {
                            Id = new Guid("bc2d957d-b222-4151-8cad-9e137d3ac879"),
                            Author = "Andrew Chapman",
                            Isbn = "9780440981497",
                            Order = 12,
                            Title = "Space Assassin"
                        },
                        new
                        {
                            Id = new Guid("b541751e-5e36-4a5e-8b44-eacfe044b5b2"),
                            Author = "Ian Livingstone",
                            Isbn = "9780140317107",
                            Order = 13,
                            Title = "Freeway Fighter"
                        },
                        new
                        {
                            Id = new Guid("03f44579-899c-41c7-bfce-89964308bab0"),
                            Author = "Ian Livingstone",
                            Isbn = "9781840465280",
                            Order = 14,
                            Title = "Temple of Terror"
                        },
                        new
                        {
                            Id = new Guid("aa8a5c24-3f56-45a8-a52d-32dc091ec96a"),
                            Author = "Andrew Chapman",
                            Isbn = "9780440974079",
                            Order = 15,
                            Title = "The Rings of Kether"
                        },
                        new
                        {
                            Id = new Guid("41ff0756-f559-4cca-bf93-a1fa24a982f3"),
                            Author = "Andrew Chapman",
                            Isbn = "9780440977087",
                            Order = 16,
                            Title = "Seas of Blood"
                        },
                        new
                        {
                            Id = new Guid("2b3b4e94-73f6-49c0-a62e-4e900581ff39"),
                            Author = "Steve Jackson",
                            Isbn = "9781840465273",
                            Order = 17,
                            Title = "Appointment with F.E.A.R."
                        },
                        new
                        {
                            Id = new Guid("e15ca34a-13b1-4b2e-bb04-55b8a35f6186"),
                            Author = "Robin Waterfield",
                            Isbn = "99780140319521",
                            Order = 18,
                            Title = "Rebel Planet"
                        },
                        new
                        {
                            Id = new Guid("e63d0b82-1507-4df6-99bd-97862f36bbba"),
                            Author = "Steve Jackson & Ian Livingstone",
                            Isbn = "9780440918431",
                            Order = 19,
                            Title = "Demons of the Deep"
                        },
                        new
                        {
                            Id = new Guid("429a6fcc-39db-4f40-b60f-1ebb136a543b"),
                            Author = "Mark Smith & Jamie Thomson",
                            Isbn = "9781840467321",
                            Order = 20,
                            Title = "Sword of the Samurai"
                        });
                });

            modelBuilder.Entity("FantasyPath.Infrastructure.Models.Save", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Inventory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Luck")
                        .HasColumnType("int");

                    b.Property<int>("Skill")
                        .HasColumnType("int");

                    b.Property<int>("Stamina")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId", "BookId");

                    b.ToTable("Saves");
                });

            modelBuilder.Entity("FantasyPath.Infrastructure.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("FantasyPath.Infrastructure.Models.UserBook", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GraphData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("LastViewed")
                        .HasColumnType("datetime2");

                    b.HasKey("UserId", "BookId");

                    b.HasIndex("BookId");

                    b.ToTable("UserBooks");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FantasyPath.Infrastructure.Models.Save", b =>
                {
                    b.HasOne("FantasyPath.Infrastructure.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FantasyPath.Infrastructure.Models.User", "User")
                        .WithMany("Saves")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FantasyPath.Infrastructure.Models.UserBook", b =>
                {
                    b.HasOne("FantasyPath.Infrastructure.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FantasyPath.Infrastructure.Models.User", "User")
                        .WithMany("UserBooks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("FantasyPath.Infrastructure.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("FantasyPath.Infrastructure.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FantasyPath.Infrastructure.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("FantasyPath.Infrastructure.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FantasyPath.Infrastructure.Models.User", b =>
                {
                    b.Navigation("Saves");

                    b.Navigation("UserBooks");
                });
#pragma warning restore 612, 618
        }
    }
}
