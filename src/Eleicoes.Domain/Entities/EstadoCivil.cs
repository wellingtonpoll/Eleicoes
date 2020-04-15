namespace Eleicoes.Domain.Entities
{
    public class EstadoCivil
    {
        public EstadoCivil(long id, string descricao)
        {
            Id = id;
            Descricao = descricao;    
        }

        public long Id { get; private set; }
        public string Descricao { get; private set; }
    }
}