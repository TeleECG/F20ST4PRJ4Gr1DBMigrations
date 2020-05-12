﻿// <auto-generated />
using System;
using F20ST4PRJ4Gr1LoacalDB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace F20ST4PRJ4Gr1LoacalDB.Migrations
{
    [DbContext(typeof(LocalMeasurmentDBContext))]
    [Migration("20200512064258_PatientCounty")]
    partial class PatientCounty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("F20ST4PRJ4Gr1SysModel.ECGLead", b =>
                {
                    b.Property<int>("ECGLeadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("ECGLeadValues")
                        .HasColumnType("BLOB");

                    b.Property<int>("ECGMeasurementId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("LeadNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("ECGLeadId");

                    b.HasIndex("ECGMeasurementId");

                    b.ToTable("ECGLeads");
                });

            modelBuilder.Entity("F20ST4PRJ4Gr1SysModel.ECGMeasurement", b =>
                {
                    b.Property<int>("ECGMeasurementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MeasurementNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PatientMeasurementId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ECGMeasurementId");

                    b.HasIndex("PatientMeasurementId");

                    b.ToTable("ECGMeasurements");
                });

            modelBuilder.Entity("F20ST4PRJ4Gr1SysModel.PatientMeasurement", b =>
                {
                    b.Property<int>("PatientMeasurementId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("TEXT");

                    b.Property<string>("CPRNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<string>("County")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("HRV")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Pulse")
                        .HasColumnType("INTEGER");

                    b.HasKey("PatientMeasurementId");

                    b.ToTable("PatientMeasurements");
                });

            modelBuilder.Entity("F20ST4PRJ4Gr1SysModel.ECGLead", b =>
                {
                    b.HasOne("F20ST4PRJ4Gr1SysModel.ECGMeasurement", "ECGMeasurement")
                        .WithMany("ECGLeads")
                        .HasForeignKey("ECGMeasurementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("F20ST4PRJ4Gr1SysModel.ECGMeasurement", b =>
                {
                    b.HasOne("F20ST4PRJ4Gr1SysModel.PatientMeasurement", "PatientMeasurement")
                        .WithMany("ECGMeasurements")
                        .HasForeignKey("PatientMeasurementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
