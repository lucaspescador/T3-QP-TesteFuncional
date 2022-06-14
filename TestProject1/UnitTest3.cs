using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;

namespace TestProject1
{
    public class UnitTest3
    {
        [Fact]
        public void Test3()
        {
            IWebDriver driver = new ChromeDriver(
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            //Acessar o site da OLX
            driver.Navigate().GoToUrl("https://www.olx.com.br/");

            //Procura pelo id do input e preenche
            IWebElement consulta = driver.FindElement(By.Id("searchtext"));
            consulta.SendKeys("Carro Vermelho");
            consulta.SendKeys(Keys.Enter);

            //Clicar no botão Anunciar 
            driver.FindElement(By.PartialLinkText("Anunciar")).Click();

        }
    }
}