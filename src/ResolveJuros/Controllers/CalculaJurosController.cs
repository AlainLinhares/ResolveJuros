using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using src.Common;

namespace ResolveJuros.Controllers
{
    [ApiController]
    public class CalculaJurosController : ControllerBase
    {
        /// <summary>
        /// Essa API faz um cálculo em memória, de juros compostos, usado como base a seguinte fórmula : Valor Final = Valor Inicial * (1 + juros) ^ Tempo
        /// </summary>
        /// <param name="valorInicial">Represente o valor do juros (decimal) antes do cálculo ser processado</param>
        /// <param name="tempo">É um inteiro, que representa meses</param>
        /// <returns>Retorna o calculo e o valor dos juros </returns>
        [HttpGet]
        [Route("/calculajuros/{valorInicial}/{tempo}")]
        public IActionResult Calculajuros(decimal valorInicial, int tempo)
        {
            var valorJuros = JurosHelper.CalculaJuros(this.Request, valorInicial, tempo).Result;

            return new ObjectResult(valorJuros)
            {
                StatusCode = StatusCodes.Status200OK,
            };
        }

        /// <summary>
        /// Essa API retorna a url de onde encontra-se o código fonte no github.
        /// </summary>
        /// <returns>URL do código fonte que foi hospedado no github</returns>
        [HttpGet]
        [Route("/showmethecode")]
        public IActionResult Showmethecode()
        {
            return new ObjectResult(Constants.URLSourceFromGithub)
            {
                StatusCode = StatusCodes.Status200OK,
            };
        }
    }
}
