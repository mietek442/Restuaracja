namespace Api.Features.User.Commands.RegisterUser
{
    using Api.Domain.Models;
    using Api.Infrastructure.DbContext;
    using MediatR;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    public class RegisterUserCommand : IRequest<ActionResult<ResteurantUser>>
    {
        public RegisterUserRequest UserRequest { get; set; }
    }

    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, ActionResult<ResteurantUser>>
    {
        private readonly IApplicationContext _context;
        private readonly PasswordHasher<object> _passwordHasher;
        public RegisterUserCommandHandler(IApplicationContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher<object>();
        }

        public async Task<ActionResult<ResteurantUser>> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            var users = await _context.Users
               .ToListAsync(cancellationToken);

            bool isAdmin = false;
            if (users == null || users.Count == 0)
            {
               isAdmin = true;
            }

            
            var user = new ResteurantUser
            {
                Id = Guid.NewGuid(),
                Name = request.UserRequest.Name,
                HashedPassword = _passwordHasher.HashPassword(5, request.UserRequest.HashedPassword),
                IsAdmin = isAdmin
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync(cancellationToken);

            return new OkObjectResult(user);
        }
    }
}
