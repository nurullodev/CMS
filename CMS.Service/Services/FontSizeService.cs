using AutoMapper;
using CMS.Data.Commons;
using CMS.Data.ICommons;
using CMS.Domain.Entities.DesignTools;
using CMS.Service.DTOs.FontSizes;
using CMS.Service.DTOs.FontSizes;
using CMS.Service.DTOs.FontSizes;
using CMS.Service.DTOs.FontSizes;
using CMS.Service.DTOs.FontSizes;
using CMS.Service.Helpers;
using CMS.Service.Interfaces;
using CMS.Service.Mappers;

namespace CMS.Service.Services;

public class FontSizeService : IFontSizeService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    public FontSizeService()
    {
        unitOfWork = new UnitOfWork();
        mapper = new Mapper(new MapperConfiguration
            (cf => cf.AddProfile<MappingProfile>()));
    }

    public async Task<Response<FontSizeResultDto>> CreateAsync(FontSizeCreationDto dto)
    {
        var existFontSize = await this.unitOfWork.FontSizeRepository
            .SelectBySizeAsync(dto.Size);

        if (existFontSize is not null)
            return new Response<FontSizeResultDto>
            {
                StatusCode = 403,
                Message = "This FontSize is already exist",
                Data = null
            };

        var mapperFontSize = mapper.Map<FontSize>(dto);
        await this.unitOfWork.FontSizeRepository.AddAsync(mapperFontSize);
        await this.unitOfWork.SaveAsync();

        return new Response<FontSizeResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<FontSizeResultDto>(mapperFontSize)
        };
    }

    public async Task<Response<FontSizeResultDto>> UpdateAsync(FontSizeUpdateDto dto)
    {
        var existFontSize = await this.unitOfWork.FontSizeRepository.SelectByIdAsync(dto.Id);
        if (existFontSize is null)
            return new Response<FontSizeResultDto>
            {
                StatusCode = 404,
                Message = $"This FontSize Id {dto.Id} is not found",
                Data = null
            };

        var mapperFontSize = mapper.Map(dto, existFontSize);
        mapperFontSize.UpdatedAt = DateTime.UtcNow;
        this.unitOfWork.FontSizeRepository.Update(mapperFontSize);
        await this.unitOfWork.SaveAsync();

        return new Response<FontSizeResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<FontSizeResultDto>(mapperFontSize)
        };
    }

    public async Task<Response<FontSizeResultDto>> GetByIdAsync(long id)
    {
        var existFontSize = await this.unitOfWork.FontSizeRepository.SelectByIdAsync(id);
        if (existFontSize is null)
            return new Response<FontSizeResultDto>
            {
                StatusCode = 404,
                Message = $"This FontSize Id {id} is not found",
                Data = null
            };

        return new Response<FontSizeResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<FontSizeResultDto>(existFontSize)
        };
    }

    public async Task<Response<bool>> DeleteAsync(long id)
    {
        var existFontSize = await this.unitOfWork.FontSizeRepository.SelectByIdAsync(id);
        if (existFontSize is null)
            return new Response<bool>
            {
                StatusCode = 404,
                Message = $"This FontSize ID {id} is not found",
                Data = false
            };

        this.unitOfWork.FontSizeRepository.Delete(existFontSize);
        await this.unitOfWork.SaveAsync();

        return new Response<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };
    }

    public async Task<Response<IEnumerable<FontSizeResultDto>>> GetAllAsync()
    {
        var fontSizes = this.unitOfWork.FontSizeRepository.SelectAll();
        var mapperFontSizes = mapper.Map<IEnumerable<FontSizeResultDto>>(fontSizes);
        return new Response<IEnumerable<FontSizeResultDto>>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapperFontSizes
        };
    }
}
