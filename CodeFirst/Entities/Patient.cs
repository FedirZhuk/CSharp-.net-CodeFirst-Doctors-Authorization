namespace Cwiczenia9.Entities;

public class Patient
{
    public int IdPatient { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public virtual DateTime Birthdate { get; set; }
    public virtual ICollection<Prescription>? Prescriptions { get; set; } = new List<Prescription>();
}