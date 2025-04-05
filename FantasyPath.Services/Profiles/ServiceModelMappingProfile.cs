using AutoMapper;
using FantasyPath.Infrastructure.Models;
using FantasyPath.Services.Models;

namespace FantasyPath.Services.Profiles;

public class ServiceModelMappingProfile : Profile
{
    public ServiceModelMappingProfile()
    {
        this.CreateMap<Book, BookServiceModel>();
        this.CreateMap<Save, SaveServiceModel>();
    }    
}
