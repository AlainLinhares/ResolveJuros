using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using src.Common;

namespace ResolveJuros.Controllers
{
    [ApiController]
    public class RetornaTaxaJurosController : ControllerBase
    {
        /// <summary>
        /// Retorna o valor da taxa de juros
        /// </summary>
        /// <returns>Retorna o juros de 1% ou 0,01 (fixo no código)</returns>
        [HttpGet]
        [Route("/taxaJuros")]
        public IActionResult TaxaJuros()
        {
            return new ObjectResult(Constants.TaxaJuros)
            {
                StatusCode = StatusCodes.Status200OK,
            };
        }
    }
}
