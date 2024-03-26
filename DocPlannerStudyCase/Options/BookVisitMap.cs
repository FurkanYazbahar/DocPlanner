using DocPlannerStudyCase.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DocPlannerStudyCase.Options
{
    public class BookVisitMap : IEntityTypeConfiguration<BookVisit>
    {
        public void Configure(EntityTypeBuilder<BookVisit> builder)
        {           
        }
    }
}
