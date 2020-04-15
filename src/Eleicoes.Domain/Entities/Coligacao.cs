namespace Eleicoes.Domain.Entities
{
    public class Coligacao
    {
        public Coligacao(long id, string nome, string composicao)
        {
            Id = id;
            Nome = nome;
            Composicao = composicao;    
        }

        public long Id { get; private set; }
        public string Nome { get; private set; }
        public string Composicao { get; private set; }
    }
}