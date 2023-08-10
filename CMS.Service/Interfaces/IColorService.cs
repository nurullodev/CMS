using CMS.Service.DTOs.Colors;
using CMS.Service.Helpers;

namespace CMS.Service.Interfaces;

public interface IColorService
{
    Task<Response<ColorResultDto>> CreateAsync(ColorCreationDto dto);
    Task<Response<ColorResultDto>> UpdateAsync(ColorUpdateDto dto);
    Task<Response<bool>> DeleteAsync(long id);
    Task<Response<IEnumerable<ColorResultDto>>> GetAllAsync();
}