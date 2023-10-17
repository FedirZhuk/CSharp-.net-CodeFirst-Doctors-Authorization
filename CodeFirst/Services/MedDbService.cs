using Cwiczenia9.DTO;
using Cwiczenia9.Entities;
using Microsoft.EntityFrameworkCore;
namespace Cwiczenia9.Services;

public class MedDbService : IMedDbService
{
    private readonly MedDbContext _context;

    public MedDbService(MedDbContext context)
    {
        _context = context;
    }

    public async Task<List<object>> GetDoctorsAsync(CancellationToken cancellationToken = default)
    {
        var doctors = await _context.Doctors.ToListAsync(cancellationToken);
        
        return doctors.Cast<object>().ToList();
    }

    public async Task<object> GetPrescriptionsAsync(int idPrescription, CancellationToken cancellationToken = default)
    {
        var prescriptions = await _context.Prescriptions
            .Where(x => x.IdPrescription == idPrescription)
            .Select(x => new
            {
                IdPrescription = x.IdPrescription,
                Date = x.Date,
                DueDate = x.DueDate,
                Doctor = x.Doctor,
                Patient = x.Patient,
                PrescriptionMedicaments = x.PrescriptionMedicaments
                    .Select(pm => new
                    {
                        Dose = pm.Dose,
                        Details = pm.Details,
                        Medicament = _context.Medicaments.FirstOrDefault(m => m.Id == pm.MedicamentId)
                    })
                    .ToList()
            })
            .ToListAsync(cancellationToken);

        return prescriptions;
    }


    public async Task DeleteDoctor(int idDoctor)
    {
        var doctor = await _context.Doctors.FindAsync(idDoctor);
        if (doctor == null)
        {
            throw new ArgumentException("Doctor does not exist");
        }

        var assignedPrescription = await _context.Prescriptions.AnyAsync(p => p.DoctorId == idDoctor);
        if (assignedPrescription)
        {
            throw new InvalidOperationException("Cannot delete doctor with assigned prescriptions");
        }

        _context.Doctors.Remove(doctor);
        await _context.SaveChangesAsync();
    }

    public async Task AddDoctor(DoctorDTO doctor)
    {
        Doctor tmp = new Doctor
        {
            FirstName = doctor.FirstName,
            LastName = doctor.LastName,
            Email = doctor.Email,
            Prescriptions = null
        };
        
        _context.Doctors.Add(tmp);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateDoctor(int idDoctor, DoctorDTO doctor)
    {
        var existingDoctor = await _context.Doctors.FindAsync(idDoctor);
        if (existingDoctor == null)
        {
            throw new ArgumentException("Doctor does not exist");
        }
        
        existingDoctor.FirstName = doctor.FirstName;
        existingDoctor.LastName = doctor.LastName;
        existingDoctor.Email = doctor.Email;
        
        _context.Doctors.Update(existingDoctor);
        
        await _context.SaveChangesAsync();
    }
}