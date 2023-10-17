using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cwiczenia9.Migrations
{
    /// <inheritdoc />
    public partial class MedicamentMigrations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicament_Medicament_MedicamentId",
                table: "PrescriptionMedicament");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicament_Prescription_PrescriptionId",
                table: "PrescriptionMedicament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescriptionMedicament",
                table: "PrescriptionMedicament");

            migrationBuilder.RenameTable(
                name: "PrescriptionMedicament",
                newName: "Prescription_Medicament");

            migrationBuilder.RenameIndex(
                name: "IX_PrescriptionMedicament_MedicamentId",
                table: "Prescription_Medicament",
                newName: "IX_Prescription_Medicament_MedicamentId");

            migrationBuilder.AlterColumn<int>(
                name: "Dose",
                table: "Prescription_Medicament",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescription_Medicament",
                table: "Prescription_Medicament",
                columns: new[] { "PrescriptionId", "MedicamentId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medicament_Medicament_MedicamentId",
                table: "Prescription_Medicament",
                column: "MedicamentId",
                principalTable: "Medicament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medicament_Prescription_PrescriptionId",
                table: "Prescription_Medicament",
                column: "PrescriptionId",
                principalTable: "Prescription",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medicament_Medicament_MedicamentId",
                table: "Prescription_Medicament");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medicament_Prescription_PrescriptionId",
                table: "Prescription_Medicament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescription_Medicament",
                table: "Prescription_Medicament");

            migrationBuilder.RenameTable(
                name: "Prescription_Medicament",
                newName: "PrescriptionMedicament");

            migrationBuilder.RenameIndex(
                name: "IX_Prescription_Medicament_MedicamentId",
                table: "PrescriptionMedicament",
                newName: "IX_PrescriptionMedicament_MedicamentId");

            migrationBuilder.AlterColumn<int>(
                name: "Dose",
                table: "PrescriptionMedicament",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescriptionMedicament",
                table: "PrescriptionMedicament",
                columns: new[] { "PrescriptionId", "MedicamentId" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicament_Medicament_MedicamentId",
                table: "PrescriptionMedicament",
                column: "MedicamentId",
                principalTable: "Medicament",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicament_Prescription_PrescriptionId",
                table: "PrescriptionMedicament",
                column: "PrescriptionId",
                principalTable: "Prescription",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
