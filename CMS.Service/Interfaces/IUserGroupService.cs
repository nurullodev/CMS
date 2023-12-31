﻿using CMS.Service.DTOs.Damens;
using CMS.Service.DTOs.UserGroups;
using CMS.Service.Helpers;

namespace CMS.Service.Interfaces;

public interface IUserGroupService
{
    Task<Response<UserGroupResultDto>> CreateAsync(UserGroupCreationDto dto);
    Task<Response<UserGroupResultDto>> UpdateAsync(UserGroupUpdateDto dto);
    Task<Response<UserGroupResultDto>> GetByIdAsync(long id);
    Task<Response<bool>> DeleteAsync(long id);
    Task<Response<IEnumerable<UserGroupResultDto>>> GetAllAsync();
}