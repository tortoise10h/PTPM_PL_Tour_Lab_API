using System.Collections.Generic;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.Tour;
using src.CQRS.Statistic.Queries;

namespace src.Controllers.V1
{
    public class StatisticController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet(ApiRoutes.Statistic.GetAllTourArrival)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllToursByDateTimeQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<List<TourWithGroupStatisticResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.Statistic.GetAllTourPrice)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllTourPriceByDateTimeQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<List<TourWithPriceStatisticResponse>>(
                    data
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.Statistic.GetAllStaff)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllStaffArrivalQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(new Response<List<TourWithStaffStatisticResponse>>(
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