using DocPlannerStudyCase.Models.Enums;
using Newtonsoft.Json;

namespace DocPlannerStudyCase.Models.Entities
{
    public class Schedule : BaseEntity
    {
        public int DoctorId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int VisitId { get; set; }
        public AppointmentStatus AppointmentStatus { get; set; }
        //Releational Properties
        public virtual Doctor Doctor { get; set; }
    }
}
