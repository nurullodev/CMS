using AutoMapper;
using CMS.Data.Commons;
using CMS.Data.ICommons;
using CMS.Domain.Entities.DesignTools;
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

    public Task<Response<FontSizeResultDto>> UpdateAsync(FontSizeUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<Response<FontSizeResultDto>> GetByIdAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Response<bool>> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Response<IEnumerable<FontSizeResultDto>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }
}
