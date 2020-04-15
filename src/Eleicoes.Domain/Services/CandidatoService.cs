using System.Linq;
using Eleicoes.Domain.Entities;
using Eleicoes.Domain.Interfaces;

namespace Eleicoes.Domain.Services
{
    public class CandidatoService : ICandidatoService
    {
        private readonly ICandidatoRepository _candidatoRepository;
        public CandidatoService(ICandidatoRepository candidatoRepository)
        {
            _candidatoRepository = candidatoRepository;
        }

        public IQueryable<Candidato> Lista(string anoEleicao)
        {
            return _candidatoRepository.Lista(anoEleicao);
        }
    }
}