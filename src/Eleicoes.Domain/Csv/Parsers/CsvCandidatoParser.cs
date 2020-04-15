using System;
using System.Globalization;
using Eleicao.IO.Domain.CsvMapping;
using Eleicoes.Domain.Entities;

namespace Eleicoes.Domain.Csv.Parsers
{
    public class CsvCandidatoParser
    {
        public static Candidato ConverteCsvParaDominio(CsvCandidatoDto csvCandidato)
        {
            var dominio = new Candidato(
                id: long.Parse(csvCandidato.SQ_CANDIDATO),
                numeroCandidato: long.Parse(csvCandidato.NR_CANDIDATO),
                anoeleicao: csvCandidato.ANO_ELEICAO,
                nome: csvCandidato.NM_CANDIDATO,
                nascimento: Convert.ToDateTime(DateTime.ParseExact(csvCandidato.DT_NASCIMENTO, "dd/MM/yyyy", CultureInfo.InvariantCulture)),
                cpf: csvCandidato.NR_CPF_CANDIDATO,
                email: csvCandidato.NM_EMAIL,
                agremiacao: csvCandidato.TP_AGREMIACAO,
                ufNascimento: csvCandidato.SG_UF_NASCIMENTO,
                municipioNascimento: csvCandidato.NM_MUNICIPIO_NASCIMENTO,
                tituloEleitor: csvCandidato.NR_TITULO_ELEITORAL_CANDIDATO,
                genero: new Genero(long.Parse(csvCandidato.CD_GENERO), csvCandidato.DS_GENERO),
                grauInstrucao: new GrauInstrucao(long.Parse(csvCandidato.CD_GRAU_INSTRUCAO), csvCandidato.DS_GRAU_INSTRUCAO),
                estadoCivil: new EstadoCivil(long.Parse(csvCandidato.CD_ESTADO_CIVIL), csvCandidato.DS_ESTADO_CIVIL),
                ocupacao: new Ocupacao(long.Parse(csvCandidato.CD_OCUPACAO), csvCandidato.DS_OCUPACAO),
                cargo: new Cargo(
                    long.Parse(csvCandidato.CD_CARGO),
                    csvCandidato.DS_CARGO,
                    csvCandidato.NM_UE,
                    csvCandidato.SG_UF
                ),
                coligacao: new Coligacao(
                    long.Parse(csvCandidato.SQ_COLIGACAO),
                    csvCandidato.NM_COLIGACAO,
                    csvCandidato.DS_COMPOSICAO_COLIGACAO
                ),
                partido: new Partido(
                    long.Parse(csvCandidato.NR_PARTIDO),
                    csvCandidato.SG_PARTIDO,
                    csvCandidato.NM_PARTIDO
                ),
                situacaoCandidatura: new SituacaoCandidatura(
                    long.Parse(csvCandidato.CD_SITUACAO_CANDIDATURA),
                    csvCandidato.DS_SITUACAO_CANDIDATURA,
                    csvCandidato.DS_DETALHE_SITUACAO_CAND
                )
            );
            return dominio;
        }
    }
}