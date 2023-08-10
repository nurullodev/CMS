using CMS.Service.DTOs.DesignTools;
using CMS.Service.Helpers;

namespace CMS.Service.Interfaces;

public interface IDesignToolService
{
    Task<Response<DesignToolResultDto>> CreateAsync(DesignToolCreationDto dto);
    Task<Response<DesignToolResultDto>> UpdateAsync(DesignToolUpdateDto dto);
    Task<Response<bool>> DeleteAsync(long id);
    Task<Response<IEnumerable<DesignToolResultDto>>> GetAllAsync();
}