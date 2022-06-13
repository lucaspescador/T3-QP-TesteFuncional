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

            //Aguardar até aparecer a palavra "Moodle" no título do site.
            Assert.Contains("Moodle", driver.Title);

            //Preencher campo login com o email testelucas@gmail.com
            IWebElement login = driver.FindElement(By.Id("login_username"));
            login.SendKeys("testelucas@gmail.com");

            //Preencher senha com o valor 123456 e pressionar o botão enter.
            IWebElement password = driver.FindElement(By.Id("login_password"));
            password.SendKeys("123456");
            password.SendKeys(Keys.Enter);

            //Aguardar até aparecer a palavra "Pontifícia" no título do site
            Assert.Contains("Pontifícia", driver.Title);

            //Clicar no elemento que possui o texto "Esqueceu o seu usuário ou senha?"
            driver.FindElement(By.LinkText("Esqueceu o seu usuário ou senha?")).Click();

            //Preencher com o email 
            driver.FindElement(By.Id("id_email")).SendKeys("testelucas@gmail.com");

            //Clicar no botão buscar
            driver.FindElement(By.Name("submitbuttonemail")).Click();
            
        }
    }
}