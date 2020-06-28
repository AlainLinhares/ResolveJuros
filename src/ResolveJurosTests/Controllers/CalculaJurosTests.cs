using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResolveJuros.Controllers;
using src.Common;

namespace ResolveJurosTests
{
    [TestClass]
    public class CalculaJurosTests
    {

        [TestMethod]
        public void RetornaURLFromGithubTestOkResult()
        {
            var controller = new CalculaJurosController();
            var response = controller.Showmethecode();

            ObjectResult objResult = (ObjectResult)response;

            Assert.IsInstanceOfType(response, typeof(Microsoft.AspNetCore.Mvc.ObjectResult));
            Assert.IsTrue(objResult.StatusCode == 200);
            Assert.IsTrue(objResult.Value.ToString() == Constants.URLSourceFromGithub);
        }

        [TestMethod]
        public void RetornaURLFromGithubTestFailedResult()
        {
            var controller = new CalculaJurosController();
            var response = controller.Showmethecode();

            ObjectResult objResult = (ObjectResult)response;

            Assert.IsInstanceOfType(response, typeof(Microsoft.AspNetCore.Mvc.ObjectResult));
            Assert.IsFalse(objResult.StatusCode == 500);
            Assert.IsFalse(objResult.Value.ToString() == "API Resolve Juros");
        }
    }
}
