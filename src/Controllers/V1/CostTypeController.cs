using System;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using src.Contracts.V1;
using src.Contracts.V1.ResponseModels;
using src.Contracts.V1.ResponseModels.CostType;
using src.CQRS.CostType.Commands.CreateCostType;
using src.CQRS.CostType.Commands.DeleteCostType;
using src.CQRS.CostType.Commands.UpdateCostType;
using src.CQRS.CostType.Queries;

namespace src.Controllers.V1
{
    public class CostTypeController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;
        public CostTypeController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost(ApiRoutes.CostType.Create)]
        public async Task<IActionResult> Create(
            [FromBody] CreateCostTypeCommand command
        )
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                costTypeResponse => Created("", new Response<CostTypeResponse>(costTypeResponse)),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpPut(ApiRoutes.CostType.Update)]
        public async Task<IActionResult> Update(
            [FromRoute] Guid costTypeId,
            [FromBody] UpdateCostTypeCommand command
        )
        {
            command.Id = costTypeId;
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                costTypeResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.CostType.GetById)]
        public async Task<IActionResult> GetById(
            [FromRoute] Guid costTypeId
        )
        {
            var getCostTypeById = new GetCostTypeByIdQuery(costTypeId);
            var result = await _mediator.Send(getCostTypeById);

            return result.Match<IActionResult>(
                costTypeResponse => Ok(new Response<CostTypeResponse>(costTypeResponse)),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpGet(ApiRoutes.CostType.GetAll)]
        public async Task<IActionResult> GetAll(
            [FromQuery] GetAllCostTypeQuery command
        )
        {
            var result = await _mediator.Send(command);

            return result.Match<IActionResult>(
                costTypeResponse => Ok(new Response<PagedResponse<CostTypeResponse>>(costTypeResponse)),
                exp =>
                {
                    throw exp;
                }
            );
        }

        [HttpDelete(ApiRoutes.CostType.Delete)]
        public async Task<IActionResult> Delete(
            [FromRoute] Guid costTypeId
        )
        {
            var deleteCostType = new DeleteCostTypeCommand(costTypeId);
            var result = await _mediator.Send(deleteCostType);

            return result.Match<IActionResult>(
                costTypeResponse => NoContent(),
                exp =>
                {
                    throw exp;
                }
            );
        }
    }
}