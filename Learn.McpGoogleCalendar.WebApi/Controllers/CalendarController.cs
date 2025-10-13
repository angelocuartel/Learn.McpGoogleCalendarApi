

using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class CalendarController : ControllerBase
{
    private readonly CalendarService _calendarService;

    public CalendarController(CalendarService calendarService)
    =>_calendarService = calendarService;

    [HttpGet("events")]
    public async Task<IActionResult> GetEvents(Event calendarEvent)
    {
        await _calendarService.Events.Insert(calendarEvent, "primary").ExecuteAsync();
        
        return Ok();
    }
}