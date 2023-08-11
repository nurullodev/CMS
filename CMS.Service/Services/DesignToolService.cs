using AutoMapper;
using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.ICommons;
using CMS.Domain.Entities.DesignTools;
using CMS.Service.DTOs.Colors;
using CMS.Service.DTOs.DesignTools;
using CMS.Service.DTOs.FontTypes;
using CMS.Service.Helpers;
using CMS.Service.Interfaces;
using CMS.Service.Mappers;

namespace CMS.Service.Services;

public class DesignToolService : IDesignToolService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    public DesignToolService()
    {
        unitOfWork = new UnitOfWork();
        mapper = new Mapper(new MapperConfiguration
            (cf => cf.AddProfile<MappingProfile>()));
    }

    public async Task<Response<DesignToolResultDto>> CreateAsync(DesignToolCreationDto dto)
    {
        var existTool = await this.unitOfWork
            .DesignToolRepository.SelectByColorIdAndFontIdAsync(dto.ColorId, dto.FontTypeId);

        if (existTool is not null)
            return new Response<DesignToolResultDto>
            {
                StatusCode = 403,
                Message = "This tool is already exist",
                Data = null
            };

        var isValidColorId = await this.unitOfWork.ColorRepository.SelectByIdAsync(dto.ColorId);
        if (isValidColorId is null)
            return new Response<DesignToolResultDto>
            {
                StatusCode = 404,
                Message = "This color Id is not found"
            };
        var isValidFontTypeId = await this.unitOfWork.FontTypeRepository.SelectByIdAsync(dto.FontTypeId);
        if (isValidFontTypeId is null)
            return new Response<DesignToolResultDto>
            {
                StatusCode = 404,
                Message = "This font type Id is not found"
            };
        var mapperTool = mapper.Map<DesignTool>(dto);
        await this.unitOfWork.DesignToolRepository.AddAsync(mapperTool);
        await this.unitOfWork.SaveAsync();

        var result = Including(mapperTool);

        return new Response<DesignToolResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = result
        };
    }

    public async Task<Response<DesignToolResultDto>> UpdateAsync(DesignToolUpdateDto dto)
    {
        var existTool = await this.unitOfWork.DesignToolRepository.SelectByIdAsync(dto.Id);
        if (existTool is null)
            return new Response<DesignToolResultDto>
            {
                StatusCode = 404,
                Message = "Not found",
                Data = null
            };
        var isValidColorId = await this.unitOfWork.ColorRepository.SelectByIdAsync(dto.ColorId);
        if (isValidColorId is null)
            return new Response<DesignToolResultDto>
            {
                StatusCode = 404,
                Message = "This color Id is not found"
            };
        var isValidFontTypeId = await this.unitOfWork.FontTypeRepository.SelectByIdAsync(dto.FontTypeId);
        if (isValidFontTypeId is null)
            return new Response<DesignToolResultDto>
            {
                StatusCode = 404,
                Message = "This font type Id is not found"
            };
        var mapperTool = mapper.Map(dto, existTool);
        mapperTool.UpdatedAt = DateTime.UtcNow;
        this.unitOfWork.DesignToolRepository.Update(mapperTool);
        await this.unitOfWork.SaveAsync();

        var result = Including(mapperTool);

        return new Response<DesignToolResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = result
        };
    }

    public async Task<Response<DesignToolResultDto>> GetByIdAsync(long id)
    {
        var existTool = await this.unitOfWork.DesignToolRepository.SelectByIdAsync(id);
        if (existTool is null)
            return new Response<DesignToolResultDto>
            {
                StatusCode = 404,
                Message = "Not found",
                Data = null
            };

        var result = Including(existTool);

        return new Response<DesignToolResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = result
        };
    }

    public async Task<Response<bool>> DeleteAsync(long id)
    {
        var existTool = await this.unitOfWork.DesignToolRepository.SelectByIdAsync(id);
        if (existTool is null)
            return new Response<bool>
            {
                StatusCode = 404,
                Message = "Not found",
                Data = false
            };
        this.unitOfWork.DesignToolRepository.Delete(existTool);
        await this.unitOfWork.SaveAsync();
        return new Response<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };
    }

    public async Task<Response<IEnumerable<DesignToolResultDto>>> GetAllAsync()
    {
        var tools = this.unitOfWork.DesignToolRepository.SelectAll();
        List<DesignToolResultDto> result = new List<DesignToolResultDto>();
        foreach (var tool in tools)
        {
            result.Add(Including(tool));
        }
        return new Response<IEnumerable<DesignToolResultDto>>
        {
            StatusCode = 200,
            Message = "Success",
            Data = result
        };
    }

    private DesignToolResultDto Including(DesignTool mapperTool)
    {
        var existColor = this.unitOfWork.ColorRepository.SelectAll()
            .FirstOrDefault(c => c.Id.Equals(mapperTool.ColorId));
        var existFont = this.unitOfWork.FontTypeRepository.SelectAll()
            .FirstOrDefault(f => f.Id.Equals(mapperTool.FontTypeId));


        var color = mapper.Map<ColorResultDto>(existColor);
        var font = mapper.Map<FontTypeResultDto>(existFont);
        var result = mapper.Map<DesignToolResultDto>(mapperTool);

        result.ColorResultDto = color;
        result.FontTypeResultDto = font;
        return result;
    }
}