using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Lab2Yura.Steps
{
    [Binding]
    public class BaseSteps
    {
        protected static WebDriverWait wait;
        protected static IWebDriver driver;
        [BeforeFeature]
        public static void BeforeFeauture()
        {

            driver = new ChromeDriver(@".\");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));


        }
        [AfterFeature]
        public static void AfterFeature()
        {
            driver.Close();
        }
    }
}
