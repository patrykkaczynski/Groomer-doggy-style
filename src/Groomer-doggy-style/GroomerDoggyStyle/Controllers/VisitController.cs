﻿using GroomerDoggyStyle.Application.Visits.Commands.CreteVisit;
using GroomerDoggyStyle.Application.Visits.Commands.DeleteVisit;
using GroomerDoggyStyle.Application.Visits.Commands.UpdateVisit;
using GroomerDoggyStyle.Application.Visits.DTO;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GroomerDoggyStyle.Api.Controllers;
[Route("api/visits")]
[ApiController]
public class VisitController : ControllerBase
{
    private readonly IMediator _mediator;

    public VisitController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost]
    public async Task<ActionResult> Create([FromBody] VisitDto visitDto)
    {
        var id = await _mediator.Send(new CreateVisitCommand(visitDto));

        return Created($"api/visits/{id}", null);
    }
    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete([FromRoute] int id)
    {
        await _mediator.Send(new DeleteVisitCommand(id));

        return NoContent();
    }
    [HttpPut("{id}")]
    public async Task<ActionResult> Update([FromRoute] int id, [FromBody] VisitDto visitDto)
    {
        await _mediator.Send(new UpdateVisitCommand(visitDto, id));

        return NoContent();
    }
}