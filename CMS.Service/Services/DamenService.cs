using AutoMapper;
using CMS.Data.Commons;
using CMS.Data.ICommons;
using CMS.Domain.Entities.Domains;
using CMS.Service.DTOs.Damens;
using CMS.Service.DTOs.Damens;
using CMS.Service.Helpers;
using CMS.Service.Interfaces;
using CMS.Service.Mappers;

namespace CMS.Service.Services;

public class DamenService : IDamenService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    public DamenService()
    {
        unitOfWork = new UnitOfWork();
        mapper = new Mapper(new MapperConfiguration
            (cf => cf.AddProfile<MappingProfile>()));
    }

    public async Task<Response<DamenResultDto>> CreateAsync(DamenCreationDto dto)
    {
        var existDamen = await this.unitOfWork.DamenRepository.SelectByNameAsync(dto.Name);
        if (existDamen is not null)
            return new Response<DamenResultDto>
            {
                StatusCode = 403,
                Message = "This Damen is already exist",
                Data = null
            };

        var mapperDamen = mapper.Map<Damen>(dto);
        await this.unitOfWork.DamenRepository.AddAsync(mapperDamen);
        await this.unitOfWork.SaveAsync();

        return new Response<DamenResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<DamenResultDto>(mapperDamen)
        };
    }

    public async Task<Response<DamenResultDto>> UpdateAsync(DamenUpdateDto dto)
    {
        var existDamen = await this.unitOfWork.DamenRepository.SelectByIdAsync(dto.Id);
        if (existDamen is null)
            return new Response<DamenResultDto>
            {
                StatusCode = 404,
                Message = $"This Damen Id {dto.Id} is not found",
                Data = null
            };

        var mapperDamen = mapper.Map(dto, existDamen);
        mapperDamen.UpdatedAt = DateTime.UtcNow;
        this.unitOfWork.DamenRepository.Update(mapperDamen);
        await this.unitOfWork.SaveAsync();

        return new Response<DamenResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<DamenResultDto>(mapperDamen)
        };
    }

    public async Task<Response<DamenResultDto>> GetByIdAsync(long id)
    {
        var existDamen = await this.unitOfWork.DamenRepository.SelectByIdAsync(id);
        if (existDamen is null)
            return new Response<DamenResultDto>
            {
                StatusCode = 404,
                Message = $"This Damen Id {id} is not found",
                Data = null
            };

        return new Response<DamenResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<DamenResultDto>(existDamen)
        };
    }

    public async Task<Response<bool>> DeleteAsync(long id)
    {
        var existDamen = await this.unitOfWork.DamenRepository.SelectByIdAsync(id);
        if (existDamen is null)
            return new Response<bool>
            {
                StatusCode = 404,
                Message = $"This Damen ID {id} is not found",
                Data = false
            };

        this.unitOfWork.DamenRepository.Delete(existDamen);
        await this.unitOfWork.SaveAsync();

        return new Response<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };
    }

    public async Task<Response<IEnumerable<DamenResultDto>>> GetAllAsync()
    {
        var Damens = this.unitOfWork.DamenRepository.SelectAll();
        var mapperDamens = mapper.Map<IEnumerable<DamenResultDto>>(Damens);
        return new Response<IEnumerable<DamenResultDto>>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapperDamens
        };
    }
}
