﻿// <auto-generated />
using System;
using GuitarShop.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GuitarShop.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200207105626_NapravljenaNovaBaza")]
    partial class NapravljenaNovaBaza
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GuitarShop.Shared.Models.Guitar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GuitarBillId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GuitarBillId");

                    b.ToTable("Guitars");
                });

            modelBuilder.Entity("GuitarShop.Shared.Models.GuitarBill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("GuitarBills");
                });

            modelBuilder.Entity("GuitarShop.Shared.Models.Guitar", b =>
                {
                    b.HasOne("GuitarShop.Shared.Models.GuitarBill", null)
                        .WithMany("Guitars")
                        .HasForeignKey("GuitarBillId");
                });
#pragma warning restore 612, 618
        }
    }
}
