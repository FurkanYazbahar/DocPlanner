using DocPlannerStudyCase.GenericRepository.BaseRep;
using DocPlannerStudyCase.Models.Context;
using DocPlannerStudyCase.Models.Entities;

namespace DocPlannerStudyCase.GenericRepository.ConcRep
{
    public class BookVisitRepository : BaseRepository<BookVisit>
    {
        public BookVisitRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }

    }
}
