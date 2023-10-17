using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cwiczenia9.Migrations
{
    /// <inheritdoc />
    public partial class LoginMigratons2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 6, 3, 20, 53, 33, 220, DateTimeKind.Local).AddTicks(6840), new DateTime(2023, 6, 10, 20, 53, 33, 220, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 6, 3, 20, 53, 33, 220, DateTimeKind.Local).AddTicks(6890), new DateTime(2023, 6, 10, 20, 53, 33, 220, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "IdUser", "Login", "Password" },
                values: new object[] { 1, "Ivan", "Illarionov" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "IdUser",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 6, 3, 20, 36, 25, 216, DateTimeKind.Local).AddTicks(7800), new DateTime(2023, 6, 10, 20, 36, 25, 216, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 6, 3, 20, 36, 25, 216, DateTimeKind.Local).AddTicks(7850), new DateTime(2023, 6, 10, 20, 36, 25, 216, DateTimeKind.Local).AddTicks(7850) });
        }
    }
}
