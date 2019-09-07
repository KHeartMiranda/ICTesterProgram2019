using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Utilities
{
    class Wait
    {
        // Generate wait method to determine web element visibility
        public static void ElementIsVisible(IWebDriver driver, string value, string key)
        {
            try
            {
                if (key == "XPath")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    var Element = Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(value)));
                }
                if (key == "Id")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    var Element = Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(value)));
                }
                if (key == "ClassName")
                {
                    var Wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
                    var Element = Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.ClassName(value)));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
          
    }
}
