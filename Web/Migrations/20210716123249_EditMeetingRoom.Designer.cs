﻿// <auto-generated />
using System;
using System.Collections.Generic;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MeetingRoom.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210716123249_EditMeetingRoom")]
    partial class EditMeetingRoom
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "6.0.0-preview.5.21301.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("DataAccess.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AuthorOfBooking")
                        .HasColumnType("text");

                    b.Property<DateTime>("BookingEndTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("BookingStartTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("MeetingRoomId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("MeetingRoomId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("DataAccess.Models.MeetingRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Capacity")
                        .HasColumnType("integer");

                    b.Property<List<DateTime>>("Dates")
                        .HasColumnType("timestamp without time zone[]");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<List<int>>("TechnicalSupports")
                        .HasColumnType("integer[]");

                    b.HasKey("Id");

                    b.ToTable("MeetingRoom");
                });

            modelBuilder.Entity("DataAccess.Models.TechnicalSupport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TechnicalSupport");
                });

            modelBuilder.Entity("DataAccess.Models.Booking", b =>
                {
                    b.HasOne("DataAccess.Models.MeetingRoom", null)
                        .WithMany("Bookings")
                        .HasForeignKey("MeetingRoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataAccess.Models.MeetingRoom", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
