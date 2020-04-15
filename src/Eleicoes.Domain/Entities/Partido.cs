namespace Eleicoes.Domain.Entities
{
    public class Partido
    {
        public Partido(long numero, string sigla, string nome)
        {
            Numero = numero;
            Sigla = sigla;
            Nome = nome;    
        }

        public long Numero { get; private set; }
        public string Sigla { get; private set; }
        public string Nome { get; private set; }
    }
}