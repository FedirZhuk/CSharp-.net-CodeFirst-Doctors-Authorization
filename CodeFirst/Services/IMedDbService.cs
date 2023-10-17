using Cwiczenia9.DTO;
using Cwiczenia9.Entities;

namespace Cwiczenia9.Services;

public interface IMedDbService
{
    Task<List<object>> GetDoctorsAsync(CancellationToken cancellationToken = default);
    
    Task<object> GetPrescriptionsAsync(int idPrescription, CancellationToken cancellationToken = default);

    Task DeleteDoctor(int idDoctor);
    
    Task AddDoctor(DoctorDTO doctor);
    
    Task UpdateDoctor(int idDoctor, DoctorDTO doctor);
}