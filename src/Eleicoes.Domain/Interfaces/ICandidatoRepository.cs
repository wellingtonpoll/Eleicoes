using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eleicoes.Domain.Entities;

namespace Eleicoes.Domain.Interfaces
{
    public interface ICandidatoRepository
    {
        IQueryable<Candidato> Lista(string ano);
        void Adiciona(Candidato candidato);
        Task AdicionaAsync(IEnumerable<Candidato> candidatos);
    }
}