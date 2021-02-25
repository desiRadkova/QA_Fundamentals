using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumWebDriver_QA_Fund
{
    class UseCase1
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
        //============================================USE CASE 1 - ACCESS SYSTEM TESTS================================================
        [Test]
        public void AccessSystem()
        {
            //Is the system loading successful
        }
        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }

    }
}
