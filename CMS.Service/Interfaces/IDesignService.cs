using CMS.Service.DTOs.Designs;
using CMS.Service.Helpers;

namespace CMS.Service.Interfaces;

public interface IDesignService
{
    Task<Response<DesignResultDto>> CreateAsync(DesignCreationDto dto);
    Task<Response<DesignResultDto>> UpdateAsync(DesignUpdateDto dto);
    Task<Response<bool>> DeleteAsync(long id);
    Task<Response<IEnumerable<DesignResultDto>>> GetAllAsync();
}