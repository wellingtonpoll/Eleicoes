namespace Eleicoes.Domain.Entities
{
    public class SituacaoCandidatura
    {
        public SituacaoCandidatura(long id, string descricao, string detalhe)
        {
            Id = id;
            Descricao = descricao;
            Detalhe = detalhe;    
        }

        public long Id { get; private set; }
        public string Descricao { get; private set; }
        public string Detalhe { get; private set; }
    }
}