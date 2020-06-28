using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RichardSzalay.MockHttp;
using src.Common;

namespace ResolveJurosTests.Common
{
    [TestClass]
    public class JurosHelperTests
    {

        [TestMethod]
        public async Task GetJuros()
        {
            var mockHttp = new MockHttpMessageHandler();

            mockHttp.When("http://localhost/taxaJuros")
                    .Respond("application/json", "2000");

            var client = new HttpClient(mockHttp);

            var response = await client.GetAsync("http://localhost/taxaJuros");
            var teste = await JurosHelper.GetJuros(response);

            Assert.IsTrue(teste == 2000);
        }

        [TestMethod]
        public void CalculaResultValueOkResult()
        {
            double taxaJuros = 0.01;
            decimal valorInicial = 100;
            int tempo = 5;
            var response = JurosHelper.CalculaJuros(taxaJuros, valorInicial, tempo);

            Assert.IsTrue(Convert.ToDouble(response.Result) == 105.10);
        }
    }
}