﻿// <auto-generated />
using System;
using EP_System_Test.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EP_System_Test.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231029183322_Added_WhatsApp_and_Email_Student_Teacher_School")]
    partial class Added_WhatsApp_and_Email_Student_Teacher_School
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EP_System_Test.Models.ExtraCurricular", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.Property<string>("Society_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("ExtraCurricualrs");
                });

            modelBuilder.Entity("EP_System_Test.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("EP_System_Test.Models.School", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Dep_Principal_Contact")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Grade_06_Count")
                        .HasColumnType("int");

                    b.Property<int>("Grade_07_Count")
                        .HasColumnType("int");

                    b.Property<int>("Grade_08_Count")
                        .HasColumnType("int");

                    b.Property<int>("Grade_09_Count")
                        .HasColumnType("int");

                    b.Property<int>("Grade_10_Count")
                        .HasColumnType("int");

                    b.Property<int>("Grade_11_Count")
                        .HasColumnType("int");

                    b.Property<int>("Grade_AL_Arts")
                        .HasColumnType("int");

                    b.Property<int>("Grade_AL_Bio")
                        .HasColumnType("int");

                    b.Property<int>("Grade_AL_Commerce")
                        .HasColumnType("int");

                    b.Property<int>("Grade_AL_Maths")
                        .HasColumnType("int");

                    b.Property<int>("Grade_AL_Tech")
                        .HasColumnType("int");

                    b.Property<string>("Principal_ContactNumber")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Principl_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Sports_Coacher_01")
                        .HasColumnType("int");

                    b.Property<int>("Sports_Coacher_02")
                        .HasColumnType("int");

                    b.Property<int>("Sports_Coacher_03")
                        .HasColumnType("int");

                    b.Property<int>("Sports_Coacher_04")
                        .HasColumnType("int");

                    b.Property<int>("Sports_Coacher_05")
                        .HasColumnType("int");

                    b.Property<int>("Student_Count_Total")
                        .HasColumnType("int");

                    b.Property<int>("Subjects_Teachers_01")
                        .HasColumnType("int");

                    b.Property<int>("Subjects_Teachers_02")
                        .HasColumnType("int");

                    b.Property<int>("Subjects_Teachers_03")
                        .HasColumnType("int");

                    b.Property<int>("Subjects_Teachers_04")
                        .HasColumnType("int");

                    b.Property<int>("Subjects_Teachers_05")
                        .HasColumnType("int");

                    b.Property<int>("Teacher_Count_Total")
                        .HasColumnType("int");

                    b.Property<string>("WhatsApp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("School");
                });

            modelBuilder.Entity("EP_System_Test.Models.Sports", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.Property<string>("Sport_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Sports");
                });

            modelBuilder.Entity("EP_System_Test.Models.Student_Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Students_Teachers");
                });

            modelBuilder.Entity("EP_System_Test.Models.Students", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DOB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Father_Contact_Number")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Father_Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mother_Contact_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mother_Occupation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mothers_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.Property<string>("Stu_Grade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhatsApp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("EP_System_Test.Models.Students_ExtraCurriculars", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("ExtraCurricularId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "ExtraCurricularId");

                    b.HasIndex("ExtraCurricularId");

                    b.ToTable("Student_ExtraCurricular");
                });

            modelBuilder.Entity("EP_System_Test.Models.Students_Sports", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("SportsId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "SportsId");

                    b.HasIndex("SportsId");

                    b.ToTable("Student_Sport");
                });

            modelBuilder.Entity("EP_System_Test.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Appointed_Sports")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ClassTeacher")
                        .HasColumnType("bit");

                    b.Property<string>("Contact_Number")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grade_Teaching")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NIC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SchoolId")
                        .HasColumnType("int");

                    b.Property<string>("Teacher_Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Teaching_Subject")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhatsApp")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SchoolId");

                    b.ToTable("Teacher");
                });

            modelBuilder.Entity("EP_System_Test.Models.Teacher_ExtraCurriculars", b =>
                {
                    b.Property<int>("ExtraCurricualrId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("ExtraCurricualrId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Teachers_ExtraCurricualrs");
                });

            modelBuilder.Entity("EP_System_Test.Models.Teacher_Sports", b =>
                {
                    b.Property<int>("SportId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("SportId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Teachers_Sports");
                });

            modelBuilder.Entity("EP_System_Test.Models.ExtraCurricular", b =>
                {
                    b.HasOne("EP_System_Test.Models.School", "School")
                        .WithMany("ExtraCurriculars")
                        .HasForeignKey("SchoolId");

                    b.Navigation("School");
                });

            modelBuilder.Entity("EP_System_Test.Models.Sports", b =>
                {
                    b.HasOne("EP_System_Test.Models.School", "School")
                        .WithMany("Sports")
                        .HasForeignKey("SchoolId");

                    b.Navigation("School");
                });

            modelBuilder.Entity("EP_System_Test.Models.Student_Teacher", b =>
                {
                    b.HasOne("EP_System_Test.Models.Students", "Students")
                        .WithMany("Students_Teachers")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EP_System_Test.Models.Teacher", "Teacher")
                        .WithMany("Teachers_Students")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Students");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("EP_System_Test.Models.Students", b =>
                {
                    b.HasOne("EP_System_Test.Models.School", "School")
                        .WithMany("School_Students")
                        .HasForeignKey("SchoolId");

                    b.Navigation("School");
                });

            modelBuilder.Entity("EP_System_Test.Models.Students_ExtraCurriculars", b =>
                {
                    b.HasOne("EP_System_Test.Models.ExtraCurricular", "ExtraCurricular")
                        .WithMany("Students_Extras")
                        .HasForeignKey("ExtraCurricularId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EP_System_Test.Models.Students", "Student")
                        .WithMany("StuExtraCurriculars")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExtraCurricular");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EP_System_Test.Models.Students_Sports", b =>
                {
                    b.HasOne("EP_System_Test.Models.Sports", "Sports")
                        .WithMany("Student_Sports")
                        .HasForeignKey("SportsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EP_System_Test.Models.Students", "Student")
                        .WithMany("Stu_Sports")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sports");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("EP_System_Test.Models.Teacher", b =>
                {
                    b.HasOne("EP_System_Test.Models.School", "School")
                        .WithMany("School_Teachers")
                        .HasForeignKey("SchoolId");

                    b.Navigation("School");
                });

            modelBuilder.Entity("EP_System_Test.Models.Teacher_ExtraCurriculars", b =>
                {
                    b.HasOne("EP_System_Test.Models.ExtraCurricular", "ExtraCurriculars")
                        .WithMany("ExtraCurriculars_Teachers")
                        .HasForeignKey("ExtraCurricualrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EP_System_Test.Models.Teacher", "Teachers")
                        .WithMany("Teachers_ExtraCurriculars")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ExtraCurriculars");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("EP_System_Test.Models.Teacher_Sports", b =>
                {
                    b.HasOne("EP_System_Test.Models.Sports", "Sports")
                        .WithMany("Sports_Teachers")
                        .HasForeignKey("SportId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EP_System_Test.Models.Teacher", "Teachers")
                        .WithMany("Teachers_Sports")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sports");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("EP_System_Test.Models.ExtraCurricular", b =>
                {
                    b.Navigation("ExtraCurriculars_Teachers");

                    b.Navigation("Students_Extras");
                });

            modelBuilder.Entity("EP_System_Test.Models.School", b =>
                {
                    b.Navigation("ExtraCurriculars");

                    b.Navigation("School_Students");

                    b.Navigation("School_Teachers");

                    b.Navigation("Sports");
                });

            modelBuilder.Entity("EP_System_Test.Models.Sports", b =>
                {
                    b.Navigation("Sports_Teachers");

                    b.Navigation("Student_Sports");
                });

            modelBuilder.Entity("EP_System_Test.Models.Students", b =>
                {
                    b.Navigation("Stu_Sports");

                    b.Navigation("Students_Teachers");

                    b.Navigation("StuExtraCurriculars");
                });

            modelBuilder.Entity("EP_System_Test.Models.Teacher", b =>
                {
                    b.Navigation("Teachers_ExtraCurriculars");

                    b.Navigation("Teachers_Sports");

                    b.Navigation("Teachers_Students");
                });
#pragma warning restore 612, 618
        }
    }
}