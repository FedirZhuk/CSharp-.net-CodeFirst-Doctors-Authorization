using Cwiczenia9.DTO;
using Cwiczenia9.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia9.Controllers;

[Authorize]
[ApiController]
[Route("api/doctors")]
public class DoctorsController : Controller
{
    private readonly IMedDbService _medDbService;

    public DoctorsController(IMedDbService medDbService)
    {
        _medDbService = medDbService;
    }

    [HttpGet]
    public async Task<IActionResult> GetDoctors(CancellationToken cancellationToken)
    {
        IList<object> doctors = await _medDbService.GetDoctorsAsync(cancellationToken);
        return Ok(doctors);
    }

    [HttpPost]
    public async Task<IActionResult> AddDoctor(DoctorDTO doctor)
    {
        await _medDbService.AddDoctor(doctor);
        return Ok();
    }
    
    [HttpPut]
    public async Task<IActionResult> UpdateDotor(int idDoctor, DoctorDTO doctor)
    {
        await _medDbService.UpdateDoctor(idDoctor, doctor);
        return Ok();
    }
    
    [HttpDelete]
    public async Task<IActionResult> DeleteDoctor(int idDoctor)
    {
        await _medDbService.DeleteDoctor(idDoctor);
        return Ok();
    }
    
    [HttpGet]
    [Route("/api/prescriptions")]
    public async Task<IActionResult> GetPrescription(int idPrescription, CancellationToken cancellationToken)
    {
        var prescriptions = await _medDbService.GetPrescriptionsAsync(idPrescription, cancellationToken);
        return Ok(prescriptions);
    }
}