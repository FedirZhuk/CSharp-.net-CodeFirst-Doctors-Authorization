using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cwiczenia9.Migrations
{
    /// <inheritdoc />
    public partial class MedicamentMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 30, 148, DateTimeKind.Local).AddTicks(3550), new DateTime(2023, 5, 30, 22, 31, 30, 148, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 5, 23, 22, 31, 30, 148, DateTimeKind.Local).AddTicks(3600), new DateTime(2023, 5, 30, 22, 31, 30, 148, DateTimeKind.Local).AddTicks(3600) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 5, 22, 21, 29, 32, 157, DateTimeKind.Local).AddTicks(2140), new DateTime(2023, 5, 29, 21, 29, 32, 157, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 5, 22, 21, 29, 32, 157, DateTimeKind.Local).AddTicks(2210), new DateTime(2023, 5, 29, 21, 29, 32, 157, DateTimeKind.Local).AddTicks(2210) });
        }
    }
}
