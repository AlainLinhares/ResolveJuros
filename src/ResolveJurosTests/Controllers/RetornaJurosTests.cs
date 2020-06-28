using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResolveJuros.Controllers;

namespace ResolveJurosTests
{
    [TestClass]
    public class RetornaJurosTests
    {
        [TestMethod]
        public void RetornaTaxaJurosTestOkResult()
        {
            var controller = new RetornaTaxaJurosController();
            var response = controller.TaxaJuros();

            ObjectResult objResult = (ObjectResult)response;

            Assert.IsTrue(objResult.StatusCode == 200);
        }

        [TestMethod]
        public void RetornaTaxaJurosTestFailedResult()
        {
            var controller = new RetornaTaxaJurosController();
            var response = controller.TaxaJuros();

            ObjectResult objResult = (ObjectResult)response;

            Assert.IsFalse(objResult.StatusCode != 200);
        }
    }
}
