using DocPlannerStudyCase.GenericRepository.BaseRep;
using DocPlannerStudyCase.Models.Context;
using DocPlannerStudyCase.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace DocPlannerStudyCase.GenericRepository.ConcRep
{
    public class DoctorRepository : BaseRepository<Doctor>
    {
        public DoctorRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
