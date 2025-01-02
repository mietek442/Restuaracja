namespace Api.Domain.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string HashedPassword { get; set; }
        public bool IsAdmin { get; set; }
        public bool isLogin { get; set; }
    }
}
