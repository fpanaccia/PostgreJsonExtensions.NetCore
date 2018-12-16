﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestStudio;

namespace TestStudio.Migrations
{
    [DbContext(typeof(TestContext))]
    [Migration("20181216190321_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("TestStudio.Entities.Test", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnName("id");

                    b.Property<string>("Json")
                        .IsRequired()
                        .HasColumnName("json")
                        .HasColumnType("jsonb");

                    b.Property<string>("Json2")
                        .IsRequired()
                        .HasColumnName("json2")
                        .HasColumnType("jsonb");

                    b.HasKey("Id");

                    b.ToTable("Test","Test");

                    b.HasData(
                        new
                        {
                            Id = new Guid("086b558f-bb80-8645-bc05-27ec1b17b005"),
                            Json = "{\"Str\":\"1234\",\"Fecha\":{\"Date\":\"0001-01-01T00:00:00\"},\"Num\":456.0,\"Logico\":true}",
                            Json2 = "{\"Str\":\"1234\",\"Fecha\":{\"Date\":\"0001-01-01T00:00:00\"},\"Num\":456.0,\"Logico\":true}"
                        },
                        new
                        {
                            Id = new Guid("6a250b45-f183-844a-a5dd-feb33be7f250"),
                            Json = "{\"Str\":\"0456\",\"Fecha\":{\"Date\":\"9999-12-31T23:59:59.9999999\"},\"Num\":789.0,\"Logico\":false}",
                            Json2 = "{\"Str\":\"0456\",\"Fecha\":{\"Date\":\"9999-12-31T23:59:59.9999999\"},\"Num\":789.0,\"Logico\":false}"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
