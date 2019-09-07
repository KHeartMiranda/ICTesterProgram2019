using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace ConsoleApp2.HookUp
{
    [Binding]
    public class TMFeatureSteps
    {
        IWebDriver driver;

        [Given(@"I have logged in to Turn Up portal")]
        public void GivenIHaveLoggedInToTurnUpPortal()
        {
            // initiate browser
            driver = new ChromeDriver();

            // navigate to horse dev
            driver.Navigate().GoToUrl("http://horse-dev.azurewebsites.net/Account/Login?ReturnUrl=%2f");

            //maximize page
            driver.Manage().Window.Maximize();


            // access loginsuccess method

            // an instance of a class
            // non-static class
            LoginPage loginInstance = new LoginPage(driver);
            loginInstance.loginsuccess();
        }
        
        [Given(@"I have navigated to the Time and Material page")]
        public void GivenIHaveNavigatedToTheTimeAndMaterialPage()
        {
            HomePage homeInstance = new HomePage(driver);
            homeInstance.VerifyHomePage();
            homeInstance.ClickAdministration();
            homeInstance.ClickTimenMaterial();
        }
        
        [Then(@"I should be able to create a Time and Material record successfully")]
        public void ThenIShouldBeAbleToCreateATimeAndMaterialRecordSuccessfully()
        {
            TimenMaterialPage tmPage = new TimenMaterialPage(driver);
            tmPage.CLickCreateNewBtn();
            tmPage.EnterValidDataandSave();
            tmPage.ValidateData();
            driver.Quit();
        }
        
        [Then(@"I should be able to edit a Time and Material record successfully")]
        public void ThenIShouldBeAbleToEditATimeAndMaterialRecordSuccessfully()
        {
           
        }
        
        [Then(@"I should be able to delete a Time and Material record successfully")]
        public void ThenIShouldBeAbleToDeleteATimeAndMaterialRecordSuccessfully()
        {
            
        }
    }
}
