using OpenQA.Selenium;
using System;

namespace DesafioSoftplan.pages
{
    class Formularios : PaginaPadrao
    {
        public Formularios(IWebDriver driver) : base(driver)
        {
        }

        public Formularios digitarNome (String nome)
        {
            driver.FindElement(By.ClassName("Nome")).SendKeys(nome);
            return this;
        }

        public Formularios digitarEmail(String email)
        {
            driver.FindElement(By.ClassName("Email")).SendKeys(email);
            return this;
        }

        public Formularios clicarSalvar()
        {
            driver.FindElement(By.ClassName("Salvar")).Click();
            return this;
        }

    }
}
