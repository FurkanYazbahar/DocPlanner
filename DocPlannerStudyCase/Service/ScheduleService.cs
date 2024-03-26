using AutoMapper;
using DocPlannerStudyCase.GenericRepository.InterfaceRep;
using DocPlannerStudyCase.Model.VMs;
using DocPlannerStudyCase.Models.Entities;
using DocPlannerStudyCase.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace DocPlannerStudyCase.Services
{
    public class ScheduleService : IScheduleService
    {
        private readonly IRepository<Schedule> _scheduleRepository;
        private readonly IMapper _mapper;
        public ScheduleService(IRepository<Schedule> scheduleRepository, IMapper mapper)
        {
            _scheduleRepository = scheduleRepository;
            _mapper = mapper;
        }

        public List<ScheduleVM> GetSchedules(int doctorId)
        {
            List<ScheduleVM> result = new List<ScheduleVM>();
            try
            {
                List<Schedule> schedules = _scheduleRepository.Where(s => s.DoctorId == doctorId).ToList();
                result = _mapper.Map<List<Schedule>, List<ScheduleVM>>(schedules);
            } catch(Exception e)
            {
                result = null;
            }

            return result;
        }
    }
}
