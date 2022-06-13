using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using System.IO;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange - dado que o navegador está aberto
            IWebDriver driver = new ChromeDriver(
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            //act - quando navegamos para a URL https://www.caelum.com.br
            driver.Navigate().GoToUrl("https://www.caelum.com.br");

            //assert - então esperamos que a página apresentada seja da Caelum
            Assert.Contains("Caelum", driver.Title);
        }
    }
}