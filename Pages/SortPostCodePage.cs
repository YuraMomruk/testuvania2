using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Yura.Pages
{
    public class SortPostCodePage : BasePage
    {
        private WebDriverWait wait;
        private string rootElement = "[ng-click=\"sortType = 'postCd'; sortReverse = !sortReverse\"]";

        public SortPostCodePage(IWebDriver driver) : base(driver)
        {
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public void SortByPostCode()
        {
            IWebElement button = driver.FindElement(By.CssSelector(rootElement));
            button.Click();
        }

    }
}
