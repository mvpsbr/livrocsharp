using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ExemploAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DadosController : ControllerBase
    {
        private readonly ILogger<DadosController> _logger;

        public DadosController(ILogger<DadosController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sincrono")]
        public string Get()
        {
            return "Exemplo de API - método sincrono";
        }

        [HttpGet("assincrono")]
        public async Task<string> GetAsync()
        {
            var sr = new StreamReader("./arquivos/teste.txt");
            var conteudo = await sr.ReadToEndAsync();
            sr.Close();
            return conteudo;
            
        }
    }
}
