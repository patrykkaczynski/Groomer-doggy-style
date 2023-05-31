﻿// <auto-generated />
using System;
using GroomerDoggyStyle.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GroomerDoggyStyle.Infrastructure.Migrations
{
    [DbContext(typeof(GroomerDoggyStyleDbContext))]
    [Migration("20230530115949_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("BuildingNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("Breed")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("OwnerId")
                        .HasColumnType("integer");

                    b.Property<int>("Sex")
                        .HasColumnType("integer");

                    b.Property<int>("Weight")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("GroomerShopId")
                        .HasColumnType("integer");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Mail")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PositionType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GroomerShopId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.GroomerShop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("integer");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("GroomerShops");
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DurationTimeInMinutes")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("WeightType")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Mail")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.Visit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateOfVisit")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DogId")
                        .HasColumnType("integer");

                    b.Property<int>("DurationInMinutes")
                        .HasColumnType("integer");

                    b.Property<int>("GroomerShopId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DogId");

                    b.HasIndex("GroomerShopId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("GroomerShopOffer", b =>
                {
                    b.Property<int>("GroomerShopsId")
                        .HasColumnType("integer");

                    b.Property<int>("OffersId")
                        .HasColumnType("integer");

                    b.HasKey("GroomerShopsId", "OffersId");

                    b.HasIndex("OffersId");

                    b.ToTable("GroomerShopOffer");
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.Dog", b =>
                {
                    b.HasOne("GroomerDoggyStyle.Domain.Entities.Owner", "Owner")
                        .WithMany("Dogs")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.Employee", b =>
                {
                    b.HasOne("GroomerDoggyStyle.Domain.Entities.GroomerShop", "GroomerShop")
                        .WithMany("Employees")
                        .HasForeignKey("GroomerShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroomerShop");
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.GroomerShop", b =>
                {
                    b.HasOne("GroomerDoggyStyle.Domain.Entities.Address", "Address")
                        .WithOne("GroomerShop")
                        .HasForeignKey("GroomerDoggyStyle.Domain.Entities.GroomerShop", "AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.Visit", b =>
                {
                    b.HasOne("GroomerDoggyStyle.Domain.Entities.Dog", "Dog")
                        .WithMany("Visits")
                        .HasForeignKey("DogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroomerDoggyStyle.Domain.Entities.GroomerShop", "GroomerShop")
                        .WithMany("Visits")
                        .HasForeignKey("GroomerShopId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dog");

                    b.Navigation("GroomerShop");
                });

            modelBuilder.Entity("GroomerShopOffer", b =>
                {
                    b.HasOne("GroomerDoggyStyle.Domain.Entities.GroomerShop", null)
                        .WithMany()
                        .HasForeignKey("GroomerShopsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroomerDoggyStyle.Domain.Entities.Offer", null)
                        .WithMany()
                        .HasForeignKey("OffersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.Address", b =>
                {
                    b.Navigation("GroomerShop");
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.Dog", b =>
                {
                    b.Navigation("Visits");
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.GroomerShop", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Visits");
                });

            modelBuilder.Entity("GroomerDoggyStyle.Domain.Entities.Owner", b =>
                {
                    b.Navigation("Dogs");
                });
#pragma warning restore 612, 618
        }
    }
}