﻿// <auto-generated />
using ContentsLimitInsurace.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContentsLimitInsurace.Migrations
{
    [DbContext(typeof(ContentLimitContext))]
    [Migration("20200621214252_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContentsLimitInsurace.Models.ContentLimit", b =>
                {
                    b.Property<int>("ContentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("itemCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("itemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("itemValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ContentId");

                    b.ToTable("contents");
                });
#pragma warning restore 612, 618
        }
    }
}