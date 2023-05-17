﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace Models.Migrations
{
    [DbContext(typeof(MyAppDbContext))]
    [Migration("20230515120102_dbcreate")]
    partial class dbcreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Location.CountryTbl", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("countryTbls");
                });

            modelBuilder.Entity("Models.Location.StateTbl", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StateId"));

                    b.Property<int?>("CountryTblCountryId")
                        .HasColumnType("int");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fkContryId")
                        .HasColumnType("int");

                    b.HasKey("StateId");

                    b.HasIndex("CountryTblCountryId");

                    b.ToTable("stateTbls");
                });

            modelBuilder.Entity("Models.Location.StateTbl", b =>
                {
                    b.HasOne("Models.Location.CountryTbl", null)
                        .WithMany("StateTbl")
                        .HasForeignKey("CountryTblCountryId");
                });

            modelBuilder.Entity("Models.Location.CountryTbl", b =>
                {
                    b.Navigation("StateTbl");
                });
#pragma warning restore 612, 618
        }
    }
}
