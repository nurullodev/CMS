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
using Microsoft.EntityFrameworkCore;

namespace CMS.Service.Services;

public class DesignToolService : IDesignToolService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    private readonly AppDbContext appDbContext;
    public DesignToolService()
    {
        unitOfWork = new UnitOfWork();
        appDbContext = new AppDbContext();
        mapper = new Mapper(new MapperConfiguration
            (cf => cf.AddProfile<MappingProfile>()));
    }

    public async Task<Response<DesignToolResultDto>> CreateAsync(DesignToolCreationDto dto)
    {
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
        var tool = appDbContext.DesignTools
                    .Include(c => c.Color)
                    .Include(f => f.FontType)
                    .FirstOrDefault(d => d.Id.Equals(mapperTool.Id));

        var color = mapper.Map<ColorResultDto>(tool.Color);
        var font = mapper.Map<FontTypeResultDto>(tool.FontType);
        var result = mapper.Map<DesignToolResultDto>(tool);

        result.ColorResultDto = color;
        result.FontTypeResultDto = font;
        return result;
    }
}