﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SoulsDB.Data.Database;

#nullable disable

namespace SoulsDB.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240312071023_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SoulsDB.Data.Entities.NormWeapReinfMultiplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<float>("DEXScaling")
                        .HasColumnType("real");

                    b.Property<float>("FAIScaling")
                        .HasColumnType("real");

                    b.Property<float>("FireAR")
                        .HasColumnType("real");

                    b.Property<float>("INTScaling")
                        .HasColumnType("real");

                    b.Property<float>("LightningAR")
                        .HasColumnType("real");

                    b.Property<float>("MagicAR")
                        .HasColumnType("real");

                    b.Property<float>("PhysicalAR")
                        .HasColumnType("real");

                    b.Property<float>("STRScaling")
                        .HasColumnType("real");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte>("UpgradeLevel")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("normWeapReinfMultipliers");
                });
#pragma warning restore 612, 618
        }
    }
}
