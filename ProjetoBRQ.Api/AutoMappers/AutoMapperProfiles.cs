using AutoMapper;
using ProjetoBRQ.Domain.Entities;

namespace ProjetoBRQ.Api.AutoMappers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Pessoa, PessoaDto>();
        }
    }
}