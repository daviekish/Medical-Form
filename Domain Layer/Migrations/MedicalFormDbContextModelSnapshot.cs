﻿// <auto-generated />
using System;
using Domain_Layer.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Domain_Layer.Migrations
{
    [DbContext(typeof(MedicalFormDbContext))]
    partial class MedicalFormDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain_Layer.Models.MedicalFromModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FamilyContribution")
                        .HasColumnType("float");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalAttachmentFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HospitalBillBalance")
                        .HasColumnType("float");

                    b.Property<string>("HospitalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IDNo")
                        .HasColumnType("int");

                    b.Property<bool>("IsRevertee")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalAttachmentDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalAttachmentFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("NHIFcontribution")
                        .HasColumnType("float");

                    b.Property<string>("NatureOfillness")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OverSeaCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OverSeasHospitalName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientRepName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PatientRepPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PoBoxNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReverteeCertificateFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Town")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransportDocument")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TravellingAttachmentFileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("modfiedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("MedicalFrom");

                    b.HasDiscriminator<string>("Discriminator").HasValue("MedicalFromModel");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Domain_Layer.Models.Files", b =>
                {
                    b.HasBaseType("Domain_Layer.Models.MedicalFromModel");

                    b.Property<byte[]>("MedicalAttachments")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("OverSeaHospitalDocument")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("ReverteeCertificate")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("TravellingAttachment")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasDiscriminator().HasValue("Files");
                });
#pragma warning restore 612, 618
        }
    }
}
