using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.TourDetail;
using src.CQRS.TourDetail.Commands.CreateTourDetail;
using src.CQRS.TourDetail.Commands.DeleteTourDetail;
using src.CQRS.TourDetail.Commands.UpdateTourDetail;

namespace src.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TourDetailController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public TourDetailController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost(ApiRoutes.TourDetail.Create)]
        public async Task<IActionResult> Create(
            [FromBody] CreateTourDetailCommand command
        )
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                tourDetailResponse => Created(
                    "",
                    new Response<List<TourDetailResponse>>(
                        tourDetailResponse
                    )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpPut(ApiRoutes.TourDetail.Update)]
        public async Task<IActionResult> Update(
            [FromBody] UpdateTourDetailCommand command
        )
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                tourDetailResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpDelete(ApiRoutes.TourDetail.Delete)]
        public async Task<IActionResult> Delete(
            [FromBody] DeleteTourDetailCommand command
        )
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                TourDetailResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}