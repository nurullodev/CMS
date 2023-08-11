using AutoMapper;
using CMS.Data.Commons;
using CMS.Data.ICommons;
using CMS.Service.Mappers;
using CMS.Service.Helpers;
using CMS.Service.Interfaces;
using CMS.Service.DTOs.DesignCategories;
using CMS.Domain.Entities.DesignCategories;

namespace CMS.Service.Services;

public class DesignCategoryService : IDesignCategoryService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    public DesignCategoryService()
    {
        unitOfWork = new UnitOfWork();
        mapper = new Mapper(new MapperConfiguration
            (cf => cf.AddProfile<MappingProfile>()));
    }

    public async Task<Response<DesignCategoryResultDto>> CreateAsync(DesignCategoryCreationDto dto)
    {
        var existDesignCategory = await this.unitOfWork.DesignCategoryRepository.SelectByNameAsync(dto.Name);
        if (existDesignCategory is not null)
            return new Response<DesignCategoryResultDto>
            {
                StatusCode = 403,
                Message = "This DesignCategory is already exist",
                Data = null
            };

        var mapperDesignCategory = mapper.Map<DesignCategory>(dto);
        await this.unitOfWork.DesignCategoryRepository.AddAsync(mapperDesignCategory);
        await this.unitOfWork.SaveAsync();

        return new Response<DesignCategoryResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<DesignCategoryResultDto>(mapperDesignCategory)
        };
    }

    public async Task<Response<DesignCategoryResultDto>> UpdateAsync(DesignCategoryUpdateDto dto)
    {
        var existDesignCategory = await this.unitOfWork.DesignCategoryRepository.SelectByIdAsync(dto.Id);
        if (existDesignCategory is null)
            return new Response<DesignCategoryResultDto>
            {
                StatusCode = 404,
                Message = $"This DesignCategory Id {dto.Id} is not found",
                Data = null
            };

        var mapperDesignCategory = mapper.Map(dto, existDesignCategory);
        mapperDesignCategory.UpdatedAt = DateTime.UtcNow;
        this.unitOfWork.DesignCategoryRepository.Update(mapperDesignCategory);
        await this.unitOfWork.SaveAsync();

        return new Response<DesignCategoryResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<DesignCategoryResultDto>(mapperDesignCategory)
        };
    }

    public async Task<Response<DesignCategoryResultDto>> GetByIdAsync(long id)
    {
        var existDesignCategory = await this.unitOfWork.DesignCategoryRepository.SelectByIdAsync(id);
        if (existDesignCategory is null)
            return new Response<DesignCategoryResultDto>
            {
                StatusCode = 404,
                Message = $"This DesignCategory Id {id} is not found",
                Data = null
            };

        return new Response<DesignCategoryResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<DesignCategoryResultDto>(existDesignCategory)
        };
    }

    public async Task<Response<bool>> DeleteAsync(long id)
    {
        var existDesignCategory = await this.unitOfWork.DesignCategoryRepository.SelectByIdAsync(id);
        if (existDesignCategory is null)
            return new Response<bool>
            {
                StatusCode = 404,
                Message = $"This DesignCategory ID {id} is not found",
                Data = false
            };

        this.unitOfWork.DesignCategoryRepository.Delete(existDesignCategory);
        await this.unitOfWork.SaveAsync();

        return new Response<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };
    }

    public async Task<Response<IEnumerable<DesignCategoryResultDto>>> GetAllAsync()
    {
        var designCategorys = this.unitOfWork.DesignCategoryRepository.SelectAll();
        var mapperDesignCategorys = mapper.Map<IEnumerable<DesignCategoryResultDto>>(designCategorys);
        return new Response<IEnumerable<DesignCategoryResultDto>>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapperDesignCategorys
        };
    }
}
