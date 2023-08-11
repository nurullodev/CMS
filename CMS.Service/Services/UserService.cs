using AutoMapper;
using CMS.Data.Commons;
using CMS.Data.DbContexts;
using CMS.Data.ICommons;
using CMS.Domain.Entities.Users;
using CMS.Service.DTOs.Damens;
using CMS.Service.DTOs.Designs;
using CMS.Service.DTOs.Users;
using CMS.Service.Helpers;
using CMS.Service.Interfaces;
using CMS.Service.Mappers;
using Microsoft.EntityFrameworkCore;

namespace CMS.Service.Services;

public class UserService : IUserService
{
    private readonly IMapper mapper;
    private readonly IUnitOfWork unitOfWork;
    private readonly AppDbContext appDbContext;
    public UserService()
    {
        appDbContext = new AppDbContext();
        unitOfWork = new UnitOfWork();
        mapper = new Mapper(new MapperConfiguration
            (cf => cf.AddProfile<MappingProfile>()));
    }

    public async Task<Response<UserResultDto>> CreateAsync(UserCreationDto dto)
    {
        var existUser = await this.unitOfWork.UserRepository.SelectByEmailAsync(dto.Email);
        if (existUser is not null)
            return new Response<UserResultDto>
            {
                StatusCode = 403,
                Message = "This User is already exist",
                Data = null
            };

        var mapperUser = mapper.Map<User>(dto);
        await this.unitOfWork.UserRepository.AddAsync(mapperUser);
        await this.unitOfWork.SaveAsync();

        return new Response<UserResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<UserResultDto>(mapperUser)
        };
    }

    public async Task<Response<UserResultDto>> UpdateAsync(UserUpdateDto dto)
    {
        var existUser = await this.unitOfWork.UserRepository.SelectByIdAsync(dto.Id);
        if (existUser is null)
            return new Response<UserResultDto>
            {
                StatusCode = 404,
                Message = $"This User Id {dto.Id} is not found",
                Data = null
            };

        var mapperUser = mapper.Map(dto, existUser);
        mapperUser.UpdatedAt = DateTime.UtcNow;
        this.unitOfWork.UserRepository.Update(mapperUser);
        await this.unitOfWork.SaveAsync();

        var result = Including(mapperUser);

        return new Response<UserResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = result
        };
    }

    public async Task<Response<UserResultDto>> GetByIdAsync(long id)
    {
        var existUser = await this.unitOfWork.UserRepository.SelectByIdAsync(id);
        if (existUser is null)
            return new Response<UserResultDto>
            {
                StatusCode = 404,
                Message = $"This User Id {id} is not found",
                Data = null
            };

        var result = Including(existUser);

        return new Response<UserResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = result
        };
    }

    public async Task<Response<bool>> DeleteAsync(long id)
    {
        var existUser = await this.unitOfWork.UserRepository.SelectByIdAsync(id);
        if (existUser is null)
            return new Response<bool>
            {
                StatusCode = 404,
                Message = $"This User ID {id} is not found",
                Data = false
            };

        this.unitOfWork.UserRepository.Delete(existUser);
        await this.unitOfWork.SaveAsync();

        return new Response<bool>
        {
            StatusCode = 200,
            Message = "Success",
            Data = true
        };
    }

    public async Task<Response<IEnumerable<UserResultDto>>> GetAllAsync()
    {
        var users = this.unitOfWork.UserRepository.SelectAll();
        var usersResult = new List<UserResultDto>();
        foreach (var user in users)
            usersResult.Add(Including(user));
        return new Response<IEnumerable<UserResultDto>>
        {
            StatusCode = 200,
            Message = "Success",
            Data = usersResult
        };
    }
    public async Task<Response<UserResultDto>> CheckEmailAndPasswordAsync(string email, string password)
    {
        var result = await this.unitOfWork.UserRepository.SelectByEmailAndPasswordAsync(email, password);
        if (result is null)
            return new Response<UserResultDto>
            {
                StatusCode = 404,
                Message = "This user is not found",
                Data = null
            };
        return new Response<UserResultDto>
        {
            StatusCode = 200,
            Message = "Success",
            Data = mapper.Map<UserResultDto>(result)
        };
    }

    private UserResultDto Including(User mapperUser)
    {
        var user1 = appDbContext.Users
            .Include(d => d.Damen)
            .FirstOrDefault(u => u.Id.Equals(mapperUser.Id));
        var user2 = appDbContext.Users
            .Include(d =>d.Design)
            .FirstOrDefault(u => u.Id.Equals(mapperUser.Id));
        var damen = mapper.Map<DamenResultDto>(user1.Damen);
        var design = mapper.Map<DesignResultDto>(user2.Design);
        var result = mapper.Map<UserResultDto>(mapperUser);

        result.DamenResultDto = damen;
        result.DesignResultDto = design;

        return result;
    }

}