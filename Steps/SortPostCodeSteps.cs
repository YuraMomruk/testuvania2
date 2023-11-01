using Lab2Yura.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;


namespace Lab2Yura.Steps
{
    [Binding]
    public class SortPostCodeSteps : BaseSteps
    {
        private IWebDriver driver;
        private BankManagerLoginPage loginPage;
        private CustomersPage customersPage;
        private SortPostCodePage sortPostCodePage;
        private CheckIsSortedByPostCode checkIsSortedByPostCode;
        

        public SortPostCodeSteps(IWebDriver driver)
        {
            this.driver = driver;
            this.loginPage = new BankManagerLoginPage(driver);
            this.customersPage = new CustomersPage(driver);
            this.sortPostCodePage = new SortPostCodePage(driver);
            this.checkIsSortedByPostCode = new CheckIsSortedByPostCode(driver);
        }

        [Given(@"I navigate to the Bank Manager Login page")]
        public void GivenINavigateToTheBankManagerLoginPage()
        {
            loginPage.NavigateToLoginPage("https://www.globalsqa.com/angularJs-protractor/BankingProject");
        }

        [When(@"I log in as Bank Manager")]
        public void WhenILogInAsBankManager()
        {
            loginPage.LogInAsBankManager();
        }

        [When(@"I go to Customers")]
        public void WhenIGoToCustomersPage()
        {
            customersPage.OpenCustomersList();
        }
        [Then(@"I sort elements by Post Code")]
        public void ThenISortElementsByPostCode()
        {
            sortPostCodePage.SortByPostCode();
        }

        [Then(@"I should see the expected results")]
        public void ThenIShouldSeeTheExpectedResults()
        {
            Assert.That(checkIsSortedByPostCode.IsSortedByPostCode(), Is.EqualTo(true));
        }
    }

}