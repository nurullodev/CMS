using CMS.Service.DTOs.Damens;
using CMS.Service.DTOs.FontTypes;
using CMS.Service.Helpers;

namespace CMS.Service.Interfaces;

public interface IFontTypeService
{
    Task<Response<FontTypeResultDto>> CreateAsync(FontTypeCreationDto dto);
    Task<Response<FontTypeResultDto>> UpdateAsync(FontTypeUpdateDto dto);
    Task<Response<FontTypeResultDto>> GetByIdAsync(long id);
    Task<Response<bool>> DeleteAsync(long id);
    Task<Response<IEnumerable<FontTypeResultDto>>> GetAllAsync();
}