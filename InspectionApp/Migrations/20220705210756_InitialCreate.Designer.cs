﻿// <auto-generated />
using InspectionApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InspectionApp.Migrations
{
//    [DbContext(typeof(DataContext))]
//    [Migration("20220705210756_InitialCreate")]
//    partial class InitialCreate
//    {
//        protected override void BuildTargetModel(ModelBuilder modelBuilder)
//        {
//#pragma warning disable 612, 618
//            modelBuilder
//                .HasAnnotation("ProductVersion", "6.0.6")
//                .HasAnnotation("Relational:MaxIdentifierLength", 128);

//            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

//            modelBuilder.Entity("InspectionApp.Inspection", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

//                    b.Property<string>("Comments")
//                        .IsRequired()
//                        .HasMaxLength(200)
//                        .HasColumnType("nvarchar(200)");

//                    b.Property<int>("InspectionTypeId")
//                        .HasColumnType("int");

//                    b.Property<string>("Status")
//                        .IsRequired()
//                        .HasMaxLength(20)
//                        .HasColumnType("nvarchar(20)");

//                    b.HasKey("Id");

//                    b.HasIndex("InspectionTypeId");

//                    b.ToTable("Inspections");
//                });

//            modelBuilder.Entity("InspectionApp.InspectionType", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

//                    b.Property<string>("InspectionName")
//                        .IsRequired()
//                        .HasMaxLength(20)
//                        .HasColumnType("nvarchar(20)");

//                    b.HasKey("Id");

//                    b.ToTable("InspectionTypes");
//                });

//            modelBuilder.Entity("InspectionApp.Status", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int");

//                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

//                    b.Property<string>("StatusOption")
//                        .IsRequired()
//                        .HasMaxLength(20)
//                        .HasColumnType("nvarchar(20)");

//                    b.HasKey("Id");

//                    b.ToTable("Statuses");
//                });

//            modelBuilder.Entity("InspectionApp.Inspection", b =>
//                {
//                    b.HasOne("InspectionApp.InspectionType", "InspectionType")
//                        .WithMany()
//                        .HasForeignKey("InspectionTypeId")
//                        .OnDelete(DeleteBehavior.Cascade)
//                        .IsRequired();

//                    b.Navigation("InspectionType");
//                });
//#pragma warning restore 612, 618
//        }
//    }
}
