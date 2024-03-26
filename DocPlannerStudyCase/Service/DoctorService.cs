using AutoMapper;
using DocPlannerStudyCase.GenericRepository.InterfaceRep;
using DocPlannerStudyCase.Helper;
using DocPlannerStudyCase.Model;
using DocPlannerStudyCase.Model.VMs;
using DocPlannerStudyCase.Models.Entities;
using DocPlannerStudyCase.Models.Enums;
using DocPlannerStudyCase.Services.IServices;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Xml.Linq;

namespace DocPlannerStudyCase.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IRepository<Doctor> _doctorRepository;
        private readonly IMapper _mapper;

        public DoctorService(IRepository<Doctor> doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
        }

        public List<DoctorVM> GetDoctors()
        {
            List<Doctor> doctorList = _doctorRepository.GetAll();

            List<DoctorVM> list = _mapper.Map<List<Doctor>, List<DoctorVM>>(doctorList);

            return list;
        }

        public string ExportDoctorCsv(string nationality = "TUR")
        {
            StringBuilder sb = new StringBuilder();
            string resultStr = "";
            try
            {
                sb.AppendLine("DoctorId, Name, Gender, HospitalId, HospitalName, SpecialtyId, CreatedAt, BranchId, Nationality");

                List<Doctor> doctorList = _doctorRepository.Where(d => d.Nationality == nationality && d.Status != Models.Enums.DataStatus.Deleted);
                foreach (Doctor doctor in doctorList)
                {
                    string gender;
                    
                    if (doctor.Gender == Gender.female)
                    {
                        gender = "Kadın";
                    } else if (doctor.Gender == Gender.male)
                    {
                        gender = "Erkek";
                    } else
                    {
                        // bozuk veriler alınan hata gösterilsin
                        gender = "ERROR";
                    }
                    
                    sb.AppendLine($"{doctor.Id},{doctor.Name},{gender},{doctor.HospitalId},{doctor.HospitalName},{doctor.SpecialtyId},{DateHelper.DateTime2UTCDateString(doctor.CreatedAt)},{doctor.BranchId},{doctor.Nationality}");
                }

                resultStr = sb.ToString();
            } catch (Exception ex) {
                resultStr = ex.Message;
            }

            return resultStr;
        }
    }
}
