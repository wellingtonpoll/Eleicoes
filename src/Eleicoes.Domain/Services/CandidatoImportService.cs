using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eleicao.IO.Domain.CsvMapping;
using Eleicoes.Domain.Csv.Parsers;
using Eleicoes.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using TinyCsvParser;

namespace Eleicoes.Domain.Services
{
    public class CandidatoImportService : ICandidatoImportService
    {
        private readonly ICandidatoRepository _candidatoRepository;
        private readonly ILogger<CandidatoImportService> _logger;
        private CsvParser<CsvCandidatoDto> csvParser = new CsvParser<CsvCandidatoDto>(new CsvParserOptions(true, ';'), new CsvCandidatoMapping());

        public CandidatoImportService(
            ICandidatoRepository candidatoRepository,
            ILogger<CandidatoImportService> logger)
        {
            _candidatoRepository = candidatoRepository;
            _logger = logger;
        }
        
        public async Task DoWork()
        {
            try
            {
                _logger.LogInformation("Serviço de importação de candidatos csv iniciando...");
                var csvCandidatos = new List<CsvCandidatoDto>();

                _logger.LogInformation("Verificando diretório...");
                var dir = $"{Directory.GetCurrentDirectory()}/files";
                if(!Directory.Exists(dir))
                    Directory.CreateDirectory(dir);

                _logger.LogInformation("Carregando arquivos...");
                var files = Directory.GetFiles(dir);
                foreach (var file in files)
                {
                    var records = csvParser.ReadFromFile(file, Encoding.GetEncoding("ISO-8859-1"));
                    csvCandidatos.AddRange(records.Select(c => c.Result));
                    File.Delete(file);
                }

                if (csvCandidatos.Any())
                {
                    _logger.LogInformation("Convertendo candidatos...");
                    var candidatos = csvCandidatos.Select(c => CsvCandidatoParser.ConverteCsvParaDominio(c));

                    _logger.LogInformation("Armazenando candidatos...");
                    await _candidatoRepository.AdicionaAsync(candidatos);
                }

                _logger.LogInformation("Serviço de importação de candidatos csv finalizado com sucesso!");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Ocorreu uma falha durante a importação dos candidatos csv! Detalhes: {ex.Message}");
            }
        }
    }
}