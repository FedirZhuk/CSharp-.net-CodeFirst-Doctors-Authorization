namespace Cwiczenia9.Entities;

public class Prescription
{
    public int IdPrescription { get; set; }
    public DateTime Date { get; set; }
    public DateTime DueDate { get; set; }
    public int DoctorId { get; set; }
    public int PatientId { get; set; }
    public virtual Doctor Doctor { get; set; }
    public virtual Patient Patient { get; set; }
    public virtual ICollection<Prescription_Medicament>? PrescriptionMedicaments { get; set; } =
        new List<Prescription_Medicament>();
}