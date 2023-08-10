using AutoMapper;
using CMS.Data.Commons;
using CMS.Data.ICommons;
using CMS.Service.Mappers;
using CMS.Service.Helpers;
using CMS.Service.Interfaces;
using CMS.Service.DTOs.Colors;
using CMS.Domain.Entities.DesignTools;

namespace CMS.Service.Services;

public class ColorService : IColorService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    public ColorService()
    {
        unitOfWork = new UnitOfWork();
        mapper = new Mapper(new MapperConfiguration
            (cf => cf.AddProfile<MappingProfile>()));
    }

    public async Task<Response<ColorResultDto>> CreateAsync(ColorCreationDto dto)
    {
        var existColor = await this.unitOfWork.ColorRepository.SelectByNameAsync(dto.Name);
        if (existColor is not null)
            return new Response<ColorResultDto>
            {
                StatusCode = 403,
                Message = "This color is already exist",
                Data = null
            };

        var mapperColor = mapper.Map<Color>(dto);
        await this.unitOfWork.ColorRepository.AddAsync(mapperColor);
        await this.unitOfWork.SaveAsync();

        return new Response<ColorResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<ColorResultDto>(mapperColor)
        };
    }

    public async Task<Response<ColorResultDto>> UpdateAsync(ColorUpdateDto dto)
    {
        var existColor = await this.unitOfWork.ColorRepository.SelectByIdAsync(dto.Id);
        if (existColor is null)
            return new Response<ColorResultDto>
            {
                StatusCode = 404,
                Message = $"This color {dto.Id} is not found",
                Data = null
            };

        var mapperColor = mapper.Map(dto,existColor);
        mapperColor.UpdatedAt = DateTime.UtcNow;
        this.unitOfWork.ColorRepository.Update(mapperColor);
        await this.unitOfWork.SaveAsync();

        return new Response<ColorResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<ColorResultDto>(mapperColor)
        };
    }

    public async Task<Response<ColorResultDto>> GetByIdAsync(long id)
    {
        var existColor = await this.unitOfWork.ColorRepository.SelectByIdAsync(id);
        if (existColor is null)
            return new Response<ColorResultDto>
            {
                StatusCode = 404,
                Message = $"This color {id} is not found",
                Data = null
            };

        return new Response<ColorResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<ColorResultDto>(existColor)
        };
    }

    public async Task<Response<bool>> DeleteAsync(long id)
    {
        var existColor = await this.unitOfWork.ColorRepository.SelectByIdAsync(id);
        if (existColor is null)
            return new Response<bool>
            {
                StatusCode = 404,
                Message = $"This color {id} is not found",
                Data = false
            };

        this.unitOfWork.ColorRepository.Delete(existColor);
        await this.unitOfWork.SaveAsync();
        
        return new Response<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };
    }

    public async Task<Response<IEnumerable<ColorResultDto>>> GetAllAsync()
    {
        var colors = this.unitOfWork.ColorRepository.SelectAll();
        var mapperColors =mapper.Map<IEnumerable<ColorResultDto>>(colors);
        return new Response<IEnumerable<ColorResultDto>>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapperColors
        };
    }
}
