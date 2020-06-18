﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyApi.Data;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MyApi.Data.Migrations
{
    [DbContext(typeof(LibraryContext))]
    [Migration("20200526210433_AddImageUrlToBook")]
    partial class AddImageUrlToBook
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("MyApi.Data.Entities.Author", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("authors");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Robert C. Martin"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Claus Matzinger"
                        },
                        new
                        {
                            Id = 3L,
                            Name = "Matt Neuburg"
                        },
                        new
                        {
                            Id = 4L,
                            Name = "Sandi Metz"
                        },
                        new
                        {
                            Id = 5L,
                            Name = "Mark J. Price"
                        },
                        new
                        {
                            Id = 6L,
                            Name = "Gene Kim"
                        });
                });

            modelBuilder.Entity("MyApi.Data.Entities.Book", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("AuthorId")
                        .HasColumnName("author_id")
                        .HasColumnType("bigint");

                    b.Property<string>("ImageUrl")
                        .HasColumnName("image_url")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("books");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            AuthorId = 1L,
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41jEbK-jG+L._SX258_BO1,204,203,200_.jpg",
                            Name = "Clean Code: A Handbook of Agile Software Craftsmanship"
                        },
                        new
                        {
                            Id = 2L,
                            AuthorId = 1L,
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/516tg-5b2ZL._SX380_BO1,204,203,200_.jpg",
                            Name = "Clean Architecture: A Craftsman's Guide to Software Structure and Design"
                        },
                        new
                        {
                            Id = 3L,
                            AuthorId = 1L,
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/41VQ9-JOXLL._SX380_BO1,204,203,200_.jpg",
                            Name = "Clean Agile: Back to Basics"
                        },
                        new
                        {
                            Id = 4L,
                            AuthorId = 2L,
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51OAK07CVZL._SX404_BO1,204,203,200_.jpg",
                            Name = "Rust Programming Cookbook"
                        },
                        new
                        {
                            Id = 5L,
                            AuthorId = 3L,
                            ImageUrl = "https://m.media-amazon.com/images/I/51pWp9HxK8L._SX260_.jpg",
                            Name = "iOS 13 Programming Fundamentals with Swift: Swift, Xcode, and Cocoa Basics"
                        },
                        new
                        {
                            Id = 6L,
                            AuthorId = 4L,
                            ImageUrl = "https://m.media-amazon.com/images/I/61qpmhZRxGL._SX260_.jpg",
                            Name = "Practical Object-Oriented Design: An Agile Primer Using Ruby"
                        },
                        new
                        {
                            Id = 7L,
                            AuthorId = 5L,
                            ImageUrl = "https://m.media-amazon.com/images/I/51+AEbYTT8L._SX260_.jpg",
                            Name = "C# 8.0 and .NET Core 3.0 – Modern Cross-Platform Development: Build applications with C#, .NET Core, Entity Framework Core, ASP.NET Core, and ML.NET using Visual Studio Code, 4th Edition"
                        },
                        new
                        {
                            Id = 8L,
                            AuthorId = 6L,
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51bAF5pdyeL._SX332_BO1,204,203,200_.jpg",
                            Name = "The Phoenix Project: A Novel about IT, DevOps, and Helping Your Business Win"
                        },
                        new
                        {
                            Id = 9L,
                            AuthorId = 6L,
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51A4T36jisL._SX334_BO1,204,203,200_.jpg",
                            Name = "The Unicorn Project: A Novel about Developers, Digital Disruption, and Thriving in the Age of Data"
                        },
                        new
                        {
                            Id = 10L,
                            AuthorId = 6L,
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51Z6uQ57ilL._SX324_BO1,204,203,200_.jpg",
                            Name = "The DevOps Handbook: How to Create World-Class Agility, Reliability, and Security in Technology Organizations"
                        });
                });

            modelBuilder.Entity("MyApi.Data.Entities.Book", b =>
                {
                    b.HasOne("MyApi.Data.Entities.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
