﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MobileConnectionApp.DataBase.KazanOfficeDataBase;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace MobileConnectionApp.Migrations
{
    [DbContext(typeof(KazanOfficeContext))]
    [Migration("20221226224024_adaffffffffffff")]
    partial class adaffffffffffff
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("MobileConnectionApp.DataBase.KazanOfficeDataBase.Models.Contract", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateLastUpdate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("NumberId")
                        .HasColumnType("integer");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<int?>("SimId")
                        .HasColumnType("integer");

                    b.Property<int>("TarifId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SimId");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("MobileConnectionApp.DataBase.KazanOfficeDataBase.Models.Device", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Display")
                        .HasColumnType("text");

                    b.Property<string>("DisplayDiagonal")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<string>("Ram")
                        .HasColumnType("text");

                    b.Property<string>("Rom")
                        .HasColumnType("text");

                    b.Property<int>("StateId")
                        .HasColumnType("integer");

                    b.Property<int>("TypeDeviceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TypeDeviceId");

                    b.ToTable("Devices");
                });

            modelBuilder.Entity("MobileConnectionApp.DataBase.KazanOfficeDataBase.Models.Receipt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClientId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateSale")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("DeviceId")
                        .HasColumnType("integer");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DeviceId");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("MobileConnectionApp.DataBase.KazanOfficeDataBase.Models.Sim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<int>("StateId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Sims");
                });

            modelBuilder.Entity("MobileConnectionApp.DataBase.KazanOfficeDataBase.Models.TypeDeivce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TypeDevices");
                });

            modelBuilder.Entity("MobileConnectionApp.DataBase.KazanOfficeDataBase.Models.Contract", b =>
                {
                    b.HasOne("MobileConnectionApp.DataBase.KazanOfficeDataBase.Models.Sim", "Sim")
                        .WithMany()
                        .HasForeignKey("SimId");

                    b.Navigation("Sim");
                });

            modelBuilder.Entity("MobileConnectionApp.DataBase.KazanOfficeDataBase.Models.Device", b =>
                {
                    b.HasOne("MobileConnectionApp.DataBase.KazanOfficeDataBase.Models.TypeDeivce", "TypeDevice")
                        .WithMany()
                        .HasForeignKey("TypeDeviceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TypeDevice");
                });

            modelBuilder.Entity("MobileConnectionApp.DataBase.KazanOfficeDataBase.Models.Receipt", b =>
                {
                    b.HasOne("MobileConnectionApp.DataBase.KazanOfficeDataBase.Models.Device", "Device")
                        .WithMany()
                        .HasForeignKey("DeviceId");

                    b.Navigation("Device");
                });
#pragma warning restore 612, 618
        }
    }
}
