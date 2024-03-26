namespace DocPlannerStudyCase.Model.VMs
{
    public class DoctorVM
    {
        public int DoctorId { get; set; }

        public string CreatedAt { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string HospitalName { get; set; }

        public int HospitalId { get; set; }

        public int SpecialtyId { get; set; }

        public double BranchId { get; set; }

        public string Nationality { get; set; }
    }
}
