namespace Eleicoes.Domain.Entities
{
    public class Cargo
    {
        public Cargo(long id, string descricao, string uf, string estado)
        {
            Id = id;
            Descricao = descricao;
            UF = uf;
            Estado = estado;    
        }

        public long Id { get; private set; }
        public string Descricao { get; private set; }
        public string UF { get; private set; }
        public string Estado { get; private set; }
    }
}