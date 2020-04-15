using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eleicoes.Domain.Entities;
using Eleicoes.Domain.Interfaces;

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

        public IQueryable<Candidato> Lista(string ano)
        {
            throw new System.NotImplementedException();
        }
    }
}