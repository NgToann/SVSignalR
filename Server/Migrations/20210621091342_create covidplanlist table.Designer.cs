﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SVSignalR.Server.Data;

namespace SVSignalR.Server.Migrations
{
    [DbContext(typeof(SVSignalRContext))]
    [Migration("20210621091342_create covidplanlist table")]
    partial class createcovidplanlisttable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SVSignalR.Shared.BookModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Isbn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("SVSignalR.Shared.Models.AddressModel", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Commune")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommuneId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DistrictId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinceId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("SVSignalR.Shared.Models.CovidPlanModel", b =>
                {
                    b.Property<string>("WorkerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AddressInfoAddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("HealthStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkerInfoWorkerId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("WorkerId");

                    b.HasIndex("AddressInfoAddressId");

                    b.HasIndex("WorkerInfoWorkerId");

                    b.ToTable("CovidPlanList");
                });

            modelBuilder.Entity("SVSignalR.Shared.Models.WorkerModel", b =>
                {
                    b.Property<string>("WorkerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CardId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Factory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LineName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkerId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("SVSignalR.Shared.Models.CovidPlanModel", b =>
                {
                    b.HasOne("SVSignalR.Shared.Models.AddressModel", "AddressInfo")
                        .WithMany()
                        .HasForeignKey("AddressInfoAddressId");

                    b.HasOne("SVSignalR.Shared.Models.WorkerModel", "WorkerInfo")
                        .WithMany()
                        .HasForeignKey("WorkerInfoWorkerId");

                    b.Navigation("AddressInfo");

                    b.Navigation("WorkerInfo");
                });
#pragma warning restore 612, 618
        }
    }
}