﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockManager.Domain.Context;

namespace StockManager.Domain.Migrations
{
    [DbContext(typeof(StockContext))]
    [Migration("20210303011507_2021-03-03")]
    partial class _20210303
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StockManager.Domain.Entities.Product", b =>
                {
                    b.Property<string>("SN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SN");

                    b.ToTable("Stock_product");
                });

            modelBuilder.Entity("StockManager.Domain.Entities.UniqueNo", b =>
                {
                    b.Property<int>("Unique_No")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Unique_No");

                    b.ToTable("Unique_No");
                });
#pragma warning restore 612, 618
        }
    }
}
