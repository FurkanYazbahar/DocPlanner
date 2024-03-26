namespace DocPlannerStudyCase.Model.VMs
{
    public class BookVisitVM
    {
        public int VisitId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Date { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public int HospitalId { get; set; }
        public int DoctorId { get; set; }
        public int BranchId { get; set; }
    }
}
