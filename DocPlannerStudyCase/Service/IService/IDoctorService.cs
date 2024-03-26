using DocPlannerStudyCase.Model.VMs;
using DocPlannerStudyCase.Models.Entities;

namespace DocPlannerStudyCase.Services.IServices
{
    public interface IDoctorService
    {
        List<DoctorVM> GetDoctors();
    }
}
