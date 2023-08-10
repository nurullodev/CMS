using CMS.Service.DTOs.Colors;
using CMS.Service.DTOs.Damens;
using CMS.Service.Helpers;

namespace CMS.Service.Interfaces;

public interface IDamenService
{
    Task<Response<DamenResultDto>> CreateAsync(DamenCreationDto dto);
    Task<Response<DamenResultDto>> UpdateAsync(DamenUpdateDto dto);
    Task<Response<DamenResultDto>> GetByIdAsync(long id);
    Task<Response<bool>> DeleteAsync(long id);
    Task<Response<IEnumerable<DamenResultDto>>> GetAllAsync();
}