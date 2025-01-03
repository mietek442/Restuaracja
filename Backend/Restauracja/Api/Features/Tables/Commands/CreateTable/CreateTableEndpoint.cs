using Api.Domain.Models;
using Api.Features.Tables.Commands.CreateTable;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Api.Features.Tables.Commands
{
    public class CreateTableEndpoint : EndpointBaseAsync.WithRequest<CreateTableRequest>.WithActionResult<Table>
    {
        private readonly IMediator _mediator;

        public CreateTableEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("api/tables")]
        [SwaggerOperation(
            Summary = "Creates a new table",
            Description = "Creates a new table",
            OperationId = "Tables_Create",
            Tags = new[] { "Tables" })]
        public override async Task<ActionResult<Table>> HandleAsync(CreateTableRequest request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new CreateTableCommand { TableRequest = request });
        }
    }
}