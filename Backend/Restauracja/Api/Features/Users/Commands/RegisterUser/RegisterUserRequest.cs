namespace Api.Features.User.Commands.RegisterUser
{
    public class RegisterUserRequest
    {
        public string Name { get; set; }
        public string HashedPassword { get; set; }
        
    }
}
