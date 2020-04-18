using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eleicoes.Domain.Entities;
using Eleicoes.Domain.Interfaces;
using Eleicoes.Infra.Data.Builders;

namespace Eleicoes.Infra.Data.Repositories
{
    public class CandidatoRepository : ICandidatoRepository
    {
        public void Adiciona(Candidato candidato)
        {
            throw new System.NotImplementedException();
        }

        public async Task AdicionaAsync(IEnumerable<Candidato> candidatos)
        {
            await Task.CompletedTask;
        }

        public IQueryable<Candidato> Lista(string anoEleicao)
        {
            var candidatoBuilder = new CandidatoBuilder();
            var candidatos = candidatoBuilder.BuildList(anoEleicao).AsQueryable();
            return candidatos;
        }
    }
}