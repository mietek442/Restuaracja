namespace Api.Features.User.Commands.LoginUser
{
    using Api.Features.User.Commands.LogutUser;
    using Ardalis.ApiEndpoints;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using Swashbuckle.AspNetCore.Annotations;
    using System.Threading;
    using System.Threading.Tasks;

    public class LoginUserEndpoint : EndpointBaseAsync
        .WithRequest<LoginUserRequest>
        .WithActionResult<string>
    {
        private readonly IMediator _mediator;

        public LoginUserEndpoint(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("api/user/login")]
        [SwaggerOperation(
            Summary = "Logs in a User",
            Description = "Verifies user credentials and logs in the user",
            OperationId = "User_Login",
            Tags = new[] { "User" })
        ]
        public override async Task<ActionResult<string>> HandleAsync(LoginUserRequest request, CancellationToken cancellationToken = default)
        {
            return await _mediator.Send(new LoginUserCommand { LoginRequest = request }, cancellationToken);
            
        }
    }
}
