using DocPlannerStudyCase.GenericRepository.BaseRep;
using DocPlannerStudyCase.Models.Context;
using DocPlannerStudyCase.Models.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DocPlannerStudyCase.GenericRepository.ConcRep
{
    public class ScheduleRepository : BaseRepository<Schedule>
    {
        public ScheduleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
