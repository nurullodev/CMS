using AutoMapper;
using CMS.Data.Commons;
using CMS.Data.ICommons;
using CMS.Service.Helpers;
using CMS.Service.Mappers;
using CMS.Service.Interfaces;
using CMS.Service.DTOs.TimeZones;
using CMS.Domain.Entities.TimeZones;

namespace CMS.Service.Services;

public class TimeZonService : ITimeZonService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    public TimeZonService()
    {
        unitOfWork = new UnitOfWork();
        mapper = new Mapper(new MapperConfiguration
            (cf => cf.AddProfile<MappingProfile>()));
    }

    public async Task<Response<TimeZonResultDto>> CreateAsync(TimeZonCreationDto dto)
    {
        var existTimeZon = await this.unitOfWork.TimeZonRepository.SelectByNameAsync(dto.Name);
        if (existTimeZon is not null)
            return new Response<TimeZonResultDto>
            {
                StatusCode = 403,
                Message = "This TimeZon is already exist",
                Data = null
            };

        var mapperTimeZon = mapper.Map<TimeZon>(dto);
        await this.unitOfWork.TimeZonRepository.AddAsync(mapperTimeZon);
        await this.unitOfWork.SaveAsync();

        return new Response<TimeZonResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<TimeZonResultDto>(mapperTimeZon)
        };
    }

    public async Task<Response<TimeZonResultDto>> UpdateAsync(TimeZonUpdateDto dto)
    {
        var existTimeZon = await this.unitOfWork.TimeZonRepository.SelectByIdAsync(dto.Id);
        if (existTimeZon is null)
            return new Response<TimeZonResultDto>
            {
                StatusCode = 404,
                Message = $"This TimeZon Id {dto.Id} is not found",
                Data = null
            };

        var mapperTimeZon = mapper.Map(dto, existTimeZon);
        mapperTimeZon.UpdatedAt = DateTime.UtcNow;
        this.unitOfWork.TimeZonRepository.Update(mapperTimeZon);
        await this.unitOfWork.SaveAsync();

        return new Response<TimeZonResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<TimeZonResultDto>(mapperTimeZon)
        };
    }

    public async Task<Response<TimeZonResultDto>> GetByIdAsync(long id)
    {
        var existTimeZon = await this.unitOfWork.TimeZonRepository.SelectByIdAsync(id);
        if (existTimeZon is null)
            return new Response<TimeZonResultDto>
            {
                StatusCode = 404,
                Message = $"This TimeZon Id {id} is not found",
                Data = null
            };

        return new Response<TimeZonResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<TimeZonResultDto>(existTimeZon)
        };
    }

    public async Task<Response<bool>> DeleteAsync(long id)
    {
        var existTimeZon = await this.unitOfWork.TimeZonRepository.SelectByIdAsync(id);
        if (existTimeZon is null)
            return new Response<bool>
            {
                StatusCode = 404,
                Message = $"This TimeZon ID {id} is not found",
                Data = false
            };

        this.unitOfWork.TimeZonRepository.Delete(existTimeZon);
        await this.unitOfWork.SaveAsync();

        return new Response<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };
    }

    public async Task<Response<IEnumerable<TimeZonResultDto>>> GetAllAsync()
    {
        var timeZons = this.unitOfWork.TimeZonRepository.SelectAll();
        var mapperTimeZons = mapper.Map<IEnumerable<TimeZonResultDto>>(timeZons);
        return new Response<IEnumerable<TimeZonResultDto>>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapperTimeZons
        };
    }
}
