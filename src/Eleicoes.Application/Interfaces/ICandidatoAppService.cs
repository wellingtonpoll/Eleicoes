using System.Collections.Generic;
using Eleicoes.Application.Models;

namespace Eleicoes.Application.Interfaces
{
    public interface ICandidatoAppService
    {
        IEnumerable<CandidatoViewModel> Lista(string anoEleicao);
    }
}