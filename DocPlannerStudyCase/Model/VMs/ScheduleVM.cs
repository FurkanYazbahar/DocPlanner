using DocPlannerStudyCase.Models.Enums;

namespace DocPlannerStudyCase.Model.VMs
{
    public class ScheduleVM
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int VisitId { get; set; }
    }
}
