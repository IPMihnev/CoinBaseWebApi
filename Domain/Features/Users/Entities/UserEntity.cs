using Domain.Features.Users.Dtos;
using Microsoft.AspNetCore.Identity;

namespace Domain.Features.Users.Entities
{
    public class UserEntity : IdentityUser
    {
        public UserDto ToUserDto()
            => new UserDto(this.UserName, this.Email);
    }
}
