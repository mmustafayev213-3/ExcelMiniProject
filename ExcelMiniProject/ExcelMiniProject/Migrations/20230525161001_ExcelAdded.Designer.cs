﻿// <auto-generated />
using System;
using ExcelMiniProject.Data.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExcelMiniProject.Migrations
{
    [DbContext(typeof(ExcelDbContext))]
    [Migration("20230525161001_ExcelAdded")]
    partial class ExcelAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExcelMiniProject.Data.Models.ExcelProps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal?>("COGS")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiscountBand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Discounts")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GrossSales")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ManufacturingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Profit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Sales")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Segment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("UnitsSold")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("ExcelProps");
                });
#pragma warning restore 612, 618
        }
    }
}
