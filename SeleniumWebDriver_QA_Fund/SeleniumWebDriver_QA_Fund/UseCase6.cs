using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver_QA_Fund
{
    class UseCase6
    {
        //Adding driver for Chrome browser
        IWebDriver driver = new ChromeDriver();
        [SetUp]
        static public void OpenSystem()
        {
            //Adding driver for Chrome browser
            IWebDriver driver = new ChromeDriver();
            //Select the url of the system
            driver.Navigate().GoToUrl("https://www.mountainwarehouse.com/");
            //Selecting the size of the window
            driver.Manage().Window.Maximize();
        }

        //==============================================USE CASE 6 - SEARCH TESTS=====================================================

        [Test]
        public void SearchFunctionality()
        {

            IWebElement search = driver.FindElement(By.Id("HeaderSearch"));
            search.SendKeys("computer");
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Enter);
            IWebElement searchResult = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div/div/div/div[2]/div[1]/div/div/span"));
            Assert.AreEqual("We searched high and low. Sorry, no matches found for {search input}", searchResult);
        }
        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }

    }
}
