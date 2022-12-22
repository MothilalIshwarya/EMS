﻿// <auto-generated />
using System;
using EmployeeManagementSystem.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmployeeManagementSystem.Migrations
{
    [DbContext(typeof(EMScontext))]
    [Migration("20221219061052_attempt5")]
    partial class attempt5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EmployeeManagementSystem.Model.EmployeeDetails", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genderid")
                        .HasColumnType("int");

                    b.Property<string>("Mailid")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Genderid")
                        .IsUnique();

                    b.ToTable("EmployeeDetails");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Model.Gender", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<string>("gender")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Gender");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Model.EmployeeDetails", b =>
                {
                    b.HasOne("EmployeeManagementSystem.Model.Gender", "gender")
                        .WithOne("EmployeeDetails")
                        .HasForeignKey("EmployeeManagementSystem.Model.EmployeeDetails", "Genderid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("gender");
                });

            modelBuilder.Entity("EmployeeManagementSystem.Model.Gender", b =>
                {
                    b.Navigation("EmployeeDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
