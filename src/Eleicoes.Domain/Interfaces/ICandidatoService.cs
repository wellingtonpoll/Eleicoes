using System.Linq;
using Eleicoes.Domain.Entities;

namespace Eleicoes.Domain.Interfaces
{
    public interface ICandidatoService
    {
        IQueryable<Candidato> Lista(string anoEleicao);
    }
}