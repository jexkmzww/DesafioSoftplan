using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DesafioSoftplan.support
{
    class Web
    {
        public static IWebDriver criarChrome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://localhost:8080/usuarios";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            return driver;
        }
    }
}
