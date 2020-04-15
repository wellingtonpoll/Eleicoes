using AutoMapper;
using Eleicoes.Application.Models;
using Eleicoes.Domain.Entities;

namespace Eleicao.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Candidato, CandidatoViewModel>();
        }
    }
}