﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Plugins.Datastor.SQL;

#nullable disable

namespace Plugins.Datastor.SQL.Migrations
{
    [DbContext(typeof(MarketContext))]
    partial class MarketContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CoreBusiness.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Description = "Computers, Phones and all electronic machines from office to home.",
                            Name = "Electronic"
                        },
                        new
                        {
                            CategoryId = 2,
                            Description = "all what a men need to steal eyes.",
                            Name = "Men's Fashion"
                        },
                        new
                        {
                            CategoryId = 3,
                            Description = "Women's Fashion ... we got her cover ",
                            Name = "Women's Fashion"
                        },
                        new
                        {
                            CategoryId = 4,
                            Description = "Home and pet ",
                            Name = "Home & Pets"
                        });
                });

            modelBuilder.Entity("CoreBusiness.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Price")
                        .IsRequired()
                        .HasColumnType("float");

                    b.Property<int?>("Quantity")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Name = "Iphone 8",
                            Price = 9500.0,
                            Quantity = 100
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Name = "hp laptop",
                            Price = 3700.0,
                            Quantity = 25
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Name = "Keyboard",
                            Price = 550.0,
                            Quantity = 200
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Name = "Hat",
                            Price = 50.0,
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            Name = "Watch",
                            Price = 1500.0,
                            Quantity = 45
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            Name = "jeans",
                            Price = 300.0,
                            Quantity = 300
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            Name = "silver ring",
                            Price = 250.0,
                            Quantity = 70
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3,
                            Name = "Bras",
                            Price = 34.0,
                            Quantity = 500
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 3,
                            Name = "Pajamas sets",
                            Price = 220.0,
                            Quantity = 20
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 4,
                            Name = "Wall Stickers",
                            Price = 270.0,
                            Quantity = 50
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 4,
                            Name = "Dog Toys",
                            Price = 20.0,
                            Quantity = 200
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 4,
                            Name = "Umbrellas",
                            Price = 70.0,
                            Quantity = 60
                        });
                });

            modelBuilder.Entity("CoreBusiness.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransactionId"), 1L, 1);

                    b.Property<int>("BeforeQty")
                        .HasColumnType("int");

                    b.Property<string>("CashierName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoldQty")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("TransactionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("CoreBusiness.Product", b =>
                {
                    b.HasOne("CoreBusiness.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("CoreBusiness.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}