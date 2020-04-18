using System.Collections.Generic;
using System.Threading.Tasks;
using Eleicoes.Application.Interfaces;
using Eleicoes.Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eleicoes.Services.API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Consumes("application/json")]
    [Route("api/[controller]")]
    public class CandidatosController : ControllerBase
    {
        private readonly ICandidatoAppService _candidatoAppService;
        private readonly ILogger<CandidatosController> _logger;

        public CandidatosController(
            ICandidatoAppService candidatoAppService,
            ILogger<CandidatosController> logger)
        {
            _candidatoAppService = candidatoAppService;
            _logger = logger;
        }

        /// <summary>
        /// Retorna a lista de candidatos de um ano de eleição.
        /// </summary>
        /// <param name="ano">Ano da eleição</param>
        /// <returns>Lista de candidatos</returns>
        [HttpGet("eleicoes/{ano}")]
        [ProducesResponseType(typeof(IEnumerable<CandidatoViewModel>), 200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public async Task<IEnumerable<CandidatoViewModel>> Get(string ano)
        {
            return await Task.FromResult(_candidatoAppService.Lista(ano));
        }
    }
}