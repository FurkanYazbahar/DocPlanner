using DocPlannerStudyCase.GenericRepository.InterfaceRep;
using DocPlannerStudyCase.Models.Entities;
using DocPlannerStudyCase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DocPlannerStudyCase.Controllers
{
    [ApiController]
    [Route("fetchSchedules")]
    public class ScheduleController : ControllerBase
    {
        private readonly ScheduleService _scheduleService;

        public ScheduleController(ScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        [HttpGet]
        public async Task<IActionResult> FetchSchedules([FromQuery] int doctorId)
        {
            var resultList = _scheduleService.GetSchedules(doctorId);

            if (resultList is null || resultList.Count == 0)
            {
                return Ok( new { Message = "NO_SLOT_FOUND" });
            }

            return Ok( new { Data = resultList });
        }
    }
}
