﻿using CMS.Service.DTOs.Damens;
using CMS.Service.DTOs.FontSizes;
using CMS.Service.Helpers;

namespace CMS.Service.Interfaces;

public interface IFontSizeService
{
    Task<Response<FontSizeResultDto>> CreateAsync(FontSizeCreationDto dto);
    Task<Response<FontSizeResultDto>> UpdateAsync(FontSizeUpdateDto dto);
    Task<Response<FontSizeResultDto>> GetByIdAsync(long id);
    Task<Response<bool>> DeleteAsync(long id);
    Task<Response<IEnumerable<FontSizeResultDto>>> GetAllAsync();
}