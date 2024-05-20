﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P02_SalesDatabase.Data;

#nullable disable

namespace P02_SalesDatabase.Migrations
{
    [DbContext(typeof(SalesContext))]
    [Migration("20240518110219_SalesAddDateDefault")]
    partial class SalesAddDateDefault
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P02_SalesDatabase.Models.Customers", b =>
                {
                    b.Property<int>("CustomersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomersId"));

                    b.Property<string>("CreditCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CustomersId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("P02_SalesDatabase.Models.Products", b =>
                {
                    b.Property<int>("ProductsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductsId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ProductsId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("P02_SalesDatabase.Models.Sales", b =>
                {
                    b.Property<int>("SalesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesId"));

                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<DateOnly?>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.Property<int>("StoresId")
                        .HasColumnType("int");

                    b.HasKey("SalesId");

                    b.HasIndex("CustomersId");

                    b.ToTable("Sale");
                });

            modelBuilder.Entity("P02_SalesDatabase.Models.Stores", b =>
                {
                    b.Property<int>("StoresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoresId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("StoresId");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("ProductSales", b =>
                {
                    b.Property<int>("SalesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("SalesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("ProductSales");
                });

            modelBuilder.Entity("StoresSales", b =>
                {
                    b.Property<int>("SalesId")
                        .HasColumnType("int");

                    b.Property<int>("StoresId")
                        .HasColumnType("int");

                    b.HasKey("SalesId", "StoresId");

                    b.HasIndex("StoresId");

                    b.ToTable("StoresSales");
                });

            modelBuilder.Entity("P02_SalesDatabase.Models.Sales", b =>
                {
                    b.HasOne("P02_SalesDatabase.Models.Customers", "customer")
                        .WithMany("sales")
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });

            modelBuilder.Entity("ProductSales", b =>
                {
                    b.HasOne("P02_SalesDatabase.Models.Products", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P02_SalesDatabase.Models.Sales", null)
                        .WithMany()
                        .HasForeignKey("SalesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StoresSales", b =>
                {
                    b.HasOne("P02_SalesDatabase.Models.Sales", null)
                        .WithMany()
                        .HasForeignKey("SalesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P02_SalesDatabase.Models.Stores", null)
                        .WithMany()
                        .HasForeignKey("StoresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("P02_SalesDatabase.Models.Customers", b =>
                {
                    b.Navigation("sales");
                });
#pragma warning restore 612, 618
        }
    }
}
