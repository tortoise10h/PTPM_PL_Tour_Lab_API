using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.Group;
using src.Contracts.V1.ResponseModels.Tour;
using src.Contracts.V1.ResponseModels.TourPrice;
using src.CQRS.Tour.Commands.CreateTour;
using src.CQRS.Tour.Commands.DeleteTour;
using src.CQRS.Tour.Commands.UpdateTour;
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
        public async Task<IActionResult> GetById([FromRoute] int tourId)
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

        [HttpPut(ApiRoutes.Tour.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] int tourId,
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

        [HttpDelete(ApiRoutes.Tour.Delete)]
        public async Task<IActionResult> Delete(
            [FromRoute] int tourId
        )
        {
            var deleteGroup = new DeleteTourCommand(tourId);
            var result = await _mediator.Send(deleteGroup);

            return result.Match<IActionResult>(
                tourResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.Tour.GetTourPricesOfTour)]
        public async Task<IActionResult> GetTourPricesOfTour([FromRoute] int tourId, [FromQuery] GetTourPricesOfTourQuery query)
        {
            query.TourId = tourId;
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<PagedResponse<TourPriceResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.Tour.GetGroupsOfTour)]
        public async Task<IActionResult> GetTourPricesOfTour([FromRoute] int tourId, [FromQuery] GetGroupsOfTourQuery query)
        {
            query.TourId = tourId;
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<PagedResponse<GroupResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}