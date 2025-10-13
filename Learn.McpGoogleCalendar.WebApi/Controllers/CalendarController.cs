

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

    [HttpPost("events")]
    public async Task<IActionResult> InsertEventAsync(Event calendarEvent)
    {
        await _calendarService.Events.Insert(calendarEvent, "primary").ExecuteAsync();

        return Ok();
    }

        [HttpPost("test/events")]
    public async Task<IActionResult> InsertTestEventAsync()
    {
        var calendarEvent = new Event();
        calendarEvent.Summary = "Test Event";
        calendarEvent.Location = "800 Howard St., San Francisco, CA 94103";
        calendarEvent.Description = "A chance to hear more about Google's developer products.";
        calendarEvent.Start = new EventDateTime()
        {
            DateTimeDateTimeOffset = DateTime.Parse("2024-07-01T09:00:00-07:00"),
            TimeZone = "America/Los_Angeles",
        };

        await _calendarService.Events.Insert(calendarEvent, "primary").ExecuteAsync();
        
        return Ok();
    }
}