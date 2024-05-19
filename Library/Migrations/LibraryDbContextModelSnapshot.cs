﻿// <auto-generated />
using System;
using Library.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Library.Migrations
{
    [DbContext(typeof(LibraryDbContext))]
    partial class LibraryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.Property<Guid>("BooksId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BooksId", "CategoriesId");

                    b.HasIndex("CategoriesId");

                    b.ToTable("BookCategory");
                });

            modelBuilder.Entity("Library.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Library.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4f9aecb1-d99a-49c2-b74d-5ffd17f77e88"),
                            Name = "Science Fiction"
                        },
                        new
                        {
                            Id = new Guid("9d52853b-e718-4be1-a2d0-e232f5d57d36"),
                            Name = "Fantasy"
                        },
                        new
                        {
                            Id = new Guid("e53381c8-6d47-4702-bb82-b7ff2323161d"),
                            Name = "Non-Fiction"
                        },
                        new
                        {
                            Id = new Guid("9988dac7-b6a8-4f6d-a47f-78f57e765970"),
                            Name = "Mystery"
                        },
                        new
                        {
                            Id = new Guid("a687bbac-9216-448c-a9e2-5da1b820f7bc"),
                            Name = "Romance"
                        },
                        new
                        {
                            Id = new Guid("2feaeb9f-6d7e-48d7-a822-e6287fb40c63"),
                            Name = "Thriller"
                        },
                        new
                        {
                            Id = new Guid("673f0962-cbc8-42d9-bf70-d68494ecd66a"),
                            Name = "Historical Fiction"
                        },
                        new
                        {
                            Id = new Guid("c0826288-0176-40ce-9d29-9ad1fb9fa809"),
                            Name = "Biography"
                        },
                        new
                        {
                            Id = new Guid("f1e7e51e-3a5e-4714-bf08-3477a121b9ca"),
                            Name = "Self - Help"
                        },
                        new
                        {
                            Id = new Guid("3555b5af-1b48-4834-bf4d-9f0f4506c491"),
                            Name = "Young Adult"
                        },
                        new
                        {
                            Id = new Guid("e1ac7b41-309a-471c-a939-363afc97b192"),
                            Name = "Children's Books"
                        },
                        new
                        {
                            Id = new Guid("a969dc49-d8c5-4907-baab-aa72b4fbd193"),
                            Name = "Poetry"
                        },
                        new
                        {
                            Id = new Guid("0974122a-76f9-492f-a99f-8c13884e6886"),
                            Name = "Graphic Novels"
                        },
                        new
                        {
                            Id = new Guid("cca4268d-5c5e-4ef0-8fce-cc37a1e633e0"),
                            Name = "Adventure"
                        });
                });

            modelBuilder.Entity("Library.Entities.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Assessment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Library.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("53a67e16-b115-452a-b0af-c6c0ca95c4c5"),
                            PasswordHash = "9cNjbwLa5KYruacYRycXxgRF/CjfHp4YDn+PBfO7kPjtUEoDN+rM5m6/AOTC49rw6j+m9UCGGCKrFpgMzzrjWA==",
                            PasswordSalt = "xWHjjdhHjY7Up1TbNvu11FiN/UJfjru3Ax/piQlGPDcw5Yqiyb2Se+tdl3iu/aQV5417hLdPkdLcaFhVO2UYjQ==",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("BookCategory", b =>
                {
                    b.HasOne("Library.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Library.Entities.Review", b =>
                {
                    b.HasOne("Library.Entities.Book", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Library.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Library.Entities.Book", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
