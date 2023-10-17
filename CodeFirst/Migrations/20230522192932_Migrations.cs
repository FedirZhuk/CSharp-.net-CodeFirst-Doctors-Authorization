using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cwiczenia9.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicaments_Medicaments_MedicamentId",
                table: "PrescriptionMedicaments");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicaments_Prescriptions_PrescriptionId",
                table: "PrescriptionMedicaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patients_PatientId",
                table: "Prescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescriptions",
                table: "Prescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescriptionMedicaments",
                table: "PrescriptionMedicaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicaments",
                table: "Medicaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.RenameTable(
                name: "Prescriptions",
                newName: "Prescription");

            migrationBuilder.RenameTable(
                name: "PrescriptionMedicaments",
                newName: "PrescriptionMedicament");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "Patient");

            migrationBuilder.RenameTable(
                name: "Medicaments",
                newName: "Medicament");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "Doctor");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_PatientId",
                table: "Prescription",
                newName: "IX_Prescription_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_DoctorId",
                table: "Prescription",
                newName: "IX_Prescription_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_PrescriptionMedicaments_MedicamentId",
                table: "PrescriptionMedicament",
                newName: "IX_PrescriptionMedicament_MedicamentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescription",
                table: "Prescription",
                column: "IdPrescription");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescriptionMedicament",
                table: "PrescriptionMedicament",
                columns: new[] { "PrescriptionId", "MedicamentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "IdPatient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicament",
                table: "Medicament",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "IdDoctor");

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "smith@example.com", "Ivan", "Illarionov" },
                    { 2, "johnson@example.com", "Krzysztof", "Kroczyński" }
                });

            migrationBuilder.InsertData(
                table: "Medicament",
                columns: new[] { "Id", "Description", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "blabbla", "Medicament 1", "antybiotyk" },
                    { 2, "alalala", "Medicament 2", "lek" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "IdPatient", "Birthdate", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Doe" },
                    { 2, new DateTime(1995, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane", "Smith" }
                });

            migrationBuilder.InsertData(
                table: "Prescription",
                columns: new[] { "IdPrescription", "Date", "DoctorId", "DueDate", "PatientId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 22, 21, 29, 32, 157, DateTimeKind.Local).AddTicks(2140), 1, new DateTime(2023, 5, 29, 21, 29, 32, 157, DateTimeKind.Local).AddTicks(2200), 1 },
                    { 2, new DateTime(2023, 5, 22, 21, 29, 32, 157, DateTimeKind.Local).AddTicks(2210), 2, new DateTime(2023, 5, 29, 21, 29, 32, 157, DateTimeKind.Local).AddTicks(2210), 2 }
                });

            migrationBuilder.InsertData(
                table: "PrescriptionMedicament",
                columns: new[] { "MedicamentId", "PrescriptionId", "Details", "Dose" },
                values: new object[,]
                {
                    { 1, 1, "Take twice a day", 2 },
                    { 2, 1, "Take once daily", 1 },
                    { 1, 2, "Take three times a day", 3 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Doctor_DoctorId",
                table: "Prescription",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "IdDoctor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Patient_PatientId",
                table: "Prescription",
                column: "PatientId",
                principalTable: "Patient",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Doctor_DoctorId",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Patient_PatientId",
                table: "Prescription");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicament_Medicament_MedicamentId",
                table: "PrescriptionMedicament");

            migrationBuilder.DropForeignKey(
                name: "FK_PrescriptionMedicament_Prescription_PrescriptionId",
                table: "PrescriptionMedicament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PrescriptionMedicament",
                table: "PrescriptionMedicament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescription",
                table: "Prescription");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicament",
                table: "Medicament");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicament",
                keyColumns: new[] { "MedicamentId", "PrescriptionId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicament",
                keyColumns: new[] { "MedicamentId", "PrescriptionId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "PrescriptionMedicament",
                keyColumns: new[] { "MedicamentId", "PrescriptionId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicament",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Prescription",
                keyColumn: "IdPrescription",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "IdDoctor",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patient",
                keyColumn: "IdPatient",
                keyValue: 2);

            migrationBuilder.RenameTable(
                name: "PrescriptionMedicament",
                newName: "PrescriptionMedicaments");

            migrationBuilder.RenameTable(
                name: "Prescription",
                newName: "Prescriptions");

            migrationBuilder.RenameTable(
                name: "Patient",
                newName: "Patients");

            migrationBuilder.RenameTable(
                name: "Medicament",
                newName: "Medicaments");

            migrationBuilder.RenameTable(
                name: "Doctor",
                newName: "Doctors");

            migrationBuilder.RenameIndex(
                name: "IX_PrescriptionMedicament_MedicamentId",
                table: "PrescriptionMedicaments",
                newName: "IX_PrescriptionMedicaments_MedicamentId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescription_PatientId",
                table: "Prescriptions",
                newName: "IX_Prescriptions_PatientId");

            migrationBuilder.RenameIndex(
                name: "IX_Prescription_DoctorId",
                table: "Prescriptions",
                newName: "IX_Prescriptions_DoctorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrescriptionMedicaments",
                table: "PrescriptionMedicaments",
                columns: new[] { "PrescriptionId", "MedicamentId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescriptions",
                table: "Prescriptions",
                column: "IdPrescription");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "IdPatient");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicaments",
                table: "Medicaments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "IdDoctor");

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicaments_Medicaments_MedicamentId",
                table: "PrescriptionMedicaments",
                column: "MedicamentId",
                principalTable: "Medicaments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PrescriptionMedicaments_Prescriptions_PrescriptionId",
                table: "PrescriptionMedicaments",
                column: "PrescriptionId",
                principalTable: "Prescriptions",
                principalColumn: "IdPrescription",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Doctors_DoctorId",
                table: "Prescriptions",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "IdDoctor",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patients_PatientId",
                table: "Prescriptions",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "IdPatient",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
