using AutoMapper;
using DocPlannerStudyCase.Helper;
using DocPlannerStudyCase.Model.VMs;
using DocPlannerStudyCase.Models.Entities;

namespace DocPlannerStudyCase.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Doctor, DoctorVM>()
                .ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(
                    (src, dest, destMember, context) => {
                        return DateHelper.DateTime2UTCDateString(src.CreatedAt);
                    })
                );

               
            CreateMap<DoctorVM, Doctor>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DoctorId))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(
                    (src, dest, destMember, context) => {
                        return DateHelper.String2DateTime(src.CreatedAt);
                    })
                );

            CreateMap<Schedule, ScheduleVM>()
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(
                    (src, dest, destMember, context) => {
                        return DateHelper.DateTime2UTCDateString(src.StartTime);
                    })
                )
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(
                    (src, dest, destMember, context) => {
                        return DateHelper.DateTime2UTCDateString(src.EndTime);
                    })
                );

            CreateMap<ScheduleVM, Schedule>()
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(
                    (src, dest, destMember, context) =>
                    {
                        return DateHelper.String2DateTime(src.StartTime);
                    })
                )
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(
                    (src, dest, destMember, context) =>
                    {
                        return DateHelper.String2DateTime(src.EndTime);
                    })
                );

            CreateMap<BookVisit, BookVisitVM>();
            CreateMap<BookVisitVM, BookVisit>();


        }
    }
}
