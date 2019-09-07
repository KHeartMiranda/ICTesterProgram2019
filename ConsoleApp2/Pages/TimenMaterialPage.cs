using OpenQA.Selenium;
using System;
using System.Threading;
using System.Linq;
using OpenQA.Selenium.Support.UI;
using Docker.DotNet.Models;
using ConsoleApp2.Utilities;

namespace ConsoleApp2
{
    internal class TimenMaterialPage
    {
        private IWebDriver driver;
        string code, desc, price;

        public TimenMaterialPage(IWebDriver driver/* string code, string desc, string price*/)
        {
            this.driver = driver;
        }

        internal void CLickCreateNewBtn()
        {
            // Click Create New button
            driver.FindElement(By.XPath("//a[contains(.,'Create New')]")).Click();
        }

        internal void EnterValidDataandSave()
        {
            ExcelLibHelpers.PopulateInCollection(@"C:\Users\KHeartMiranda\source\repos\ConsoleApp2\ConsoleApp2\Test Data\Test.xlsx", "Data Sheet");

            //driver.FindElement(By.XPath("(//span[contains(.,'Time')])[3]"));
            driver.FindElement(By.Id("Code")).SendKeys(ExcelLibHelpers.ReadData(2, "Code"));
            driver.FindElement(By.Id("Description")).SendKeys(ExcelLibHelpers.ReadData(2, "Description"));
            driver.FindElement(By.XPath("//input[contains(@class,'k-formatted-value k-input')]")).SendKeys(ExcelLibHelpers.ReadData(2, "Price"));
            driver.FindElement(By.Id("SaveButton")).Click();
        }

        internal void ValidateData()
        {
            Wait.ElementIsVisible(driver, "//*[@id=\"tmsGrid\"]/div[3]/table", "XPath");
            try
            {              
                IWebElement table = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table"));
                while (true)
                {
                    var rows = table.FindElements(By.TagName("tr"));                   
                    foreach (var row in rows)
                        
                    //for (int  i = 1; i <= 10; i++)
                    {
                        var columns = row.FindElements(By.TagName("td")).ToList();
                        //IWebElement code = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[" + i +"]/td[1]"));
        
                        code = ExcelLibHelpers.ReadData(2, "Code");
                        desc = ExcelLibHelpers.ReadData(2, "Description");
                        price = ExcelLibHelpers.ReadData(2, "Price");

                        if ((columns[0].Text == code) && (columns[2].Text == desc) && (columns[3].Text == price))
                        {
                            Console.WriteLine("Test passed! Code found on the table");
                            return;
                        }                        
                    }
                    //Navigate to next page until the next button is disabled, otherwise the last page gets loaded infinitely
                    if (!driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[3]")).GetAttribute("class").Contains("k-state-disabled"))
                    {
                        driver.FindElement(By.XPath("//span[contains(.,'Go to the next page')]")).Click();
                    }
                    else
                    { 
                        Console.WriteLine("Test failed! Code not found.");
                        return;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Test failed! Code not found.");
            }
        }
    }
}
