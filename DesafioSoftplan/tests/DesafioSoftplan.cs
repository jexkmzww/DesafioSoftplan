using DesafioSoftplan.pages;
using DesafioSoftplan.support;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DesafioSoftplan
{
    [TestFixture]
    class DesafioSoftplan
    {

        private IWebDriver driver;

        static void Main(string[] args)
        {
        }

        [Test]
        public void testCadastraFormulario()
        {
            new Formularios(driver).
                digitarNome("Teste").
                digitarEmail("teste@gmail.com").
                clicarSalvar();

            System.Threading.Thread.Sleep(4000);
            Assert.AreEqual("Teste", driver.FindElement(By.ClassName("Nome")));
            Assert.AreEqual("teste@gmail.com", driver.FindElement(By.ClassName("Email")));
        }

        [SetUp]
        public void SetUp()
        {
            driver = Web.criarChrome();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

    }
}
