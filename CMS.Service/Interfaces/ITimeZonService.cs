using CMS.Service.DTOs.Damens;
using CMS.Service.DTOs.TimeZones;
using CMS.Service.Helpers;

namespace CMS.Service.Interfaces;

public interface ITimeZonService
{
    Task<Response<TimeZonResultDto>> CreateAsync(TimeZonCreationDto dto);
    Task<Response<TimeZonResultDto>> UpdateAsync(TimeZonUpdateDto dto);
    Task<Response<TimeZonResultDto>> GetByIdAsync(long id);
    Task<Response<bool>> DeleteAsync(long id);
    Task<Response<IEnumerable<TimeZonResultDto>>> GetAllAsync();
}