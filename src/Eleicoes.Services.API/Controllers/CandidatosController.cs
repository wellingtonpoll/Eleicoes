using System.Collections.Generic;
using System.Threading.Tasks;
using Eleicoes.Application.Interfaces;
using Eleicoes.Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eleicoes.Services.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpGet("eleicao/{ano}")]
        public async Task<IEnumerable<CandidatoViewModel>> Get(string ano)
        {
            return await Task.FromResult(_candidatoAppService.Lista(ano));
        }
    }
}