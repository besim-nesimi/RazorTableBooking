﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TableBooking.Data;

#nullable disable

namespace TableBooking.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TableBooking.Models.TableModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsBooked")
                        .HasColumnType("bit");

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.Property<int>("TableNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IsBooked = false,
                            NumberOfSeats = 4,
                            TableNumber = 100
                        },
                        new
                        {
                            Id = 2,
                            IsBooked = false,
                            NumberOfSeats = 6,
                            TableNumber = 101
                        },
                        new
                        {
                            Id = 3,
                            IsBooked = false,
                            NumberOfSeats = 8,
                            TableNumber = 102
                        },
                        new
                        {
                            Id = 4,
                            IsBooked = false,
                            NumberOfSeats = 4,
                            TableNumber = 103
                        },
                        new
                        {
                            Id = 5,
                            IsBooked = false,
                            NumberOfSeats = 4,
                            TableNumber = 104
                        },
                        new
                        {
                            Id = 6,
                            IsBooked = false,
                            NumberOfSeats = 8,
                            TableNumber = 105
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
