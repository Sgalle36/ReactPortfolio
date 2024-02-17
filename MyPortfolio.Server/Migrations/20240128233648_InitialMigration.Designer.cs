﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyPortfolio.Server.Data;

#nullable disable

namespace MyPortfolio.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240128233648_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyPortfolio.Server.Data.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 1, 28, 16, 36, 48, 803, DateTimeKind.Local).AddTicks(2569),
                            Description = "An application with an ASP.NET API backend and React frontend.",
                            Name = "My Portfolio",
                            UpdatedAt = new DateTime(2024, 1, 28, 16, 36, 48, 803, DateTimeKind.Local).AddTicks(2614)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 1, 28, 16, 36, 48, 803, DateTimeKind.Local).AddTicks(2617),
                            Description = "An ecommerce store built using the ASP.NET framework with Razor pages.",
                            Name = "Cheaper by the Dozen",
                            UpdatedAt = new DateTime(2024, 1, 28, 16, 36, 48, 803, DateTimeKind.Local).AddTicks(2618)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}