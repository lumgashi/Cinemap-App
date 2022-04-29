﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220420141557_MovieUpdate")]
    partial class MovieUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Domain.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieCover")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieDuration")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieGenre")
                        .HasColumnType("TEXT");

                    b.Property<double>("MovieIMDB")
                        .HasColumnType("REAL");

                    b.Property<string>("MoviePhoto")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieQuality")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("MovieReleaseDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieTitle")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieTrailer")
                        .HasColumnType("TEXT");

                    b.Property<int>("MovieUserVote")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isTvSHow")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
