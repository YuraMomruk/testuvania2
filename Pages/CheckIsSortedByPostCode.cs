using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Lab2Yura.Pages
{
    public class CheckIsSortedByPostCode : BasePage
    {
        private WebDriverWait wait;
        private string rootElement = "[class=\"table table-bordered table-striped\"]";
        private string rowElements = "/tbody/tr/td[\"class='ng-binding'\"][3]";

        public CheckIsSortedByPostCode(IWebDriver driver) : base(driver)
        {
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public bool IsSortedByPostCode()
        {
            IWebElement table = driver.FindElement(By.CssSelector(rootElement));
            List<IWebElement> postCodes = table.FindElements(By.XPath(rowElements))
                .ToList();

            List<IWebElement> sortedPostCodes = new List<IWebElement>(postCodes);
            sortedPostCodes.Sort((a, b) => String.Compare(a.Text, b.Text, StringComparison.Ordinal));
            
            if(!postCodes.SequenceEqual(sortedPostCodes))
            {
                return false;
            }

            return true;
        }
    }
}
