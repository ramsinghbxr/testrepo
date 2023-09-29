using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDemo
{
    public class TestAutomation
    {
        IWebDriver? driver;

        [SetUp]
        public void Setup() { }

        [Test]
        public void Test()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://google.com");
            driver.FindElement(By.CssSelector("[aria-label='Search']")).SendKeys("IPEM");
            driver
                .FindElement(
                    By.XPath("(//ul[@role=\"listbox\"])[1]/li//*[@aria-label=\"ipem law academy\"]")
                )
                .Click();
            Thread.Sleep(10000);
        }

        [TearDown]
        public void TearDown()
        {
            driver!.Quit();
        }
    }
}
