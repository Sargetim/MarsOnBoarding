using MarsOnBoarding.Pages;
using MarsOnBoarding.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsOnBoarding.StepDefinitions
{
    [Binding]
    public class MarsOnBoardingStepDefinitions 
    {
        IWebDriver driver = new ChromeDriver();
        LoginPage loginPageObj = new LoginPage();
        LanguagePage languagePageObj = new LanguagePage();
        CommonDriver commonDriverObj = new CommonDriver();

        [Given(@"I launch and log into Mars portal successfully")]
        public void GivenILaunchAndLogIntoMarsPortalSuccessfully()
        {
            loginPageObj.LoginActions(driver);
        }


        [When(@"I add new language")]
        public void WhenIAddNewLanguage()
        {
            languagePageObj.AddLanguages(driver);
        }

        [Then(@"The new language should be added successfully")]
        public void ThenTheNewLanguageShouldBeAddedSuccessfully()
        {
            string newLanguage = commonDriverObj.alertWindow(driver);
            Assert.That(newLanguage == "English has been added to your languages", "Failed to add language");
            driver.Quit();
        }

        [When(@"I edit the added language")]
        public void WhenIEditTheAddedLanguage()
        {
            languagePageObj.EditLanguages(driver);
        }

        [Then(@"The edited language should be added successfully")]
        public void ThenTheEditedLanguageShouldBeAddedSuccessfully()
        {
            string editLanguage = commonDriverObj.alertWindow(driver);
            Assert.That(editLanguage == "Nepali has been updated to your languages", "Failed to add language");
            driver.Quit();
        }

        [When(@"I delete the added language")]
        public void WhenIDeleteTheAddedLanguage()
        {
            languagePageObj.DeleteLanguage(driver);
        }

        [Then(@"The added language should be deleted successfully")]
        public void ThenTheAddedLanguageShouldBeDeletedSuccessfully()
        {
            string deleteLanguage = commonDriverObj.alertWindow(driver);
            Assert.That(deleteLanguage == "Nepali has been deleted from your languages", "Failed to add language");
            driver.Quit();
        }



    }
}
