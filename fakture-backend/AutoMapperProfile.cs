using AutoMapper;
using fakture_backend.Dtos;
using fakture_backend.Models;

namespace fakture_backend
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Facture, GetAllFactureDto>();
            CreateMap<AddFactureDto, Facture>();

        }
    }
}
