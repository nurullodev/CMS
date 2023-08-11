using CMS.Service.DTOs.Damens;
using CMS.Service.DTOs.Users;
using CMS.Service.Helpers;

namespace CMS.Service.Interfaces;

public interface IUserService
{
    Task<Response<UserResultDto>> CreateAsync(UserCreationDto dto);
    Task<Response<UserResultDto>> UpdateAsync(UserUpdateDto dto);
    Task<Response<UserResultDto>> GetByIdAsync(long id);
    Task<Response<UserResultDto>> CheckEmailAndPasswordAsync(string email, string password);
    Task<Response<bool>> DeleteAsync(long id);
    Task<Response<IEnumerable<UserResultDto>>> GetAllAsync();
}
