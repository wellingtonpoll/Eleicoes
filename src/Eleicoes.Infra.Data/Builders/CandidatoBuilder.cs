using System.Collections.Generic;
using Eleicoes.Domain.Entities;
using FizzWare.NBuilder;

namespace Eleicoes.Infra.Data.Builders
{
    public class CandidatoBuilder
    {
        public IEnumerable<Candidato> BuildList()
        {
            return Builder<Candidato>.CreateListOfSize(10).Build();
        }
    }
}