using DocPlannerStudyCase.Models.Entities;
using DocPlannerStudyCase.Models.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DocPlannerStudyCase.Options
{
    public class ScheduleMap : IEntityTypeConfiguration<Schedule>
    {

        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.HasData(new Schedule[]
            {
                new()
                {
                    Id = 1,
                    DoctorId    = 3,
                    StartTime   = DateTime.Parse("2022-05-31T10:30:00.000Z"),
                    EndTime     = DateTime.Parse("2022-05-31T10:45:00.000Z"),
                    VisitId     = 551231,
                    Status      = DataStatus.Inserted,
                    CreatedDate = DateTime.Now,
                    AppointmentStatus = AppointmentStatus.Available
                },
                new()
                {
                    Id = 2,
                    DoctorId    = 3,
                    StartTime   = DateTime.Parse("2022-06-01T10:30:00.000Z"),
                    EndTime     = DateTime.Parse("2022-06-01T10:45:00.000Z"),
                    VisitId     = 252312,
                    Status      = DataStatus.Inserted,
                    CreatedDate = DateTime.Now,
                    AppointmentStatus = AppointmentStatus.Available
                },
                new()
                {
                    Id = 3,
                    DoctorId    = 3,
                    StartTime   = DateTime.Parse("2022-06-01T10:45:00.000Z"),
                    EndTime     = DateTime.Parse("2022-06-01T10:55:00.000Z"),
                    VisitId     = 652123,
                    Status      = DataStatus.Inserted,
                    CreatedDate = DateTime.Now,
                    AppointmentStatus = AppointmentStatus.Available
                },
                new()
                {
                    Id = 4,
                    DoctorId    = 3,
                    StartTime   = DateTime.Parse("2022-06-01T16:30:00.000Z"),
                    EndTime     = DateTime.Parse("2022-06-01T16:50:00.000Z"),
                    VisitId     = 923112,
                    Status      = DataStatus.Inserted,
                    CreatedDate = DateTime.Now,
                    AppointmentStatus = AppointmentStatus.Available
                }
            });
        }
    }
}
