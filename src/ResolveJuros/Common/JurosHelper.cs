using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace src.Common
{
    public static class JurosHelper
    {
        public static async Task<double> GetJuros(HttpRequest request)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(request.Scheme + Constants.Separator + request.Host.Value);
            HttpResponseMessage response = client.GetAsync("/taxaJuros").Result;
            var taxaJuros = await response.Content.ReadAsStringAsync();
            return Convert.ToDouble(taxaJuros);
        }

        public static async Task<decimal> CalculaJuros(HttpRequest request, decimal valorInicial, int tempo)
        {
            var taxaJuros = GetJuros(request).Result;
            var calcJuros =  (1 + Convert.ToDouble(taxaJuros));
            var pontencia = Math.Pow(calcJuros, tempo);
            var valorJuros = Convert.ToDecimal((Convert.ToDouble(valorInicial) * pontencia).ToString("#.#0"));

            var result = await Task.FromResult(valorJuros);
            return result;
        }
    }
}