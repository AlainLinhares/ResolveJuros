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
        public async Task GetJurosTestCorrectResult()
        {
            var mockHttp = new MockHttpMessageHandler();

            mockHttp.When("http://localhost/taxaJuros")
                    .Respond("application/json", Convert.ToString(Constants.TaxaJuros));

            var client = new HttpClient(mockHttp);

            var response = await client.GetAsync("http://localhost/taxaJuros");
            var taxaJuros = await JurosHelper.GetJuros(response);

            Assert.IsTrue(taxaJuros == Constants.TaxaJuros);
        }

        [TestMethod]
        public async Task GetJurosTestIncorrectResult()
        {
            var mockHttp = new MockHttpMessageHandler();

            mockHttp.When("http://localhost/taxaJuros")
                    .Respond("application/json", "100");

            var client = new HttpClient(mockHttp);

            var response = await client.GetAsync("http://localhost/taxaJuros");
            var taxaJuros = await JurosHelper.GetJuros(response);

            Assert.IsFalse(taxaJuros == Constants.TaxaJuros);
        }

        [TestMethod]
        public void CalculaResultValueCorrectResult()
        {
            double taxaJuros = 0.01;
            decimal valorInicial = 100;
            int tempo = 5;
            var response = JurosHelper.CalculaJuros(taxaJuros, valorInicial, tempo);

            Assert.IsTrue(Convert.ToDouble(response.Result) == 105.10);
        }

        [TestMethod]
        public void CalculaResultValueIncorrectResult()
        {
            double taxaJuros = 0;
            decimal valorInicial = 100;
            int tempo = 5;
            var response = JurosHelper.CalculaJuros(taxaJuros, valorInicial, tempo);

            Assert.IsFalse(Convert.ToDouble(response.Result) == 105.10);
        }
    }
}