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

    public Task<Response<bool>> DeleteAsync(long id)
    {
        throw new NotImplementedException();
    }

    public Task<Response<IEnumerable<ColorResultDto>>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Response<ColorResultDto>> UpdateAsync(ColorUpdateDto dto)
    {
        throw new NotImplementedException();
    }
}
