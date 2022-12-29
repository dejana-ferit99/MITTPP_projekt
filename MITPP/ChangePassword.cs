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
    public class ChangePassword
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
        public void TheChangePasswordTest()
        {
            driver.Navigate().GoToUrl("https://www.ekupi.hr/hr/");
            driver.FindElement(By.LinkText("Prijava / Registracija")).Click();
            driver.FindElement(By.Id("j_username")).Click();
            driver.FindElement(By.Id("j_username")).Clear();
            driver.FindElement(By.Id("j_username")).SendKeys("dejanaristic13@gmail.com");
            driver.FindElement(By.Id("j_password")).Click();
            driver.FindElement(By.Id("j_password")).Clear();
            driver.FindElement(By.Id("j_password")).SendKeys("eKupi_Dejana.1999");
            driver.FindElement(By.Id("submit")).Click();
            driver.FindElement(By.LinkText("Moj profil")).Click();
            driver.FindElement(By.XPath("//div[@id='accountNavLinks']/ul/li[4]/a")).Click();
            driver.FindElement(By.Id("currentPassword")).Click();
            driver.FindElement(By.Id("currentPassword")).Clear();
            driver.FindElement(By.Id("currentPassword")).SendKeys("eKupi_Dejana.1999");
            driver.FindElement(By.Id("newPassword")).Click();
            driver.FindElement(By.Id("newPassword")).Clear();
            driver.FindElement(By.Id("newPassword")).SendKeys("eKupi_Dejana.19999");
            driver.FindElement(By.Id("checkNewPassword")).Click();
            driver.FindElement(By.Id("checkNewPassword")).Clear();
            driver.FindElement(By.Id("checkNewPassword")).SendKeys("eKupi_Dejana.19999");
            driver.FindElement(By.XPath("//form[@id='updatePasswordForm']/div[4]/div/div/button")).Click();
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
