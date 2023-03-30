﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SD_340_F22SD_Lab_Intro_To_APIs.Data;

#nullable disable

namespace SD_340_F22SD_Lab_Intro_To_APIs.Migrations
{
    [DbContext(typeof(WinnipegTransitAPIContext))]
    partial class WinnipegTransitAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SD_340_F22SD_Lab_Intro_To_APIs.Models.Route", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Number"), 1L, 1);

                    b.Property<bool>("BicycleAccessible")
                        .HasColumnType("bit");

                    b.Property<int>("Direction")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("RampAccessible")
                        .HasColumnType("bit");

                    b.HasKey("Number");

                    b.ToTable("Route");
                });

            modelBuilder.Entity("SD_340_F22SD_Lab_Intro_To_APIs.Models.ScheduledStop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("RouteNumber")
                        .HasColumnType("int");

                    b.Property<DateTime>("ScheduledArrival")
                        .HasColumnType("datetime2");

                    b.Property<int>("StopNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RouteNumber");

                    b.HasIndex("StopNumber");

                    b.ToTable("ScheduledStop");
                });

            modelBuilder.Entity("SD_340_F22SD_Lab_Intro_To_APIs.Models.Stop", b =>
                {
                    b.Property<int>("Number")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Number"), 1L, 1);

                    b.Property<int>("Direction")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Number");

                    b.ToTable("Stop");
                });

            modelBuilder.Entity("SD_340_F22SD_Lab_Intro_To_APIs.Models.ScheduledStop", b =>
                {
                    b.HasOne("SD_340_F22SD_Lab_Intro_To_APIs.Models.Route", "Route")
                        .WithMany("ScheduledStops")
                        .HasForeignKey("RouteNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SD_340_F22SD_Lab_Intro_To_APIs.Models.Stop", "Stop")
                        .WithMany("ScheduledStops")
                        .HasForeignKey("StopNumber")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Route");

                    b.Navigation("Stop");
                });

            modelBuilder.Entity("SD_340_F22SD_Lab_Intro_To_APIs.Models.Route", b =>
                {
                    b.Navigation("ScheduledStops");
                });

            modelBuilder.Entity("SD_340_F22SD_Lab_Intro_To_APIs.Models.Stop", b =>
                {
                    b.Navigation("ScheduledStops");
                });
#pragma warning restore 612, 618
        }
    }
}
