﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelLog.Data;

namespace TravelLog.Migrations
{
    [DbContext(typeof(RecordContext))]
    [Migration("20221230072043_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TravelLog.Models.Record", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdvanceAmount")
                        .HasColumnType("int");

                    b.Property<int>("BalanceAmount")
                        .HasColumnType("int");

                    b.Property<string>("BusNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClosingKm")
                        .HasColumnType("int");

                    b.Property<int>("Expenses")
                        .HasColumnType("int");

                    b.Property<DateTime>("FromDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("StartingKm")
                        .HasColumnType("int");

                    b.Property<DateTime>("ToDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalKm")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Records");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdvanceAmount = 1000,
                            BalanceAmount = 500,
                            BusNo = "123",
                            ClosingKm = 100,
                            Expenses = 500,
                            FromDate = new DateTime(2022, 12, 30, 12, 50, 42, 909, DateTimeKind.Local).AddTicks(2261),
                            StartingKm = 0,
                            ToDate = new DateTime(2022, 12, 30, 12, 50, 42, 911, DateTimeKind.Local).AddTicks(283),
                            TotalKm = 100
                        },
                        new
                        {
                            Id = 2,
                            AdvanceAmount = 2000,
                            BalanceAmount = 1000,
                            BusNo = "456",
                            ClosingKm = 200,
                            Expenses = 1000,
                            FromDate = new DateTime(2022, 12, 30, 12, 50, 42, 911, DateTimeKind.Local).AddTicks(3019),
                            StartingKm = 0,
                            ToDate = new DateTime(2022, 12, 30, 12, 50, 42, 911, DateTimeKind.Local).AddTicks(3040),
                            TotalKm = 200
                        });
                });
#pragma warning restore 612, 618
        }
    }
}