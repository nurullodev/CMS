using AutoMapper;
using CMS.Service.DTOs.Users;
using CMS.Service.DTOs.Colors;
using CMS.Service.DTOs.Damens;
using CMS.Service.DTOs.Designs;
using CMS.Domain.Entities.Users;
using CMS.Service.DTOs.FontSizes;
using CMS.Service.DTOs.TimeZones;
using CMS.Domain.Entities.Domains;
using CMS.Service.DTOs.UserGroups;
using CMS.Domain.Entities.Designs;
using CMS.Service.DTOs.DesignTools;
using CMS.Domain.Entities.TimeZones;
using CMS.Domain.Entities.DesignTools;
using CMS.Service.DTOs.DesignCategories;
using CMS.Domain.Entities.DesignCategories;

namespace CMS.Service.Mappers;

public class MappingProfile : Profile 
{
    public MappingProfile()
    {
        //User
        CreateMap<UserResultDto, User>().ReverseMap();
        CreateMap<UserUpdateDto, User>().ReverseMap();
        CreateMap<User, UserCreationDto>().ReverseMap();

        //userGroup 
        CreateMap<UserGroupResultDto, UserGroup>().ReverseMap();
        CreateMap<UserGroupUpdateDto, UserGroup>().ReverseMap();
        CreateMap<UserGroup, UserGroupCreationDto>().ReverseMap();
        
        //Damen
        CreateMap<DamenResultDto, Damen>().ReverseMap();
        CreateMap<DamenUpdateDto, Damen>().ReverseMap();    
        CreateMap<Damen, DamenCreationDto>().ReverseMap();

        //DesignCategory 
        CreateMap<DesignCategoryResultDto, DesignCategory>().ReverseMap();
        CreateMap<DesignCategoryUpdateDto, DesignCategory>().ReverseMap();  
        CreateMap<DesignCategory, DesignCategoryCreationDto>().ReverseMap();    

        //Design 
        CreateMap<DesignResultDto, Design>().ReverseMap();
        CreateMap<DesignUpdateDto, Design>().ReverseMap();
        CreateMap<Design, DesignCreationDto>().ReverseMap();

        //DesignTool
        CreateMap<DesignToolResultDto, DesignTool>().ReverseMap();
        CreateMap<DesignToolUpdateDto, DesignTool>().ReverseMap();  
        CreateMap<DesignCategory, DesignCategoryCreationDto>().ReverseMap();

        //Color
        CreateMap<ColorResultDto, Color>().ReverseMap();    
        CreateMap<ColorUpdateDto, Color>().ReverseMap();
        CreateMap<Color, ColorCreationDto>().ReverseMap();

        //TimeZon
        CreateMap<TimeZonResultDto, TimeZon>().ReverseMap();
        CreateMap<TimeZonUpdateDto, TimeZon>().ReverseMap();
        CreateMap<TimeZon, TimeZonCreationDto>().ReverseMap();

        //FontSize 
        CreateMap<FontSizeResultDto, FontSize>().ReverseMap();  
        CreateMap<FontSizeUpdateDto, FontSize>().ReverseMap();
        CreateMap<FontSize, FontSizeCreationDto>().ReverseMap();
    }
}
