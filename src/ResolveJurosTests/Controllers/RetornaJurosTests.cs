using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResolveJuros.Controllers;
using src.Common;

namespace ResolveJurosTests
{
    [TestClass]
    public class RetornaJurosTests
    {
        [TestMethod]
        public void RetornaJurosTestOkResult()
        {
            var controller = new ResolveJurosController();
            var response = controller.TaxaJuros();

            Assert.IsInstanceOfType(response, typeof(Microsoft.AspNetCore.Mvc.OkResult));
        }
    }
}
