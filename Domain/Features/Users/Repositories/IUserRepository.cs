using Domain.Features.Users.Entities;

namespace Domain.Features.Users.Repositories
{
    public interface IUserRepository
    {
        Task InsertAsync(UserEntity user);
        Task<UserEntity[]> GetAllAsync();
        void Update(UserEntity user);
        void Delete(UserEntity user);
    }
}
