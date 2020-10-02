using System;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.TourCategory;
using src.CQRS.TourCategory.Commands.CreateTourCategory;
using src.CQRS.TourCategory.Commands.DeleteTourCategory;
using src.CQRS.TourCategory.Commands.UpdateTourCategory;
using src.CQRS.TourCategory.Queries;

namespace src.Controllers.V1
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TourCategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public TourCategoriesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        [HttpPost(ApiRoutes.TourCategory.Create)]
        public async Task<IActionResult> Create([FromBody] CreateTourCategoryCommand command)
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                tourCategoryResponse => Created("", new Response<TourCategoryResponse>(
                    tourCategoryResponse
                )),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.TourCategory.GetById)]
        public async Task<IActionResult> GetById(
            [FromRoute] Guid tourCategoryId)
        {
            var getTourCategoryByIdQuery = new GetTourCategoryByIdQuery(tourCategoryId);
            var result = await _mediator.Send(getTourCategoryByIdQuery);

            return result.Match<IActionResult>(
                tourCategoryResponse => Ok(
                    new Response<TourCategoryResponse>(
                        tourCategoryResponse
                    )
                ),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpDelete(ApiRoutes.TourCategory.Delete)]
        public async Task<IActionResult> Delete(
            [FromRoute] Guid tourCategoryId
        )
        {
            var deleteTourCategoryCommand = new DeleteTourCategoryCommand(tourCategoryId);

            var result = await _mediator.Send(deleteTourCategoryCommand);

            return result.Match<IActionResult>(
                tourCategoryResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpPut(ApiRoutes.TourCategory.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] Guid tourCategoryId,
            [FromBody] UpdateTourCategoryCommand command)
        {
            command.Id = tourCategoryId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                tourCategoryResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.TourCategory.GetAll)]
        public async Task<IActionResult> GetAll([FromQuery] GetAllTourCategoriesQuery query)
        {
            var result = await _mediator.Send(query);

            return result.Match<IActionResult>(
                data => Ok(
                    new Response<PagedResponse<TourCategoryResponse>>(
                        data
                    )
                ),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}