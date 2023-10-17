namespace Cwiczenia9.Entities;

public class Prescription_Medicament
{
    public int PrescriptionId { get; set; }
    public int MedicamentId { get; set; }
    public int? Dose { get; set; }
    public string Details { get; set; }
    public virtual Prescription Prescription { get; set; }
    public virtual Medicament Medicament { get; set; }
}