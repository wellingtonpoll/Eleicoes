using TinyCsvParser.Mapping;

namespace Eleicao.IO.Domain.CsvMapping
{
    public class CsvCandidatoMapping : CsvMapping<CsvCandidatoDto>
    {
        public CsvCandidatoMapping()
            : base()
        {
            MapProperty(0, c => c.DT_GERACAO);
            MapProperty(1, c => c.HH_GERACAO);
            MapProperty(2, c => c.ANO_ELEICAO);
            MapProperty(3, c => c.CD_TIPO_ELEICAO);
            MapProperty(4, c => c.NM_TIPO_ELEICAO);
            MapProperty(5, c => c.NR_TURNO);
            MapProperty(6, c => c.CD_ELEICAO);
            MapProperty(7, c => c.DS_ELEICAO);
            MapProperty(8, c => c.DT_ELEICAO);
            MapProperty(9, c => c.TP_ABRANGENCIA);
            MapProperty(10, c => c.SG_UF);
            MapProperty(11, c => c.SG_UE);
            MapProperty(12, c => c.NM_UE);
            MapProperty(13, c => c.CD_CARGO);
            MapProperty(14, c => c.DS_CARGO);
            MapProperty(15, c => c.SQ_CANDIDATO);
            MapProperty(16, c => c.NR_CANDIDATO);
            MapProperty(17, c => c.NM_CANDIDATO);
            MapProperty(18, c => c.NM_URNA_CANDIDATO);
            MapProperty(19, c => c.NM_SOCIAL_CANDIDATO);
            MapProperty(20, c => c.NR_CPF_CANDIDATO);
            MapProperty(21, c => c.NM_EMAIL);
            MapProperty(22, c => c.CD_SITUACAO_CANDIDATURA);
            MapProperty(23, c => c.DS_SITUACAO_CANDIDATURA);
            MapProperty(24, c => c.CD_DETALHE_SITUACAO_CAND);
            MapProperty(25, c => c.DS_DETALHE_SITUACAO_CAND);
            MapProperty(26, c => c.TP_AGREMIACAO);
            MapProperty(27, c => c.NR_PARTIDO);
            MapProperty(28, c => c.SG_PARTIDO);
            MapProperty(29, c => c.NM_PARTIDO);
            MapProperty(30, c => c.SQ_COLIGACAO);
            MapProperty(31, c => c.NM_COLIGACAO);
            MapProperty(32, c => c.DS_COMPOSICAO_COLIGACAO);
            MapProperty(33, c => c.CD_NACIONALIDADE);
            MapProperty(34, c => c.DS_NACIONALIDADE);
            MapProperty(35, c => c.SG_UF_NASCIMENTO);
            MapProperty(36, c => c.CD_MUNICIPIO_NASCIMENTO);
            MapProperty(37, c => c.NM_MUNICIPIO_NASCIMENTO);
            MapProperty(38, c => c.DT_NASCIMENTO);
            MapProperty(39, c => c.NR_IDADE_DATA_POSSE);
            MapProperty(40, c => c.NR_TITULO_ELEITORAL_CANDIDATO);
            MapProperty(41, c => c.CD_GENERO);
            MapProperty(42, c => c.DS_GENERO);
            MapProperty(43, c => c.CD_GRAU_INSTRUCAO);
            MapProperty(44, c => c.DS_GRAU_INSTRUCAO);
            MapProperty(45, c => c.CD_ESTADO_CIVIL);
            MapProperty(46, c => c.DS_ESTADO_CIVIL);
            MapProperty(47, c => c.CD_COR_RACA);
            MapProperty(48, c => c.DS_COR_RACA);
            MapProperty(49, c => c.CD_OCUPACAO);
            MapProperty(50, c => c.DS_OCUPACAO);
            MapProperty(51, c => c.NR_DESPESA_MAX_CAMPANHA);
            MapProperty(52, c => c.CD_SIT_TOT_TURNO);
            MapProperty(53, c => c.DS_SIT_TOT_TURNO);
            MapProperty(54, c => c.ST_REELEICAO);
            MapProperty(55, c => c.ST_DECLARAR_BENS);
            MapProperty(56, c => c.NR_PROTOCOLO_CANDIDATURA);
            MapProperty(57, c => c.NR_PROCESSO);
        }
    }
}