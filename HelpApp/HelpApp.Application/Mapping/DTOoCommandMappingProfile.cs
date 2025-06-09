using AutoMapper;
using HelpApp.Application.DTOs;
using HelpApp.Application.Products.Commands;

namespace HelpApp.Application.Mapping
{
    public class DTOoCommandMappingProfile : Profile
    {
        public DTOoCommandMappingProfile()
        {
            CreateMap<ProductDTO, ProductCreateCommand>();
            CreateMap<ProductDTO, ProductCreateCommand>();

        }
    }
}
