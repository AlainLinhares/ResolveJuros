using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace src.Common
{
    public static class JurosHelper
    {
        public static async Task<double> GetJuros(HttpResponseMessage response)
        {
            var taxaJuros = await response.Content.ReadAsStringAsync();
            return Convert.ToDouble(taxaJuros);
        }

        public static async Task<double> GetJuros(HttpRequest httpRequest)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(httpRequest.Scheme + Constants.Separator + httpRequest.Host.Value);
            HttpResponseMessage httpResponseMessage = client.GetAsync("/taxaJuros").Result;
            return await GetJuros(httpResponseMessage);
        }

        public static async Task<decimal> CalculaJuros(double taxaJuros, decimal valorInicial, int tempo)
        {
            var calcJuros =  (1 + Convert.ToDouble(taxaJuros));
            var pontencia = Math.Pow(calcJuros, tempo);
            var valorJuros = Convert.ToDecimal((Convert.ToDouble(valorInicial) * pontencia).ToString("#.#0"));

            var result = await Task.FromResult(valorJuros);
            return result;
        }
    }
}