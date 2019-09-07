using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Utilities
{
    class JSexecutor
    {
        public static object JSScript(IWebDriver driver, string customCmd)
        {
            return ((IJavaScriptExecutor)driver).ExecuteScript(customCmd);
        }
    }
}
