using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.Tour;
using src.CQRS.Tour.Commands.CreateTour;
using src.CQRS.Tour.Queries;

namespace src.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TourController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TourController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(ApiRoutes.Tour.Create)]
        public async Task<IActionResult> Create([FromBody] CreateTourCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                tourResponse => Created("", new Response<TourResponse>(
                    tourResponse
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.Tour.GetAll)]
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

        [HttpGet(ApiRoutes.Tour.GetById)]
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

    }
}