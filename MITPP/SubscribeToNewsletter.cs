using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class SubscribeToNewsletter
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void TheSubscribeToNewsletterTest()
        {
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/");
            driver.FindElement(By.Id("fieldName")).Click();
            driver.FindElement(By.Id("fieldName")).Clear();
            driver.FindElement(By.Id("fieldName")).SendKeys("Dejana");
            driver.FindElement(By.Id("fieldEmail")).Click();
            driver.FindElement(By.Id("fieldEmail")).Clear();
            driver.FindElement(By.Id("fieldEmail")).SendKeys("dejanaristic13@gmail.com");
            driver.FindElement(By.Id("fieldijyktid")).Click();
            driver.FindElement(By.Id("fieldijyktid")).Clear();
            driver.FindElement(By.Id("fieldijyktid")).SendKeys("0977777777");
            driver.FindElement(By.XPath("//form[@id='subForm']/button")).Click();
            driver.Navigate().GoToUrl("https://www.ekupi.hr/Prijava-na-eKupi-obavijesti");
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
