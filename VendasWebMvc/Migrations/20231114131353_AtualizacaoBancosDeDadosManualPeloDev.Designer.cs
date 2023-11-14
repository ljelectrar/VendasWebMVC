﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VendasWebMvc.Data;

namespace VendasWebMvc.Migrations
{
    [DbContext(typeof(VendasWebMvcContext))]
    [Migration("20231114131353_AtualizacaoBancosDeDadosManualPeloDev")]
    partial class AtualizacaoBancosDeDadosManualPeloDev
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("VendasWebMvc.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("VendasWebMvc.Models.SalesRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int?>("SellerId");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("SellerId");

                    b.ToTable("SalesRecord");
                });

            modelBuilder.Entity("VendasWebMvc.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BaseSalary");

                    b.Property<DateTime>("BirthDay");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<int?>("departmentId");

                    b.HasKey("Id");

                    b.HasIndex("departmentId");

                    b.ToTable("Seller");
                });

            modelBuilder.Entity("VendasWebMvc.Models.SalesRecord", b =>
                {
                    b.HasOne("VendasWebMvc.Models.Seller", "Seller")
                        .WithMany("Sales")
                        .HasForeignKey("SellerId");
                });

            modelBuilder.Entity("VendasWebMvc.Models.Seller", b =>
                {
                    b.HasOne("VendasWebMvc.Models.Department", "department")
                        .WithMany("Sellers")
                        .HasForeignKey("departmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
