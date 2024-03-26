using DocPlannerStudyCase.Model.VMs;
using DocPlannerStudyCase.Models.Entities;

namespace DocPlannerStudyCase.Services.IServices
{
    public interface IBookVisitService
    {
        int AddBookVisit(BookVisitVM bookVisit);
        bool CancelBookVisit(int? bookingId);
    }
}
