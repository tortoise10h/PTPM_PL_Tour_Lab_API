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
using src.CQRS.TourPrice.Commands.DeleteTourPrice;
using src.CQRS.TourPrice.Queries;

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

        [HttpGet(ApiRoutes.TourPrice.GetAll)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllTourPricesQuery query)
        {
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

        [HttpGet(ApiRoutes.TourPrice.GetById)]
        public async Task<IActionResult> GetById([FromRoute] int tourPriceId)
        {
            var query = new GetTourPriceById(tourPriceId);
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                tourResponse => Ok(new Response<TourPriceResponse>(
                    tourResponse
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpPut(ApiRoutes.TourPrice.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] int tourPriceId,
            [FromBody] UpdateTourPriceCommand command)
        {
            command.Id = tourPriceId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                tourResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpDelete(ApiRoutes.TourPrice.Delete)]
        public async Task<IActionResult> Delete(
            [FromRoute] int tourPriceId
        )
        {
            var deleteTourPriceCommand = new DeleteTourPriceCommand(tourPriceId);
            var result = await _mediator.Send(deleteTourPriceCommand);

            return result.Match<IActionResult>(
                tourPriceResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}