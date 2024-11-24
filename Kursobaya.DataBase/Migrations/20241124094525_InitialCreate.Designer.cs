﻿// <auto-generated />
using System;
using Kursobaya.Storage.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Kursobaya.Storage.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20241124094525_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Kursobaya.Storage.Models.Detail", b =>
                {
                    b.Property<Guid>("DetailCode")
                        .HasColumnType("uuid");

                    b.Property<string>("DetailType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("Khl")
                        .HasColumnType("double precision");

                    b.Property<double>("U")
                        .HasColumnType("double precision");

                    b.Property<Guid>("UnitCode")
                        .HasColumnType("uuid");

                    b.Property<double>("Vm")
                        .HasColumnType("double precision");

                    b.Property<double>("Zh")
                        .HasColumnType("double precision");

                    b.Property<double>("Zm")
                        .HasColumnType("double precision");

                    b.Property<double>("delta_h")
                        .HasColumnType("double precision");

                    b.Property<double>("dm1")
                        .HasColumnType("double precision");

                    b.Property<double>("sigma")
                        .HasColumnType("double precision");

                    b.HasKey("DetailCode");

                    b.HasIndex("UnitCode");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("Kursobaya.Storage.Models.Unit", b =>
                {
                    b.Property<Guid>("UnitCode")
                        .HasColumnType("uuid");

                    b.Property<double>("Ea")
                        .HasColumnType("double precision");

                    b.Property<double>("Ft")
                        .HasColumnType("double precision");

                    b.Property<double>("Kh")
                        .HasColumnType("double precision");

                    b.Property<double>("Kha")
                        .HasColumnType("double precision");

                    b.Property<double>("Khb")
                        .HasColumnType("double precision");

                    b.Property<double>("Khv")
                        .HasColumnType("double precision");

                    b.Property<double>("Re")
                        .HasColumnType("double precision");

                    b.Property<string>("Reliability")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("SigmaH")
                        .HasColumnType("double precision");

                    b.Property<double>("SigmaHP")
                        .HasColumnType("double precision");

                    b.Property<double>("b")
                        .HasColumnType("double precision");

                    b.Property<double>("g0")
                        .HasColumnType("double precision");

                    b.HasKey("UnitCode");

                    b.ToTable("Units");
                });
#pragma warning restore 612, 618
        }
    }
}
