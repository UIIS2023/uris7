﻿// <auto-generated />
using System;
using Licitacija.Services.UplataAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Licitacija.Services.UplataAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230218140703_UplataMigrate")]
    partial class UplataMigrate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Licitacija.Services.UplataAPI.Entities.Kurs", b =>
                {
                    b.Property<Guid>("KursId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DatumKursa")
                        .HasColumnType("datetime2");

                    b.Property<string>("Valuta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Vrednost")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("KursId");

                    b.ToTable("Kurs");
                });

            modelBuilder.Entity("Licitacija.Services.UplataAPI.Entities.Uplata", b =>
                {
                    b.Property<Guid>("UplataId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BrojRacuna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumUplate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Iznos")
                        .HasColumnType("decimal(18,4)");

                    b.Property<Guid>("KupacId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("KursId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PozivNaBroj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SvrhaUplate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UplataId");

                    b.HasIndex("KursId");

                    b.ToTable("Uplata");
                });

            modelBuilder.Entity("Licitacija.Services.UplataAPI.Entities.Uplata", b =>
                {
                    b.HasOne("Licitacija.Services.UplataAPI.Entities.Kurs", "Kurs")
                        .WithMany("Uplate")
                        .HasForeignKey("KursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kurs");
                });

            modelBuilder.Entity("Licitacija.Services.UplataAPI.Entities.Kurs", b =>
                {
                    b.Navigation("Uplate");
                });
#pragma warning restore 612, 618
        }
    }
}
