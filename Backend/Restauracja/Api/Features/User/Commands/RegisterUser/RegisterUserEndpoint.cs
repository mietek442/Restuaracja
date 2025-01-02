namespace Api.Features.User.Commands.RegisterUser
{
    using Api.Domain.Models;
    using Ardalis.ApiEndpoints;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Swashbuckle.AspNetCore.Annotations;

    public class RegisterUserEndpoint : EndpointBaseAsync
        .WithRequest<RegisterUserRequest>
        .WithActionResult<User>
    {
        private readonly IMediator _mediator;

        public RegisterUserEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("api/users/register")]
        [SwaggerOperation(
            Summary = "Registers a new User",
            Description = "Registers a new User",
            OperationId = "Users_Register",
            Tags = new[] { "Users" })
        ]
        public override async Task<ActionResult<User>> HandleAsync(RegisterUserRequest request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new RegisterUserCommand { UserRequest = request });
        }
    }
}
