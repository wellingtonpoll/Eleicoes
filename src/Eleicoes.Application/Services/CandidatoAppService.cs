using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Eleicoes.Application.Interfaces;
using Eleicoes.Application.Models;
using Eleicoes.Domain.Interfaces;

namespace Eleicoes.Application.Services
{
    public class CandidatoAppService : ICandidatoAppService
    {
        private readonly ICandidatoService _candidatoService;
        private readonly IMapper _mapper;
        public CandidatoAppService(
            ICandidatoService candidatoService,
            IMapper mapper)
        {
            _candidatoService = candidatoService;
            _mapper = mapper;
        }

        public IEnumerable<CandidatoViewModel> Lista(string anoEleicao)
        {
            return _candidatoService.Lista(anoEleicao)
                .ProjectTo<CandidatoViewModel>(_mapper.ConfigurationProvider);
        }
    }
}