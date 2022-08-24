using Domain.Features.Users.Entities;

namespace Domain.Features.Users.Repositories
{
    public interface IUserRepository
    {
        Task<List<UserEntity>> GetAllAsync();
        Task<bool> InsertAsync(UserEntity user, string password);
        Task<bool> UpdateAsync(UserEntity user);
        Task<bool> DeleteAsync(UserEntity user);
        Task<bool> CheckPasswordAsync(UserEntity user, string password);
    }
}
