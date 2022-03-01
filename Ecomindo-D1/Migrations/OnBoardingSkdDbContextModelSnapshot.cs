﻿// <auto-generated />
using System;
using Ecomindo_D1.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Ecomindo_D1.Migrations
{
    [DbContext(typeof(OnBoardingSkdDbContext))]
    partial class OnBoardingSkdDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ecomindo_D1.Model.Menu", b =>
                {
                    b.Property<Guid>("idMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("hargaMenu")
                        .HasColumnType("int");

                    b.Property<Guid>("idRestaurant")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("namaMenu")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idMenu");

                    b.HasIndex("idRestaurant");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Ecomindo_D1.Model.Restaurant", b =>
                {
                    b.Property<Guid>("idRestaurant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("namaRestaurant")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idRestaurant");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("Ecomindo_D1.Model.Menu", b =>
                {
                    b.HasOne("Ecomindo_D1.Model.Restaurant", "Restaurant")
                        .WithMany("Menus")
                        .HasForeignKey("idRestaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("Ecomindo_D1.Model.Restaurant", b =>
                {
                    b.Navigation("Menus");
                });
#pragma warning restore 612, 618
        }
    }
}
