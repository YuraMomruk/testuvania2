using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lab2Yura.Pages;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Lab2Yura.Pages
{

    public class BankManagerLoginPage : BasePage
    {
        private WebDriverWait wait;
        private string rootElement = "[ng-click='manager()']";

        public BankManagerLoginPage(IWebDriver driver) : base(driver)
        {
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void NavigateToLoginPage(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void LogInAsBankManager()
        {
            IWebElement button = driver.FindElement(By.CssSelector(rootElement));
            button.Click();
        }

    }


}