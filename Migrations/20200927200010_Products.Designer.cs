﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using snscz_api.Helpers;

namespace snscz_api.Migrations
{
    [DbContext(typeof(SnsContext))]
    [Migration("20200927200010_Products")]
    partial class Products
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("snscz_api.Models.Allergens", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AllergenName")
                        .HasColumnType("text");

                    b.Property<int?>("ProductsId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductsId");

                    b.ToTable("Allergens");
                });

            modelBuilder.Entity("snscz_api.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.Property<int>("ParentCategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("SortOrder")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("snscz_api.Models.Composition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<float>("Carbohydrate")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<float>("EnergyValue")
                        .HasColumnType("real");

                    b.Property<float>("Fat")
                        .HasColumnType("real");

                    b.Property<float>("Fiber")
                        .HasColumnType("real");

                    b.Property<float>("Protein")
                        .HasColumnType("real");

                    b.Property<float>("Salt")
                        .HasColumnType("real");

                    b.Property<float>("SaturatedAccids")
                        .HasColumnType("real");

                    b.Property<float>("Sugar")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Compositions");
                });

            modelBuilder.Entity("snscz_api.Models.Images", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("bytea");

                    b.Property<string>("ImageTitle")
                        .HasColumnType("text");

                    b.Property<Guid>("ImgGuid")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("snscz_api.Models.Manufacturer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("ManufacturerName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("snscz_api.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("CompositionId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("ImageId")
                        .HasColumnType("integer");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("integer");

                    b.Property<float>("OurPrice")
                        .HasColumnType("real");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<float>("PricePerFullVolume")
                        .HasColumnType("real");

                    b.Property<string>("ProductCode")
                        .HasColumnType("text");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<string>("StorageConditions")
                        .HasColumnType("text");

                    b.Property<float>("Volume")
                        .HasColumnType("real");

                    b.Property<int>("VolumeTypeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("snscz_api.Models.VolumeType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("VolumeCode")
                        .HasColumnType("text");

                    b.Property<string>("VolumeName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("VolumeTypes");
                });

            modelBuilder.Entity("snscz_api.Models.Allergens", b =>
                {
                    b.HasOne("snscz_api.Models.Products", null)
                        .WithMany("Allergens")
                        .HasForeignKey("ProductsId");
                });
#pragma warning restore 612, 618
        }
    }
}
