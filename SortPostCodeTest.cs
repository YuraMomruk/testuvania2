using Lab2Yura.Steps;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Drawing;


namespace Lab2Yura
{
    [TestFixture]
    public class SortPostCodeTest
    {
#pragma warning disable NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method
        private IWebDriver driver;
#pragma warning restore NUnit1032 // An IDisposable field/property should be Disposed in a TearDown method


        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
        }


        [Test]
        public void TestSortPostCodeTest()
        {
            var sortPostCodeSteps = new SortPostCodeSteps(driver);
            sortPostCodeSteps.GivenINavigateToTheBankManagerLoginPage();
            sortPostCodeSteps.WhenILogInAsBankManager();
            sortPostCodeSteps.WhenIGoToCustomersPage();
            sortPostCodeSteps.ThenISortElementsByPostCode();
            sortPostCodeSteps.ThenIShouldSeeTheExpectedResults();
        }
    }

}
