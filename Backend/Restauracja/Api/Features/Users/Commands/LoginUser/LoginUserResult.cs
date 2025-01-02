namespace Api.Features.User.Commands.LogutUser
{
    public class LoginUserResult
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
        public bool isLogin { get; set; }
    }
}
