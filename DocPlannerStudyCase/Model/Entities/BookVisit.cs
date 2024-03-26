namespace DocPlannerStudyCase.Models.Entities
{
    public class BookVisit : BaseEntity
    {
        public int VisitId { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
    }
}
