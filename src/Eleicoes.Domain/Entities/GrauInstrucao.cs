namespace Eleicoes.Domain.Entities
{
    public class GrauInstrucao
    {
        public GrauInstrucao(long id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }

        public long Id { get; private set; }
        public string Descricao { get; private set; }
    }
}