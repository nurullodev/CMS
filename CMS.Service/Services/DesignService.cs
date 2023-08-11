using AutoMapper;
using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.ICommons;
using CMS.Domain.Entities.Designs;
using CMS.Service.DTOs.Damens;
using CMS.Service.DTOs.DesignCategories;
using CMS.Service.DTOs.Designs;
using CMS.Service.Helpers;
using CMS.Service.Interfaces;
using CMS.Service.Mappers;

namespace CMS.Service.Services;

public class DesignService : IDesignService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    public DesignService()
    {
        unitOfWork = new UnitOfWork();
        mapper = new Mapper(new MapperConfiguration
            (cf => cf.AddProfile<MappingProfile>()));
    }

    public async Task<Response<DesignResultDto>> CreateAsync(DesignCreationDto dto)
    {
        var existDesign = await this.unitOfWork
            .DesignRepository.SelectByDamenIdAndNameAsync(dto.Name, dto.DamenId);
        if (existDesign is not null)
            return new Response<DesignResultDto>
            {
                StatusCode = 403,
                Message = "This page is alrady exist",
                Data = null
            };

        var damenId = await this.unitOfWork.DamenRepository.SelectByIdAsync(dto.DamenId);
        if (damenId is null)
            return new Response<DesignResultDto>
            {
                StatusCode = 404,
                Message = "This damen Id not found",
                Data = null
            };

        var categoryId = await this.unitOfWork
            .DesignCategoryRepository.SelectByIdAsync(dto.DesignCategoryId);
        if (categoryId is null)
            return new Response<DesignResultDto>
            {
                StatusCode = 404,
                Message = "This ctegory id is not found",
                Data = null
            };

        var mapperDesign = mapper.Map<Design>(dto);

        await this.unitOfWork.DesignRepository.AddAsync(mapperDesign);
        await this.unitOfWork.SaveAsync();

        var result = Including(mapperDesign);

        return new Response<DesignResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = result
        };
    }

    public async Task<Response<DesignResultDto>> UpdateAsync(DesignUpdateDto dto)
    {
        var existDesign = await this.unitOfWork.DesignRepository.SelectByIdAsync(dto.Id);
        if (existDesign is null)
            return new Response<DesignResultDto>
            {
                StatusCode = 404,
                Message = $"This Design Id {dto.Id} is not found",
                Data = null
            };

        var damenId = await this.unitOfWork.DamenRepository.SelectByIdAsync(dto.DamenId);
        if (damenId is null)
            return new Response<DesignResultDto>
            {
                StatusCode = 404,
                Message = "This damen Id not found",
                Data = null
            };

        var categoryId = await this.unitOfWork
            .DesignCategoryRepository.SelectByIdAsync(dto.DesignCategoryId);
        if (categoryId is null)
            return new Response<DesignResultDto>
            {
                StatusCode = 404,
                Message = "This ctegory id is not found",
                Data = null
            };

        var mapperDesign = mapper.Map(dto, existDesign);
        mapperDesign.UpdatedAt = DateTime.UtcNow;
        this.unitOfWork.DesignRepository.Update(mapperDesign);
        await this.unitOfWork.SaveAsync();

        var result = Including(mapperDesign);

        return new Response<DesignResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = result
        };
    }

    public async Task<Response<DesignResultDto>> GetByIdAsync(long id)
    {
        var existDesign = await this.unitOfWork.DesignRepository.SelectByIdAsync(id);
        if (existDesign is null)
            return new Response<DesignResultDto>
            {
                StatusCode = 404,
                Message = $"This Design Id {id} is not found",
                Data = null
            };

        var result = Including(existDesign);

        return new Response<DesignResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = result
        };
    }

    public async Task<Response<bool>> DeleteAsync(long id)
    {
        var existDesign = await this.unitOfWork.DesignRepository.SelectByIdAsync(id);
        if (existDesign is null)
            return new Response<bool>
            {
                StatusCode = 404,
                Message = $"This Design ID {id} is not found",
                Data = false
            };

        this.unitOfWork.DesignRepository.Delete(existDesign);
        await this.unitOfWork.SaveAsync();

        return new Response<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };
    }

    public async Task<Response<IEnumerable<DesignResultDto>>> GetAllAsync()
    {
        var designs = this.unitOfWork.DesignRepository.SelectAll();
        var designsResult = new List<DesignResultDto>();
        foreach (var design in designs)
            designsResult.Add(Including(design));
        return new Response<IEnumerable<DesignResultDto>>
        {
            StatusCode = 200,
            Message = "Success",
            Data = designsResult
        };
    }

    public async Task<Response<bool>> DeleteByCategoryIdAsync(long categoryId)
    {
        var designs = this.unitOfWork.DesignRepository.SelectAll()
            .Where(d => d.DesignCategoryId.Equals(categoryId));
        if (!designs.Any())
            return new Response<bool>
            {
                StatusCode = 404,
                Message = "Not found",
                Data = false
            };

        foreach (var design in designs)
        {
            this.unitOfWork.DesignRepository.Delete(design);
            await unitOfWork.SaveAsync();
        }
        return new Response<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };
    }

    private DesignResultDto Including(Design mapperDesign)
    {
        var existDamen = this.unitOfWork.DamenRepository.SelectAll()
            .FirstOrDefault(d => d.Id.Equals(mapperDesign.DamenId));

        var existCategory = this.unitOfWork.DesignCategoryRepository.SelectAll()
            .FirstOrDefault(c => c.Id.Equals(mapperDesign.DesignCategoryId));

        var damen = mapper.Map<DamenResultDto>(existDamen);
        var category = mapper.Map<DesignCategoryResultDto>(existCategory);
        var result = mapper.Map<DesignResultDto>(mapperDesign);

        result.DamenResultDto = damen;
        result.DesignCategoryResultDto = category;

        return result;
    }
}
