using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.Tour;
using src.Contracts.V1.ResponseModels.TourPrice;
using src.CQRS.Tour.Commands.UpdateTour;
using src.CQRS.Tour.Queries;
using src.CQRS.TourPrice.Commands.CreateTourPrice;

namespace src.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TourPriceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TourPriceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(ApiRoutes.TourPrice.Create)]
        public async Task<IActionResult> Create([FromBody] CreateTourPriceCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                tourPriceResponse => Created("", new Response<TourPriceResponse>(
                    tourPriceResponse
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        public async Task<IActionResult> GetAll([FromQuery] GetAllToursQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<PagedResponse<TourResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        public async Task<IActionResult> GetById([FromRoute] Guid tourId)
        {
            var query = new GetTourByIdQuery(tourId);
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                tourResponse => Ok(new Response<TourResponse>(
                    tourResponse
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        public async Task<IActionResult> Update(
            [FromRoute] Guid tourId,
            [FromBody] UpdateTourCommand command)
        {
            command.Id = tourId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                tourResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

    }
}