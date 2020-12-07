﻿// <auto-generated />
using Lab05.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Lab05.Migrations
{
    [DbContext(typeof(GearContext))]
    [Migration("20201206181852_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Lab05.Models.CharacterProgression", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("gearGoal")
                        .HasColumnType("int");

                    b.Property<int>("gearMeso")
                        .HasColumnType("int");

                    b.Property<string>("make")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("model")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Charc");
                });
#pragma warning restore 612, 618
        }
    }
}
