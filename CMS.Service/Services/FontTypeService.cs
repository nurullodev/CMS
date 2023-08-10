using AutoMapper;
using CMS.Data.Commons;
using CMS.Data.ICommons;
using CMS.Domain.Entities.DesignTools;
using CMS.Service.DTOs.FontTypes;
using CMS.Service.DTOs.FontTypes;
using CMS.Service.DTOs.FontTypes;
using CMS.Service.DTOs.FontTypes;
using CMS.Service.DTOs.FontTypes;
using CMS.Service.Helpers;
using CMS.Service.Interfaces;
using CMS.Service.Mappers;

namespace CMS.Service.Services;

public class FontTypeService : IFontTypeService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    public FontTypeService()
    {
        unitOfWork = new UnitOfWork();
        mapper = new Mapper(new MapperConfiguration
            (cf => cf.AddProfile<MappingProfile>()));
    }

    public async Task<Response<FontTypeResultDto>> CreateAsync(FontTypeCreationDto dto)
    {
        var existFontType = await this.unitOfWork.FontTypeRepository
            .SelectByTypeAsync(dto.Type);

        if (existFontType is not null)
            return new Response<FontTypeResultDto>
            {
                StatusCode = 403,
                Message = "This FontType is already exist",
                Data = null
            };

        var mapperFontType = mapper.Map<FontType>(dto);
        await this.unitOfWork.FontTypeRepository.AddAsync(mapperFontType);
        await this.unitOfWork.SaveAsync();

        return new Response<FontTypeResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<FontTypeResultDto>(mapperFontType)
        };
    }

    public async Task<Response<FontTypeResultDto>> UpdateAsync(FontTypeUpdateDto dto)
    {
        var existFontType = await this.unitOfWork.FontTypeRepository.SelectByIdAsync(dto.Id);
        if (existFontType is null)
            return new Response<FontTypeResultDto>
            {
                StatusCode = 404,
                Message = $"This FontType Id {dto.Id} is not found",
                Data = null
            };

        var mapperFontType = mapper.Map(dto, existFontType);
        mapperFontType.UpdatedAt = DateTime.UtcNow;
        this.unitOfWork.FontTypeRepository.Update(mapperFontType);
        await this.unitOfWork.SaveAsync();

        return new Response<FontTypeResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<FontTypeResultDto>(mapperFontType)
        };
    }

    public async Task<Response<FontTypeResultDto>> GetByIdAsync(long id)
    {
        var existFontType = await this.unitOfWork.FontTypeRepository.SelectByIdAsync(id);
        if (existFontType is null)
            return new Response<FontTypeResultDto>
            {
                StatusCode = 404,
                Message = $"This FontType Id {id} is not found",
                Data = null
            };

        return new Response<FontTypeResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<FontTypeResultDto>(existFontType)
        };
    }

    public async Task<Response<bool>> DeleteAsync(long id)
    {
        var existFontType = await this.unitOfWork.FontTypeRepository.SelectByIdAsync(id);
        if (existFontType is null)
            return new Response<bool>
            {
                StatusCode = 404,
                Message = $"This FontType ID {id} is not found",
                Data = false
            };

        this.unitOfWork.FontTypeRepository.Delete(existFontType);
        await this.unitOfWork.SaveAsync();

        return new Response<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };
    }

    public async Task<Response<IEnumerable<FontTypeResultDto>>> GetAllAsync()
    {
        var fontTypes = this.unitOfWork.FontTypeRepository.SelectAll();
        var mapperFontTypes = mapper.Map<IEnumerable<FontTypeResultDto>>(fontTypes);
        return new Response<IEnumerable<FontTypeResultDto>>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapperFontTypes
        };
    }
}
