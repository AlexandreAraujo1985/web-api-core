using AutoMapper;
using WebMotors.API.Model;
using WebMotors.Data.Entity;

namespace WebMotors.API.Helper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Anuncio, AnuncioEntity>();
        }
    }
}
