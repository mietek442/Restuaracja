namespace Api.Features.User.Commands.LogoutUser
{
    using Api.Features.User.Commands.LogutUser;
    using Ardalis.ApiEndpoints;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Swashbuckle.AspNetCore.Annotations;
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class LogoutUserEndpoint : EndpointBaseAsync
        .WithoutRequest
        .WithActionResult
    {
        private readonly IMediator _mediator;

        public LogoutUserEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("api/user/logout/")]
        [SwaggerOperation(
            Summary = "Logs out a User",
            Description = "Logs out a user by ID",
            OperationId = "User_Logout",
            Tags = new[] { "Users" })
        ]
        public override async Task<ActionResult> HandleAsync(CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new LogoutUserCommand {  });
        }
    }
}
