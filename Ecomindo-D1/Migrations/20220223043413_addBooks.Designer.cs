﻿// <auto-generated />
using Ecomindo_D1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecomindo_D1.Migrations
{
    [DbContext(typeof(OnBoardingSkdDbContext))]
    [Migration("20220223043413_addBooks")]
    partial class addBooks
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecomindo_D1.Model.Menu", b =>
                {
                    b.Property<int>("idMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("hargaMenu")
                        .HasColumnType("int");

                    b.Property<string>("namaMenu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMenu");

                    b.ToTable("Menu");
                });
#pragma warning restore 612, 618
        }
    }
}
