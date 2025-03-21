using AutoMapper;
using FantasyPath.Services.Models;
using FantasyPath.Web.Models;

namespace FantasyPath.Web.Profiles;

public class ViewModelMappingProfile : Profile
{
    public ViewModelMappingProfile()
    {
        this.CreateMap<BookServiceModel, BookViewModel>();
    }
}
