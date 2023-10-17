using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cwiczenia9.Migrations
{
    /// <inheritdoc />
    public partial class LoginMigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.IdUser);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 5, 28, 19, 12, 0, 620, DateTimeKind.Local).AddTicks(4350), new DateTime(2023, 6, 4, 19, 12, 0, 620, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2023, 5, 28, 19, 12, 0, 620, DateTimeKind.Local).AddTicks(4410), new DateTime(2023, 6, 4, 19, 12, 0, 620, DateTimeKind.Local).AddTicks(4420) });
        }
    }
}
