using DocPlannerStudyCase.Model.VMs;
using DocPlannerStudyCase.Services;
using Microsoft.AspNetCore.Mvc;

namespace DocPlannerStudyCase.Controllers
{
    [Route("BookVisit")]
    [ApiController]
    public class BookVisitController : ControllerBase
    {
        private readonly BookVisitService _bookVisitService;

        public BookVisitController(BookVisitService bookVisitService)
        {
            _bookVisitService = bookVisitService;
        }

        [HttpPost]
        public async Task<IActionResult> AddBookVisit([FromQuery] BookVisitVM bookVisit)
        {
            int bookingId = _bookVisitService.AddBookVisit(bookVisit);
            if (bookingId <= 0)
            {
                return Ok( new { status = false } );
            }

            return Ok( new { status = true, BookingID = bookingId } );
        }

        [HttpPost("/cancelVisit")]
        public async Task<IActionResult> CancelBookVisit([FromQuery] int? bookingId)
        {
            bool result = _bookVisitService.CancelBookVisit(bookingId);

            return Ok(new{ status = result });
        }
    }
}
