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
            CreateMap<Cargo, CargoViewModel>();
            CreateMap<Coligacao, ColigacaoViewModel>();
            CreateMap<EstadoCivil, EstadoCivilViewModel>();
            CreateMap<Genero, GeneroViewModel>();
            CreateMap<GrauInstrucao, GrauInstrucaoViewModel>();
            CreateMap<Ocupacao, OcupacaoViewModel>();
            CreateMap<Partido, PartidoViewModel>();
            CreateMap<SituacaoCandidatura, SituacaoCandidaturaViewModel>();
        }
    }
}