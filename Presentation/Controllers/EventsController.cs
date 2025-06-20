﻿using Microsoft.AspNetCore.Mvc;
using Presentation.Services;

namespace Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EventsController : ControllerBase
{
    private readonly IEventService _eventService;

    public EventsController(IEventService eventService)
    {
        _eventService = eventService;
    }

    [HttpGet]
    public IActionResult GetEvents()
    {
        var events = _eventService.GetEvents();
        return Ok(events);
    }
}
