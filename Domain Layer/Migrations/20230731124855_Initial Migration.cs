using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Domain_Layer.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MedicalFrom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDNo = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PoBoxNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Town = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientRepName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientRepPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Relation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NatureOfillness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalAttachmentDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalAttachments = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    MedicalAttachmentFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyContribution = table.Column<double>(type: "float", nullable: false),
                    NHIFcontribution = table.Column<double>(type: "float", nullable: false),
                    HospitalBillBalance = table.Column<double>(type: "float", nullable: false),
                    IsRevertee = table.Column<bool>(type: "bit", nullable: false),
                    ReverteeCertificate = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ReverteeCertificateFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransportDocument = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TravellingAttachment = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    TravellingAttachmentFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OverSeasHospitalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OverSeaCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OverSeaHospitalDocument = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    HospitalAttachmentFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Signature = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    modfiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalFrom", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MedicalFrom");
        }
    }
}
