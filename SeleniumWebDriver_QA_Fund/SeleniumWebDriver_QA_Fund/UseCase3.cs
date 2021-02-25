using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver_QA_Fund
{
    class UseCase3
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

        //==============================================USE CASE 3 - HOME PAGE TESTS=====================================================
        [Test]
        public void ListedSections()
        {

            //Man's Collections
            IWebElement manCollection = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div[2]/div/div[1]/a/h2"));
            Assert.AreEqual("Man's Collections", manCollection);

            //Women's Collections
            IWebElement womenCollection = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div[2]/div/div[2]/a/h2"));
            Assert.AreEqual("Women's Collections", womenCollection);

            //Boy's Collections
            IWebElement boyCollection = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div[2]/div/div[3]/a/h2"));
            Assert.AreEqual("Boy's Collections", boyCollection);

            //Girl's Collections
            IWebElement girlCollection = driver.FindElement(By.XPath("/html/body/div[1]/div[4]/div/div[2]/div/div[4]/a/h2"));
            Assert.AreEqual("Girl's Collections", girlCollection);
        }

        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }

    }
}
