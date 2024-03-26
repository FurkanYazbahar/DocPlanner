using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DocPlannerStudyCase.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookVisits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    VisitId = table.Column<int>(type: "INTEGER", nullable: false),
                    PatientName = table.Column<string>(type: "TEXT", nullable: false),
                    PatientSurname = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookVisits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    HospitalName = table.Column<string>(type: "TEXT", nullable: false),
                    HospitalId = table.Column<int>(type: "INTEGER", nullable: false),
                    SpecialtyId = table.Column<int>(type: "INTEGER", nullable: false),
                    BranchId = table.Column<double>(type: "REAL", nullable: false),
                    Nationality = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DoctorId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    VisitId = table.Column<int>(type: "INTEGER", nullable: false),
                    AppointmentStatus = table.Column<int>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schedules_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "BranchId", "CreatedAt", "CreatedDate", "DeletedDate", "Gender", "HospitalId", "HospitalName", "ModifiedDate", "Name", "Nationality", "SpecialtyId", "Status" },
                values: new object[,]
                {
                    { 1, 29532.990000000002, new DateTime(2022, 4, 29, 5, 25, 52, 521, DateTimeKind.Local), new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2133), null, 0, 150, "Medicana Avcilar", null, "Mr. Ahmet Öz", "TUR", 81036, 1 },
                    { 2, 29532.990000000002, new DateTime(2022, 4, 29, 5, 25, 52, 521, DateTimeKind.Local), new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2148), null, 0, 150, "Medicana Avcilar", null, "Ahmet Pınar", "TUR", 81036, 1 },
                    { 3, 45145.080000000002, new DateTime(2021, 12, 29, 23, 34, 25, 337, DateTimeKind.Local), new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2153), null, 1, 160, "MedicalPark İzmir", null, "Yasemin Öztürk", "TUR", 81036, 1 },
                    { 4, 49875.589999999997, new DateTime(2022, 4, 30, 7, 5, 6, 158, DateTimeKind.Local), new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2158), null, 1, 160, "MedicalPark Kadiköy", null, "Kübra Işık", "TUR", 18741, 1 },
                    { 5, 19747.48, new DateTime(2021, 5, 28, 0, 24, 21, 743, DateTimeKind.Local), new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2162), null, 1, 150, "Medicana Sisli", null, "Aynur Aslan", "TUR", 20746, 1 },
                    { 6, 94982.389999999999, new DateTime(2021, 7, 28, 16, 55, 8, 598, DateTimeKind.Local), new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2168), null, 1, 54892, "Memorial", null, "Elena Morissette", "DE", 88071, 1 },
                    { 7, 19747.48, new DateTime(2021, 6, 14, 21, 1, 30, 325, DateTimeKind.Local), new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2172), null, 0, 23701, "Medicana Sisli", null, "Hamdi Öztürk", "TUR", 9090, 1 },
                    { 8, 46998.739999999998, new DateTime(2021, 8, 27, 7, 4, 58, 976, DateTimeKind.Local), new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2176), null, 0, 58497, "American Hospital", null, "Craig O'Keefe", "USA", 39708, 1 },
                    { 9, 5663.6400000000003, new DateTime(2022, 3, 12, 18, 47, 42, 275, DateTimeKind.Local), new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2181), null, 1, 1058, "Ege Hastanesi", null, "Aysun Çoşkun", "TUR", 82688, 1 },
                    { 10, 5663.6400000000003, new DateTime(2022, 5, 9, 22, 12, 58, 359, DateTimeKind.Local), new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2185), null, 0, 1058, "Ege Hastanesi", null, "Cesar Batz", "ITA", 13798, 1 }
                });

            migrationBuilder.InsertData(
                table: "Schedules",
                columns: new[] { "Id", "AppointmentStatus", "CreatedDate", "DeletedDate", "DoctorId", "EndTime", "ModifiedDate", "StartTime", "Status", "VisitId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2322), null, 3, new DateTime(2022, 5, 31, 13, 45, 0, 0, DateTimeKind.Local), null, new DateTime(2022, 5, 31, 13, 30, 0, 0, DateTimeKind.Local), 1, 551231 },
                    { 2, 1, new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2329), null, 3, new DateTime(2022, 6, 1, 13, 45, 0, 0, DateTimeKind.Local), null, new DateTime(2022, 6, 1, 13, 30, 0, 0, DateTimeKind.Local), 1, 252312 },
                    { 3, 1, new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2336), null, 3, new DateTime(2022, 6, 1, 13, 55, 0, 0, DateTimeKind.Local), null, new DateTime(2022, 6, 1, 13, 45, 0, 0, DateTimeKind.Local), 1, 652123 },
                    { 4, 1, new DateTime(2024, 3, 26, 6, 51, 35, 297, DateTimeKind.Local).AddTicks(2342), null, 3, new DateTime(2022, 6, 1, 19, 50, 0, 0, DateTimeKind.Local), null, new DateTime(2022, 6, 1, 19, 30, 0, 0, DateTimeKind.Local), 1, 923112 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_DoctorId",
                table: "Schedules",
                column: "DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookVisits");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Doctors");
        }
    }
}
