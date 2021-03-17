﻿// <auto-generated />
using System;
using LaytonTempleTours.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LaytonTempleTours.Migrations
{
    [DbContext(typeof(TourDbContext))]
    partial class TourDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13");

            modelBuilder.Entity("LaytonTempleTours.Models.AvailableTime", b =>
                {
                    b.Property<int>("AvailableTimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AppointementTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("SlotBooked")
                        .HasColumnType("INTEGER");

                    b.HasKey("AvailableTimeId");

                    b.ToTable("AvailableTimes");
                });

            modelBuilder.Entity("LaytonTempleTours.Models.GroupInfo", b =>
                {
                    b.Property<int>("GroupInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("Size")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TimeSlot")
                        .HasColumnType("TEXT");

                    b.HasKey("GroupInfoId");

                    b.ToTable("GroupInfos");
                });
#pragma warning restore 612, 618
        }
    }
}
