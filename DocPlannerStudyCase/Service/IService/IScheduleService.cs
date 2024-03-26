using DocPlannerStudyCase.Model.VMs;
using DocPlannerStudyCase.Models.Entities;

namespace DocPlannerStudyCase.Services.IServices
{
    public interface IScheduleService
    {
        List<ScheduleVM> GetSchedules(int doctorId);
    }
}
