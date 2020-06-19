using OpenQA.Selenium;

namespace DesafioSoftplan.pages
{
    class PaginaPadrao
    {
        protected IWebDriver driver;
        public PaginaPadrao(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
