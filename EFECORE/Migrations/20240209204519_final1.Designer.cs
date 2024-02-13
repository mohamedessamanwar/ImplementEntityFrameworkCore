﻿// <auto-generated />
using System;
using EFECORE;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFECORE.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240209204519_final1")]
    partial class final1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("hr")
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence<int>("OrderNuber", "Shared")
                .StartsAt(100L)
                .IncrementsBy(10);

            modelBuilder.Entity("EFECORE.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"));

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("CarId");

                    b.HasAlternateKey("LicensePlate");

                    b.ToTable("Cars", "hr");
                });

            modelBuilder.Entity("EFECORE.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DisplayName")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)")
                        .HasComputedColumnSql("[FirstName]+','+[LastName]");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Authors", "hr");
                });

            modelBuilder.Entity("EFECORE.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BlogId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<decimal>("Rating")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(5,2)")
                        .HasDefaultValue(5m);

                    b.Property<string>("Url")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(100)")
                        .HasDefaultValue(" ")
                        .HasColumnName("blogurl")
                        .HasComment("the url2 of the Blog Table from fluent api");

                    b.HasKey("Id")
                        .HasName("Pk-Blog");

                    b.HasIndex("Url")
                        .IsUnique()
                        .HasDatabaseName("index-name");

                    b.HasIndex(new[] { "Url" }, "index_name");

                    b.ToTable("Blogs", "hr");

                    b.ToView("ViewNameFromDb", "hr");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 0m,
                            Url = "http://sample.com/blogs/sample-1"
                        },
                        new
                        {
                            Id = 2,
                            CreateOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 0m,
                            Url = "http://sample.com/blogs/sample-2"
                        },
                        new
                        {
                            Id = 3,
                            CreateOn = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Rating = 0m,
                            Url = "http://sample.com/blogs/sample-3"
                        });
                });

            modelBuilder.Entity("EFECORE.Models.BlogImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Caption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogId")
                        .IsUnique();

                    b.ToTable("BlogImage", "hr");
                });

            modelBuilder.Entity("EFECORE.Models.Category", b =>
                {
                    b.Property<byte>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<byte>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categories", "hr");
                });

            modelBuilder.Entity("EFECORE.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<long>("OrderNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("NEXT VALUE FOR Shared.OrderNuber");

                    b.HasKey("OrderId");

                    b.ToTable("Orders", "hr");
                });

            modelBuilder.Entity("EFECORE.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("FirstName", "LastName");

                    b.ToTable("Persons", "hr");
                });

            modelBuilder.Entity("EFECORE.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BlogId")
                        .HasColumnType("int");

                    b.Property<int?>("BlogId1")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("BlogId1");

                    b.ToTable("Posts", "hr");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlogId = 1,
                            Title = "Post 1"
                        },
                        new
                        {
                            Id = 2,
                            BlogId = 1,
                            Title = "Post 2"
                        },
                        new
                        {
                            Id = 3,
                            BlogId = 1,
                            Title = "Post 3"
                        },
                        new
                        {
                            Id = 4,
                            BlogId = 2,
                            Title = "Post 4"
                        },
                        new
                        {
                            Id = 5,
                            BlogId = 2,
                            Title = "Post 5"
                        },
                        new
                        {
                            Id = 6,
                            BlogId = 2,
                            Title = "Post 6"
                        },
                        new
                        {
                            Id = 7,
                            BlogId = 3,
                            Title = "Post 7"
                        },
                        new
                        {
                            Id = 8,
                            BlogId = 3,
                            Title = "Post 8"
                        },
                        new
                        {
                            Id = 9,
                            BlogId = 3,
                            Title = "Post 9"
                        });
                });

            modelBuilder.Entity("EFECORE.Models.PostTag", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AddedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.HasKey("PostId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("PostTag", "hr");
                });

            modelBuilder.Entity("EFECORE.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TagId"));

                    b.HasKey("TagId");

                    b.ToTable("Tag", "hr");
                });

            modelBuilder.Entity("EFECORE.RecordOfSales", b =>
                {
                    b.Property<int>("RecordOfSalesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RecordOfSalesId"));

                    b.Property<string>("CarLicensePlate")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CarState")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateSold")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("RecordOfSalesId");

                    b.HasIndex("CarLicensePlate", "CarState");

                    b.ToTable("RecordOfSales", "hr");
                });

            modelBuilder.Entity("EFECORE.Models.BlogImage", b =>
                {
                    b.HasOne("EFECORE.Models.Blog", "Blog")
                        .WithOne("BlogImage")
                        .HasForeignKey("EFECORE.Models.BlogImage", "BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("EFECORE.Models.Post", b =>
                {
                    b.HasOne("EFECORE.Models.Blog", null)
                        .WithMany()
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Posts_Blog_Test");

                    b.HasOne("EFECORE.Models.Blog", "Blog")
                        .WithMany("Posts")
                        .HasForeignKey("BlogId1")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("EFECORE.Models.PostTag", b =>
                {
                    b.HasOne("EFECORE.Models.Post", "Post")
                        .WithMany("postTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFECORE.Models.Tag", "Tag")
                        .WithMany("postTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("EFECORE.RecordOfSales", b =>
                {
                    b.HasOne("EFECORE.Car", "Car")
                        .WithMany("SaleHistory")
                        .HasForeignKey("CarLicensePlate", "CarState")
                        .HasPrincipalKey("LicensePlate", "State");

                    b.Navigation("Car");
                });

            modelBuilder.Entity("EFECORE.Car", b =>
                {
                    b.Navigation("SaleHistory");
                });

            modelBuilder.Entity("EFECORE.Models.Blog", b =>
                {
                    b.Navigation("BlogImage");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("EFECORE.Models.Post", b =>
                {
                    b.Navigation("postTags");
                });

            modelBuilder.Entity("EFECORE.Models.Tag", b =>
                {
                    b.Navigation("postTags");
                });
#pragma warning restore 612, 618
        }
    }
}