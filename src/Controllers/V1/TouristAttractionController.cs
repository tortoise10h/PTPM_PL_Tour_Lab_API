using System;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.CQRS.TouristAttraction.Commands.CreateTouristAttraction;
using src.CQRS.TouristAttraction.Commands.DeleteTouristAttraction;
using src.CQRS.TouristAttraction.Commands.UpdateTouristAttraction;
using src.CQRS.TouristAttraction.Queries;

namespace src.Controllers.V1
{
    public class TouristAttractionController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public TouristAttractionController(IMediator mediator, IMapper mapper = null)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost(ApiRoutes.TouristAttraction.Create)]
        public async Task<IActionResult> Create([FromBody] CreateTouristAttractionCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                touristAttractionResponse => Created("", touristAttractionResponse),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpPut(ApiRoutes.TouristAttraction.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] Guid touristAttractionId,
            [FromBody] UpdateTouristAttractionCommand command
        )
        {
            command.Id = touristAttractionId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                touristAttractionResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.TouristAttraction.GetById)]
        public async Task<IActionResult> GetById(
            [FromRoute] Guid touristAttractionId
        )
        {
            var getTouristAttractionById = new GetTouristAttractionByIdQuery(touristAttractionId);
            var result = await _mediator.Send(getTouristAttractionById);

            return result.Match<IActionResult>(
                touristAttractionResponse => Ok(touristAttractionResponse),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpDelete(ApiRoutes.TouristAttraction.Delete)]
        public async Task<IActionResult> Delete(
            [FromRoute] Guid touristAttractionId
        )
        {
            var deleteTouristAttractionCommand = new DeleteTouristAttractionCommand(touristAttractionId);
            var result = await _mediator.Send(deleteTouristAttractionCommand);

            return result.Match<IActionResult>(
                touristAttractionResponse => NoContent(),
                exp => 
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.TouristAttraction.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllTouristAttractionQuery query
        )
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                touristAttractionResponse => Ok(touristAttractionResponse),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}