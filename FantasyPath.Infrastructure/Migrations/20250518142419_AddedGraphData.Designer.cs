﻿// <auto-generated />
using System;
using FantasyPath.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FantasyPath.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250518142419_AddedGraphData")]
    partial class AddedGraphData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("CoverImageUrl")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("a29c7640-c463-4730-835d-eed8889d1d2c"),
                            Author = "Steve Jackson & Ian Livingstone",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110049i/26066622.jpg",
                            Isbn = "9780743475112",
                            Title = "The Warlock of Firetop Mountain"
                        },
                        new
                        {
                            Id = new Guid("cc589dcb-4352-455d-931c-f41beb1162a3"),
                            Author = "Steve Jackson",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1181233137i/1129656.jpg",
                            Isbn = "9780140316032 ",
                            Title = "The Citadel of Chaos"
                        },
                        new
                        {
                            Id = new Guid("0457c45a-07b7-44ed-87e3-7ed783a76eba"),
                            Author = "Ian Livingstone",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439110513i/26066654.jpg",
                            Isbn = "9781840464290",
                            Title = "The Forest of Doom"
                        },
                        new
                        {
                            Id = new Guid("a7204800-d2f4-4134-9d38-529ebb064399"),
                            Author = "Steve Jackson",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1357726081i/17228871.jpg",
                            Isbn = "9781840465525",
                            Title = "Starship Traveller"
                        },
                        new
                        {
                            Id = new Guid("136ee430-9e34-4576-b9f1-06155edf725a"),
                            Author = "Ian Livingstone",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439126001i/26067801.jpg",
                            Isbn = "9780140316452",
                            Title = "City of Thieves"
                        },
                        new
                        {
                            Id = new Guid("4cba6ce7-7b15-4b53-81ba-d07f08f0235c"),
                            Author = "Ian Livingstone",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1177021348i/675314.jpg",
                            Isbn = "9780140317084",
                            Title = "Deathtrap Dungeon"
                        },
                        new
                        {
                            Id = new Guid("7e9bb05e-8393-43d0-8550-6806c410a82e"),
                            Author = "Ian Livingstone",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439111136i/26066685.jpg",
                            Isbn = "9780140317435",
                            Title = "Island of the Lizard King"
                        },
                        new
                        {
                            Id = new Guid("03ced8a7-d423-42af-9083-e3cd9c0029db"),
                            Author = "Steve Jackson",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1328038532i/1129804.jpg",
                            Isbn = "9780140318296",
                            Title = "Scorpion Swamp"
                        },
                        new
                        {
                            Id = new Guid("3edcc1ad-36c5-4dbc-b71e-07175792d4d5"),
                            Author = "Ian Livingstone",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125616i/26067773.jpg",
                            Isbn = "9780140318302",
                            Title = "Caverns of the Snow Witch"
                        },
                        new
                        {
                            Id = new Guid("375f868c-15b0-452f-a6a8-cdc283750eaa"),
                            Author = "Steve Jackson",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1457004279i/1261049.jpg",
                            Isbn = "9780140318319",
                            Title = "House of Hell"
                        },
                        new
                        {
                            Id = new Guid("61a6a162-2ecc-44c3-9072-9ce496b4a9fc"),
                            Author = "Mark Smith & Jamie Thomson",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439125202i/26067637.jpg",
                            Isbn = "9781840465662",
                            Title = "Talisman of Death"
                        },
                        new
                        {
                            Id = new Guid("ec0b3ed6-83b4-4a9e-a3df-ba5276d39da5"),
                            Author = "Andrew Chapman",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124891i/26067557.jpg",
                            Isbn = "9780440981497",
                            Title = "Space Assassin"
                        },
                        new
                        {
                            Id = new Guid("3bc80bcd-293e-4241-98b9-08669efbe3f7"),
                            Author = "Ian Livingstone",
                            CoverImageUrl = "https://cybeswebsite.com/wp-content/uploads/2019/01/Figfan13n-186x300.jpg",
                            Isbn = "9780140317107",
                            Title = "Freeway Fighter"
                        },
                        new
                        {
                            Id = new Guid("2ff7fb7d-8640-45ec-b742-d1898f87e40a"),
                            Author = "Ian Livingstone",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121250i/26067291.jpg",
                            Isbn = "9781840465280",
                            Title = "Temple of Terror"
                        },
                        new
                        {
                            Id = new Guid("dce14443-51ab-4934-aed6-3e6b0314009d"),
                            Author = "Andrew Chapman",
                            CoverImageUrl = "https://static.wikia.nocookie.net/fightingfantasy/images/e/ee/15_06.jpg/revision/latest/scale-to-width-down/1000?cb=20191223080002",
                            Isbn = "9780440974079",
                            Title = "The Rings of Kether"
                        },
                        new
                        {
                            Id = new Guid("854b838e-3780-4f3b-a646-a922a8827101"),
                            Author = "Andrew Chapman",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439121633i/1261180.jpg",
                            Isbn = "9780440977087",
                            Title = "Seas of Blood"
                        },
                        new
                        {
                            Id = new Guid("42cfdbfa-dd47-45d5-9184-08d20cd6ce8f"),
                            Author = "Steve Jackson",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1188764984i/1817973.jpg",
                            Isbn = "9781840465273",
                            Title = "Appointment with F.E.A.R."
                        },
                        new
                        {
                            Id = new Guid("5dac7d67-6dd0-41bc-887b-08ddd44468a2"),
                            Author = "Robin Waterfield",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1232604646i/6123272.jpg",
                            Isbn = "99780140319521",
                            Title = "Rebel Planet"
                        },
                        new
                        {
                            Id = new Guid("fa420875-3b25-459a-9546-dc11c4534186"),
                            Author = "Steve Jackson & Ian Livingstone",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439124598i/26067514.jpg",
                            Isbn = "9780440918431",
                            Title = "Demons of the Deep"
                        },
                        new
                        {
                            Id = new Guid("c21ff243-0385-47e2-9f03-11901ad88533"),
                            Author = "Mark Smith & Jamie Thomson",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1439123656i/1029657.jpg",
                            Isbn = "9781840467321",
                            Title = "Sword of the Samurai"
                        },
                        new
                        {
                            Id = new Guid("2eb036dc-0836-4f22-8cd9-a24542c093c8"),
                            Author = "Ian Livingstone",
                            CoverImageUrl = "https://static.wikia.nocookie.net/fightingfantasy/images/1/14/21_11.jpg/revision/latest/scale-to-width-down/1000?cb=20191223064046",
                            Isbn = "9780140320398",
                            Title = "Trial of Champions"
                        },
                        new
                        {
                            Id = new Guid("96a7f4e2-867b-4786-af23-e26517ce04ec"),
                            Author = "Steve Jackson",
                            CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1344077625i/1261601.jpg",
                            Isbn = "9780140321524",
                            Title = "Robot Commando"
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

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
