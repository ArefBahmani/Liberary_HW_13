﻿// <auto-generated />
using System;
using Liberary_HW_13;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Liberary_HW_13.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241121205245_aref")]
    partial class aref
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Liberary_HW_13.Entityes.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsBorrowed")
                        .HasColumnType("bit");

                    b.Property<int>("Pages")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Writer")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateTime = new DateTime(2024, 11, 22, 0, 22, 45, 103, DateTimeKind.Local).AddTicks(8827),
                            Discription = "Hichi",
                            IsBorrowed = false,
                            Pages = 1000,
                            Titel = "C#",
                            Writer = "Aref"
                        },
                        new
                        {
                            Id = 2,
                            DateTime = new DateTime(2024, 11, 22, 0, 22, 45, 103, DateTimeKind.Local).AddTicks(8881),
                            Discription = "100 Hours Tutaial",
                            IsBorrowed = false,
                            Pages = 100,
                            Titel = "SQL",
                            Writer = "hosein"
                        },
                        new
                        {
                            Id = 3,
                            DateTime = new DateTime(2024, 11, 22, 0, 22, 45, 103, DateTimeKind.Local).AddTicks(8902),
                            Discription = "salam halet khobe>?",
                            IsBorrowed = false,
                            Pages = 2000,
                            Titel = "Java",
                            Writer = "javad"
                        },
                        new
                        {
                            Id = 4,
                            DateTime = new DateTime(2024, 11, 22, 0, 22, 45, 103, DateTimeKind.Local).AddTicks(8916),
                            Discription = "Mamnon merc",
                            IsBorrowed = false,
                            Pages = 1250,
                            Titel = "Django",
                            Writer = "saeid"
                        },
                        new
                        {
                            Id = 5,
                            DateTime = new DateTime(2024, 11, 22, 0, 22, 45, 103, DateTimeKind.Local).AddTicks(8929),
                            Discription = "Chekhabara?",
                            IsBorrowed = false,
                            Pages = 444,
                            Titel = "Java_Script",
                            Writer = "masoud"
                        },
                        new
                        {
                            Id = 6,
                            DateTime = new DateTime(2024, 11, 22, 0, 22, 45, 103, DateTimeKind.Local).AddTicks(8946),
                            Discription = "Salamati to khobi?",
                            IsBorrowed = false,
                            Pages = 10,
                            Titel = "C++",
                            Writer = "rasool"
                        });
                });

            modelBuilder.Entity("Liberary_HW_13.Entityes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("RoleEnum")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Liberary_HW_13.Entityes.Book", b =>
                {
                    b.HasOne("Liberary_HW_13.Entityes.User", "User")
                        .WithMany("Books")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Liberary_HW_13.Entityes.User", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
