using Api.Domain.Models;
using Ardalis.ApiEndpoints;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace Api.Features.Users.Queries.GetLoginUser
{
   

    public class GetLoginUserEndpoint : EndpointBaseAsync
        .WithoutRequest
        .WithActionResult<ResteurantUser>
    {
        private readonly IMediator _mediator;

        public GetLoginUserEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("api/user/login")]
        [SwaggerOperation(
            Summary = "Gets the Logged-in User",
            Description = "Fetches the logged-in user details",
            OperationId = "User_Get",
            Tags = new[] { "Users" })
        ]
        public override async Task<ActionResult<ResteurantUser>> HandleAsync(CancellationToken cancellationToken = default)
        {
           return await _mediator.Send(new GetLoginUserQuery(), cancellationToken);

            
        }
    }
}
