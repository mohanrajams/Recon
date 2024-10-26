﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Recon.Data.Context;

#nullable disable

namespace Recon.Data.Migrations
{
    [DbContext(typeof(ReconDbContext))]
    [Migration("20241026145516_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Recon.Data.Models.Master.LookUp", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<long>("LookUpCategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("LookUpCategoryId");

                    b.ToTable("LookUps");
                });

            modelBuilder.Entity("Recon.Data.Models.Master.LookupCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LookupCategories");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Name = "Provider"
                        },
                        new
                        {
                            Id = 2L,
                            Name = "Product"
                        });
                });

            modelBuilder.Entity("Recon.Data.Models.Master.LookUp", b =>
                {
                    b.HasOne("Recon.Data.Models.Master.LookupCategory", "LookUpCategory")
                        .WithMany("LookUps")
                        .HasForeignKey("LookUpCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LookUpCategory");
                });

            modelBuilder.Entity("Recon.Data.Models.Master.LookupCategory", b =>
                {
                    b.Navigation("LookUps");
                });
#pragma warning restore 612, 618
        }
    }
}
