﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using P01_Student_System.Data;

#nullable disable

namespace P01_Student_System.Migrations
{
    [DbContext(typeof(StudentSystemContext))]
    [Migration("20240517233316_edit")]
    partial class edit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("P01_Student_System.Models.Courses", b =>
                {
                    b.Property<int>("CoursesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoursesId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateOnly>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(80)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("CoursesId");

                    b.ToTable("course");
                });

            modelBuilder.Entity("P01_Student_System.Models.HomeworkSubmissions", b =>
                {
                    b.Property<int>("HomeworkSubmissionsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HomeworkSubmissionsId"));

                    b.Property<string>("Content")
                        .HasColumnType("varchar(100)");

                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.Property<TimeOnly>("SubmissionTime")
                        .HasColumnType("time");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("HomeworkSubmissionsId");

                    b.HasIndex("CoursesId");

                    b.HasIndex("StudentsId");

                    b.ToTable("Homework");
                });

            modelBuilder.Entity("P01_Student_System.Models.Resources", b =>
                {
                    b.Property<int>("ResourcesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResourcesId"));

                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("Url")
                        .HasColumnType("varchar(100)");

                    b.HasKey("ResourcesId");

                    b.HasIndex("CoursesId");

                    b.ToTable("resource");
                });

            modelBuilder.Entity("P01_Student_System.Models.Students", b =>
                {
                    b.Property<int>("StudentsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentsId"));

                    b.Property<DateOnly?>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegisteredOn")
                        .HasColumnType("datetime2");

                    b.HasKey("StudentsId");

                    b.ToTable("student");
                });

            modelBuilder.Entity("StudentCourses", b =>
                {
                    b.Property<int>("StudentsId")
                        .HasColumnType("int");

                    b.Property<int>("CoursesId")
                        .HasColumnType("int");

                    b.HasKey("StudentsId", "CoursesId");

                    b.HasIndex("CoursesId");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("P01_Student_System.Models.HomeworkSubmissions", b =>
                {
                    b.HasOne("P01_Student_System.Models.Courses", "course")
                        .WithMany("HomeworkEnrolled")
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P01_Student_System.Models.Students", "students")
                        .WithMany("HomeworkEnrolled")
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");

                    b.Navigation("students");
                });

            modelBuilder.Entity("P01_Student_System.Models.Resources", b =>
                {
                    b.HasOne("P01_Student_System.Models.Courses", "course")
                        .WithMany("resources")
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("course");
                });

            modelBuilder.Entity("StudentCourses", b =>
                {
                    b.HasOne("P01_Student_System.Models.Courses", null)
                        .WithMany()
                        .HasForeignKey("CoursesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("P01_Student_System.Models.Students", null)
                        .WithMany()
                        .HasForeignKey("StudentsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("P01_Student_System.Models.Courses", b =>
                {
                    b.Navigation("HomeworkEnrolled");

                    b.Navigation("resources");
                });

            modelBuilder.Entity("P01_Student_System.Models.Students", b =>
                {
                    b.Navigation("HomeworkEnrolled");
                });
#pragma warning restore 612, 618
        }
    }
}
