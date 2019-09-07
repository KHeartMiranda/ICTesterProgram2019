using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace ConsoleApp2
{
    internal class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void VerifyHomePage()
        {
            IWebElement username = driver.FindElement(By.XPath("//a[contains(.,'Hello hari!')]"));

            // Verify the result
            Assert.That(username.Text, Is.EqualTo("Hello hari!"));
        }

        internal void ClickAdministration()
        {
            // CLick Administration
            driver.FindElement(By.XPath("//a[contains(.,'Administration')]")).Click();
        }

        internal void ClickTimenMaterial()
        {
            // CLick Time & Material
            driver.FindElement(By.XPath("//a[contains(.,'Time & Materials')]")).Click();
        }
    }
}