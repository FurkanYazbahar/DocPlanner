using DocPlannerStudyCase.Models.Entities;
using DocPlannerStudyCase.Options;
using Microsoft.EntityFrameworkCore;

namespace DocPlannerStudyCase.Models.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Doctor>(new DoctorMap());
            modelBuilder.ApplyConfiguration<Schedule>(new ScheduleMap());
            modelBuilder.ApplyConfiguration<BookVisit>(new BookVisitMap());
            
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<BookVisit> BookVisits { get; set; }
    }
}
