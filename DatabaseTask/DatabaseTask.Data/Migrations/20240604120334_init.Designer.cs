﻿// <auto-generated />
using System;
using DatabaseTask.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    [DbContext(typeof(DatabaseTaskDbContext))]
    [Migration("20240604120334_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DatabaseTask.Core.Domain.AccessLevel", b =>
                {
                    b.Property<int>("AccessLevelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccessLevelID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.HasKey("AccessLevelID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("AccessLevel");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Branch", b =>
                {
                    b.Property<int>("BranchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BranchID"), 1L, 1);

                    b.Property<int>("CompanyID")
                        .HasColumnType("int");

                    b.Property<string>("ITInfrastructure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("OpeningHours")
                        .HasColumnType("time");

                    b.Property<string>("ParkingAvailibility")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityMeasures")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Services")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchID");

                    b.HasIndex("CompanyID");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Child", b =>
                {
                    b.Property<int>("ChildID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChildID"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChildID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Child");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Company", b =>
                {
                    b.Property<int>("CompanyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyID"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPolicies")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FinancialPerformance")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FoundedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Industry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyID");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.Property<string>("Departament")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeId");

                    b.HasIndex("BranchID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.HealthCheckList", b =>
                {
                    b.Property<int>("HealthCheckID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HealthCheckID"), 1L, 1);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Result")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HealthCheckID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("HealthCheckLists");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.LoanableItem", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemID"), 1L, 1);

                    b.Property<string>("Availability")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemID");

                    b.ToTable("LoanableItem");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.PositionList", b =>
                {
                    b.Property<int>("PositionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PositionId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PositionId");

                    b.HasIndex("EmployeeID");

                    b.ToTable("PositionList");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.SickLeaveListID", b =>
                {
                    b.Property<int>("SickLeaveID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SickLeaveID"), 1L, 1);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SickLeaveID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("SickLeaveListID");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.VacationList", b =>
                {
                    b.Property<int>("VacationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VacationID"), 1L, 1);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("VacationID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("VacationList");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.AccessLevel", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employees")
                        .WithMany("AccessLevels")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Branch", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Company", "Company")
                        .WithMany("Branches")
                        .HasForeignKey("CompanyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Child", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employee")
                        .WithMany("Children")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employee", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Branch", "Branch")
                        .WithMany("Employees")
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.HealthCheckList", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employee")
                        .WithMany("HealthChecks")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.PositionList", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employee")
                        .WithMany("Position")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.SickLeaveListID", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employee")
                        .WithMany("SickLeaveLists")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.VacationList", b =>
                {
                    b.HasOne("DatabaseTask.Core.Domain.Employee", "Employee")
                        .WithMany("Vacations")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Branch", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Company", b =>
                {
                    b.Navigation("Branches");
                });

            modelBuilder.Entity("DatabaseTask.Core.Domain.Employee", b =>
                {
                    b.Navigation("AccessLevels");

                    b.Navigation("Children");

                    b.Navigation("HealthChecks");

                    b.Navigation("Position");

                    b.Navigation("SickLeaveLists");

                    b.Navigation("Vacations");
                });
#pragma warning restore 612, 618
        }
    }
}
