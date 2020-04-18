using System;

namespace Eleicoes.Application.Models
{
    public class CandidatoViewModel
    {
        public long Id { get; set; }
        public long NumeroCandidato { get; set; }
        public string AnoEleicao { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Agremiacao { get; set; }
        public string UFNascimento { get; set; }
        public string MunicipioNascimento { get; set; }
        public string TituloEleitor { get; set; }
        public GeneroViewModel Genero { get; set; }
        public GrauInstrucaoViewModel GrauInstrucao { get; set; }
        public EstadoCivilViewModel EstadoCivil { get; set; }
        public OcupacaoViewModel Ocupacao { get; set; }
        public CargoViewModel Cargo { get; set; }
        public ColigacaoViewModel Coligacao { get; set; }
        public PartidoViewModel Partido { get; set; }
        public SituacaoCandidaturaViewModel SituacaoCandidatura { get; set; }
    }
}