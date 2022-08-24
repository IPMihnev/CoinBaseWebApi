using Domain.Features.Users.Entities;
using Domain.Features.Users.Repositories;
using MediatR;

namespace WebApiProject.Handlers.Users.Create
{
    public class CreateUserRequestHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
    {
        private readonly IUserRepository userRepository;

        public CreateUserRequestHandler(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.UserName)
                || string.IsNullOrEmpty(request.Email)
                || string.IsNullOrEmpty(request.Password))
            {
                throw new InvalidDataException("Invalid user data!");
            }
            var user = new UserEntity
            {
                UserName = request.UserName,
                Email = request.Email,
            };

            var result = await this.userRepository.InsertAsync(user, request.Password);
            if (result)
            {
                return new CreateUserResponse(user.ToUserDto());
            }

            throw new InvalidOperationException("Internal operation error!");
        }
    }
}
