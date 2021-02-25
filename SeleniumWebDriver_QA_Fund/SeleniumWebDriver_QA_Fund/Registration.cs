using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Xml.Linq;

namespace SeleniumWebDriver_QA_Fund
{
    class Registration
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
        //=============================================REGISTRATION TESTS==============================================================
        [Test]
        public void ValidRegistration()
        {
            
            //The test finds the element but it doesn't want to click on it
            //When you debug test the error is for not clickable element
            //---------------------------------------------------------------------------------
     
           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
           wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            IWebElement myAccount = driver.FindElement(By.XPath("/html/body/div[2]/div[3]/div[2]/div[1]/div[5]/ul/li[2]/a"));
            
            myAccount.Click();

            //-----------------------------------------------------------------------------------

        }
       
        [TearDown]
        public void close_Browser()
        {
            driver.Quit();
        }

    }
}
