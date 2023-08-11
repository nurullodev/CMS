using AutoMapper;
using CMS.Data.Commons;
using CMS.Data.ICommons;
using CMS.Domain.Entities.Users;
using CMS.Service.DTOs.UserGroups;
using CMS.Service.Helpers;
using CMS.Service.Interfaces;
using CMS.Service.Mappers;

namespace CMS.Service.Services;

public class UserGroupService : IUserGroupService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    public UserGroupService()
    {
        unitOfWork = new UnitOfWork();
        mapper = new Mapper(new MapperConfiguration
            (cf => cf.AddProfile<MappingProfile>()));
    }

    public async Task<Response<UserGroupResultDto>> CreateAsync(UserGroupCreationDto dto)
    {
        var existUserGroup = await this.unitOfWork.UserGroupRepository.SelectByUserIdAndEmailAsync(dto.UserId, dto.Email);
        if (existUserGroup is not null)
            return new Response<UserGroupResultDto>
            {
                StatusCode = 403,
                Message = "This user email is already exist in this group",
                Data = null
            };

        var isValidUserId = await this.unitOfWork.UserRepository.SelectByIdAsync(dto.UserId);
        if (isValidUserId is null)
            return new Response<UserGroupResultDto>
            {
                StatusCode = 404,
                Message = "This user Id is not found",
                Data = null
            };
        var isVaidDamenId = await this.unitOfWork.DamenRepository.SelectByIdAsync(dto.DamenId);
        if (isVaidDamenId is null)
            return new Response<UserGroupResultDto>
            {
                StatusCode = 404,
                Message = "This damen Id is not found",
                Data = null
            };
        if (isVaidDamenId.Id != isValidUserId.DamenId)
            return new Response<UserGroupResultDto>
            {
                StatusCode = 404,
                Message = $"This domain belongs to another user / Damen Id {dto.DamenId}!={isValidUserId.DamenId}",
                Data = null
            };

        var mapperUserGroup = mapper.Map<UserGroup>(dto);
        await this.unitOfWork.UserGroupRepository.AddAsync(mapperUserGroup);
        await this.unitOfWork.SaveAsync();

        return new Response<UserGroupResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<UserGroupResultDto>(mapperUserGroup)
        };
    }

    public async Task<Response<UserGroupResultDto>> UpdateAsync(UserGroupUpdateDto dto)
    {
        var existUserGroup = await this.unitOfWork.UserGroupRepository.SelectByIdAsync(dto.Id);
        if (existUserGroup is null)
            return new Response<UserGroupResultDto>
            {
                StatusCode = 404,
                Message = $"This UserGroup Id {dto.Id} is not found",
                Data = null
            };
        var isValidUserId = await this.unitOfWork.UserRepository.SelectByIdAsync(dto.UserId);
        if (isValidUserId is null)
            return new Response<UserGroupResultDto>
            {
                StatusCode = 404,
                Message = "This user Id is not found",
                Data = null
            };

        var isVaidDamenId = await this.unitOfWork.DamenRepository.SelectByIdAsync(dto.DamenId);
        if (isVaidDamenId is null)
            return new Response<UserGroupResultDto>
            {
                StatusCode = 404,
                Message = "This damen Id is not found",
                Data = null
            };

        if (isVaidDamenId.Id != isValidUserId.DamenId)
            return new Response<UserGroupResultDto>
            {
                StatusCode = 404,
                Message = $"This domain belongs to another user / Damen Id {dto.DamenId}!={isValidUserId.DamenId}",
                Data = null
            };

        var mapperUserGroup = mapper.Map(dto, existUserGroup);
        mapperUserGroup.UpdatedAt = DateTime.UtcNow;
        this.unitOfWork.UserGroupRepository.Update(mapperUserGroup);
        await this.unitOfWork.SaveAsync();

        return new Response<UserGroupResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<UserGroupResultDto>(mapperUserGroup)
        };
    }

    public async Task<Response<UserGroupResultDto>> GetByIdAsync(long id)
    {
        var existUserGroup = await this.unitOfWork.UserGroupRepository.SelectByIdAsync(id);
        if (existUserGroup is null)
            return new Response<UserGroupResultDto>
            {
                StatusCode = 404,
                Message = $"This UserGroup Id {id} is not found",
                Data = null
            };

        return new Response<UserGroupResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<UserGroupResultDto>(existUserGroup)
        };
    }

    public async Task<Response<bool>> DeleteAsync(long id)
    {
        var existUserGroup = await this.unitOfWork.UserGroupRepository.SelectByIdAsync(id);
        if (existUserGroup is null)
            return new Response<bool>
            {
                StatusCode = 404,
                Message = $"This UserGroup ID {id} is not found",
                Data = false
            };

        this.unitOfWork.UserGroupRepository.Delete(existUserGroup);
        await this.unitOfWork.SaveAsync();

        return new Response<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };
    }

    public async Task<Response<IEnumerable<UserGroupResultDto>>> GetAllAsync()
    {
        var UserGroups = this.unitOfWork.UserGroupRepository.SelectAll();
        var mapperUserGroups = mapper.Map<IEnumerable<UserGroupResultDto>>(UserGroups);
        return new Response<IEnumerable<UserGroupResultDto>>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapperUserGroups
        };
    }
}