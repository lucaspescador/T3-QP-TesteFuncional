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
            IWebDriver driver = new ChromeDriver(
            Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            //Acessar o site do moodle
            driver.Navigate().GoToUrl("https://moodle.pucrs.br/");

            //Aguardar at� aparecer a palavra "Moodle" no t�tulo do site.
            Assert.Contains("Moodle", driver.Title);

            //Preencher campo login com o email testelucas@gmail.com
            IWebElement login = driver.FindElement(By.Id("login_username"));
            login.SendKeys("testelucas@gmail.com");

            //Preencher senha com o valor 123456 e pressionar o bot�o enter.
            IWebElement password = driver.FindElement(By.Id("login_password"));
            password.SendKeys("123456");
            password.SendKeys(Keys.Enter);

            //Aguardar at� aparecer a palavra "Pontif�cia" no t�tulo do site
            Assert.Contains("Pontif�cia", driver.Title);

            //Clicar no elemento que possui o texto "Esqueceu o seu usu�rio ou senha?"
            driver.FindElement(By.LinkText("Esqueceu o seu usu�rio ou senha?")).Click();

            //Preencher com o email 
            driver.FindElement(By.Id("id_email")).SendKeys("testelucas@gmail.com");

            //Clicar no bot�o buscar
            driver.FindElement(By.Name("submitbuttonemail")).Click();
            
        }
    }
}