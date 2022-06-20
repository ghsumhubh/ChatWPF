﻿// <auto-generated />
using System;
using ChatWebsite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChatWebsite.Migrations
{
    [DbContext(typeof(WebApp1Context))]
    [Migration("20220614221649_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WebApplication1.Models.Contact", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ServerAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id", "UserId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("WebApplication1.Models.Rating", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DateTime")
                        .HasColumnType("longtext");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Score")
                        .HasColumnType("longtext");

                    b.HasKey("ID");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("WebApplication1.Models.TextMessage", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ContactId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("UserSent")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id", "UserId", "ContactId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("WebApplication1.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
