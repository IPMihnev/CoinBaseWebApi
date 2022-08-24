namespace Domain.Features.Users.Dtos
{
    public class UserDto
    {
        public UserDto(string username, string email)
        {
            this.Username = username;
            this.Email = email;
        }
        public string Username { get; set; }
        public string Email { get; set; }
    }
}
