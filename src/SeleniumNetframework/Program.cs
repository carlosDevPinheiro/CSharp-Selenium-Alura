using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace SeleniumNetframework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IWebDriver driver = new ChromeDriver(@"C:\dev\CSharp\CSharp-Selenium-Alura\src\SeleniumNetframework\Drivers");
            driver.Navigate().GoToUrl("https://localhost:44323/");
            IWebElement campoTexto = driver.FindElement(By.LinkText("Clientes"));
            campoTexto.Click();
            IWebElement campoAdicionar = driver.FindElement(By.LinkText("Adicionar novo cliente"));
            campoAdicionar.Click();

            IWebElement campoFirtName = driver.FindElement(By.Name("FirstName"));
            IWebElement campoLastName = driver.FindElement(By.XPath("//input[@id='LastName']"));
            campoFirtName.SendKeys("Carlos");
            campoLastName.SendKeys("Pinheiro");
            campoLastName.SendKeys(Keys.Tab);
            //campoTexto.SendKeys("Caelum");
            //campoTexto.Submit();
            driver.Close();


            // https://escoladedados.org/tutoriais/xpath-para-raspagem-de-dados-em-html/
        }
    }
}
