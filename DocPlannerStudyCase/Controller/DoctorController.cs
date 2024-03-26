using DocPlannerStudyCase.GenericRepository.InterfaceRep;
using DocPlannerStudyCase.Models.Entities;
using DocPlannerStudyCase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Text;

namespace DocPlannerStudyCase.Controllers
{
    
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly DoctorService _doctorService;

        public DoctorController(DoctorService service)
        {
            _doctorService = service;
        }

        [HttpGet("fetchDoctors")]
        public async Task<IActionResult> FetchDoctors()
        {
            var result = _doctorService.GetDoctors();
            return Ok(new
            {
                Data = result
            });
        }

        [HttpGet("exportDoctorCsv")]
        public async Task<FileResult> ExportDoctorCsv(string? nationality = "TUR", string? fileName = "DoctorsOutput.csv")
        {
            if (String.IsNullOrEmpty(fileName))
            {
                fileName = "DoctorsOutput.csv";
            }

            if (String.IsNullOrEmpty(nationality))
            {
                nationality = "TUR";
            }

            var result = _doctorService.ExportDoctorCsv(nationality);
            byte[] fileBytes = Encoding.UTF8.GetBytes(result);

            return File(fileBytes, "text/csv", fileName);
        }

        //[HttpGet("fetchDoctors")]
        //public async Task<IActionResult> FetchDoctor([FromQuery] Int32 doctorId)
        //{
        //    var doctors = (object)null ;

        //    if (doctorId == null)
        //    {
        //        doctors = _doctorRepository.GetAll();
        //    } else
        //    {
        //        doctors = _doctorRepository.Find(doctorId);
        //    }

        //    if (doctors == null)
        //    {
        //        return Ok("hatalı senaryo");    
        //    } else
        //    {
        //        return Ok(new
        //        {
        //            Data = doctors
        //        });

        //    }
        //}
    }
}
