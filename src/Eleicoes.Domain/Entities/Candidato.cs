using System;

namespace Eleicoes.Domain.Entities
{
    public class Candidato
    {
        public long Id { get; private set; }
        public long NumeroCandidato { get; private set; }
        public string AnoEleicao { get; private set; }
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string CPF { get; private set; }
        public string Email { get; private set; }
        public string Agremiacao { get; private set; }
        public string UFNascimento { get; private set; }
        public string MunicipioNascimento { get; private set; }
        public string TituloEleitor { get; private set; }
        public Genero Genero { get; private set; }
        public GrauInstrucao GrauInstrucao { get; private set; }
        public EstadoCivil EstadoCivil { get; private set; }
        public Ocupacao Ocupacao { get; private set; }
        public Cargo Cargo { get; private set; }
        public Coligacao Coligacao { get; private set; }
        public Partido Partido { get; private set; }
        public SituacaoCandidatura SituacaoCandidatura { get; private set; }

        public Candidato(
            long id,
            long numeroCandidato,
            string anoeleicao,
            string nome,
            DateTime nascimento,
            string cpf,
            string email,
            string agremiacao,
            string ufNascimento,
            string municipioNascimento,
            string tituloEleitor,
            Genero genero,
            GrauInstrucao grauInstrucao,
            EstadoCivil estadoCivil,
            Ocupacao ocupacao,
            Cargo cargo,
            Coligacao coligacao,
            Partido partido,
            SituacaoCandidatura situacaoCandidatura)
        {
            Id = id;
            NumeroCandidato = numeroCandidato;
            AnoEleicao = anoeleicao;
            Nome = nome;
            Nascimento = nascimento;
            CPF = cpf;
            Email = email;
            Agremiacao = agremiacao;
            UFNascimento = ufNascimento;
            MunicipioNascimento = municipioNascimento;
            TituloEleitor = tituloEleitor;
            Genero = genero;
            GrauInstrucao = grauInstrucao;
            EstadoCivil = estadoCivil;
            Ocupacao = ocupacao;
            Cargo = cargo;
            Coligacao = coligacao;
            Partido = partido;
            SituacaoCandidatura = situacaoCandidatura;
        }
    }
}