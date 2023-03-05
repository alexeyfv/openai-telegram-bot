﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OpenAiBot.DataAccess;

#nullable disable

namespace OpenAiBot.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230304175449_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("OpenAiBot.DataAccess.Rule", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxRequests")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxTokenProcessed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Unrestricted")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Rules");

                    b.HasData(
                        new
                        {
                            Id = 9223372036854775807L,
                            MaxRequests = 50,
                            MaxTokenProcessed = 2056,
                            Unrestricted = false
                        });
                });

            modelBuilder.Entity("OpenAiBot.DataAccess.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("HasUnlimited")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Requests")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TokensProcessed")
                        .IsConcurrencyToken()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
