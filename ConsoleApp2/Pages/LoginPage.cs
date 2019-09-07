using ConsoleApp2.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{  
    class LoginPage
    { 

    IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
            this.driver = driver;
    }
        IWebElement firstname => driver.FindElement(By.Id("UserName"));
        IWebElement password => driver.FindElement(By.Id("Password"));
        IWebElement loginbtn => driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));

        // Accessible with in your solution
        internal void loginsuccess()
        {
            // Enter username using JavaScript executor
            string usernameJS = "document.getElementById('UserName').value = 'hari'";
            JSexecutor.JSScript(driver, usernameJS);

            // Enter password using JavaScript executor
            string passwordJS = "document.getElementById('Password').value = '123123'";
            JSexecutor.JSScript(driver, passwordJS);

            // Verify Login Credentials
            //Assert.That(usernameJS.Equals("hari"));
            //Assert.That(passwordJS, Is.EqualTo("document.getElementById('Password').value = '123124'"));

            // Click Login button
            loginbtn.Click();
            
        }
    }
}
