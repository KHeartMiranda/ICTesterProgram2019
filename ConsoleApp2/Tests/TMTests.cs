using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TMTests
    {
        static void Main(string[] args)
        {
            
        }

        IWebDriver driver;       

        [SetUp] 
        public void BeforeEachTestCase()
        {
            // Initiate browser
            driver = new ChromeDriver();

            // Navigate to horse dev
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            // Maximize page
            driver.Manage().Window.Maximize();

            // Access loginsuccess method

            // An instance of a class
            // Non-static class
            LoginPage loginInstance = new LoginPage(driver);
            loginInstance.loginsuccess();
        }

        public void AfterEachTestCase()
        {
            // close the driver
            driver.Quit();
        }

        [Test]
        public void CreateTMnValidate()
        {

            // class for Home page
            // method to verify the home
            // method to click administration
            // method to click time n material

            HomePage homeInstance = new HomePage(driver);
            homeInstance.VerifyHomePage();
            homeInstance.ClickAdministration();
            homeInstance.ClickTimenMaterial();

            TimenMaterialPage tmPage = new TimenMaterialPage(driver/*, code, desc, price*/);
            tmPage.CLickCreateNewBtn();
            tmPage.EnterValidDataandSave();
            tmPage.ValidateData();            

        }

        [Test]
        public void EditnValidate()
        {

            // class for Home page
            // method to verify the home
            // method to click administration
            // method to click time n material

            HomePage homeInstance = new HomePage(driver);
            homeInstance.VerifyHomePage();
            homeInstance.ClickAdministration();
            homeInstance.ClickTimenMaterial();

            TimenMaterialPage tmPage = new TimenMaterialPage(driver/*, code, desc, price*/);
            //tmPage.CLickCreateNewBtn();
            //tmPage.EnterValidDataandSave();
            //tmPage.ValidateData();

            //tmPage.EditData();

        }

        [Test]
        public void DeletenValidate()
        {

            // class for Home page
            // method to verify the home
            // method to click administration
            // method to click time n material

            HomePage homeInstance = new HomePage(driver);
            homeInstance.VerifyHomePage();
            homeInstance.ClickAdministration();
            homeInstance.ClickTimenMaterial();

            TimenMaterialPage tmPage = new TimenMaterialPage(driver/*, code, desc, price*/);
            //tmPage.CLickCreateNewBtn();
            //tmPage.EnterValidDataandSave();
            //tmPage.ValidateData();
        }

        // access static class
        //StaticClass.StaticMethod();
    }
}  

