﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using rater_api.Data;

#nullable disable

namespace rater_api.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("rater_api.Models.ProgramRate", b =>
                {
                    b.Property<int>("ProgramRateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created_At")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProgramReview")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("RateNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SchoolProgramId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ProgramRateId");

                    b.HasIndex("SchoolProgramId");

                    b.ToTable("ProgramRate");

                    b.HasData(
                        new
                        {
                            ProgramRateId = 1,
                            Created_At = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ProgramReview = "The program have you do video story telling, counting cash flow, and think about ethic issues when you don't even have solid understanding on OOP. This is just ridiculous. For those who are looking to enter this program, think twice.",
                            RateNumber = 1,
                            SchoolProgramId = 1
                        });
                });

            modelBuilder.Entity("rater_api.Models.SchoolProgram", b =>
                {
                    b.Property<int>("SchoolProgramId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ProgramDesc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ProgramName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SchoolProgramId");

                    b.ToTable("SchoolProgram");

                    b.HasData(
                        new
                        {
                            SchoolProgramId = 1,
                            ProgramDesc = "The Full-Stack Web Development Diploma (FSWD) features an interdisciplinary learning environment to prepare you for a career as a web developer.Focusing on emerging web application development tools and technologies,this unique two - year full - time program offers hands - on experience combined with industry projects to equip you for the many opportunities in this fast - growing and high - demand field.",
                            ProgramName = "Full-Stack Web Development"
                        },
                        new
                        {
                            SchoolProgramId = 2,
                            ProgramDesc = "STUDY COMPUTING & INFORMATION TECHNOLOGY COMPUTER INFORMATION TECHNOLOGYComputer Information Technology",
                            ProgramName = "Computer Information Technology"
                        },
                        new
                        {
                            SchoolProgramId = 3,
                            ProgramDesc = "BCIT’s Computer Systems Technology (CST) two-year diploma program combines computer systems theory with hands-on practical experience in software development. You’ll learn software engineering and programming from industry professionals, and gain experience working on real projects, from concept to deployment. In second year, specialty options add depth and further hone your skills.",
                            ProgramName = "Computer Systems Technology"
                        },
                        new
                        {
                            SchoolProgramId = 4,
                            ProgramDesc = "In the Digital Design and Development diploma program at BCIT, you will build a solid foundation in designing, developing, and creating interactive, dynamic, immersive social and online applications across various digital media platforms.Learn to work within a team to design and develop web and mobile applications, educational products, video, and audio assets for interactive media and business applications.",
                            ProgramName = "Digital Design and Development"
                        });
                });

            modelBuilder.Entity("rater_api.Models.ProgramRate", b =>
                {
                    b.HasOne("rater_api.Models.SchoolProgram", null)
                        .WithMany("ProgramRates")
                        .HasForeignKey("SchoolProgramId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("rater_api.Models.SchoolProgram", b =>
                {
                    b.Navigation("ProgramRates");
                });
#pragma warning restore 612, 618
        }
    }
}