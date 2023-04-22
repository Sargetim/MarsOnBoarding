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
    public class MarsOnBoardingStepDefinitions : CommonDriver
    {

        LoginPage loginPageObj;
        LanguagePage languagePageObj;
        

        public MarsOnBoardingStepDefinitions()
        {
            loginPageObj = new LoginPage(driver);
            languagePageObj = new LanguagePage(driver);
        }

        [Given(@"I launch and log into Mars portal successfully")]
        public void GivenILaunchAndLogIntoMarsPortalSuccessfully()
        {
            loginPageObj.LoginActions();
        }


        [When(@"I add new language")]
        public void WhenIAddNewLanguage()
        {
            languagePageObj.AddLanguages();
        }

        [Then(@"The new language should be added successfully")]
        public void ThenTheNewLanguageShouldBeAddedSuccessfully()
        {
            string newLanguage = languagePageObj.alertWindow();
            Assert.That(newLanguage == "English has been added to your languages", "Failed to add language");
            
        }

        [When(@"I edit the added language")]
        public void WhenIEditTheAddedLanguage()
        {
            languagePageObj.EditLanguages();
        }

        [Then(@"The edited language should be added successfully")]
        public void ThenTheEditedLanguageShouldBeAddedSuccessfully()
        {
            string editLanguage = languagePageObj.alertWindow();
            Assert.That(editLanguage == "Nepali has been updated to your languages", "Failed to add language");
            
        }

        [When(@"I delete the added language")]
        public void WhenIDeleteTheAddedLanguage()
        {
            languagePageObj.DeleteLanguage();
        }

        [Then(@"The added language should be deleted successfully")]
        public void ThenTheAddedLanguageShouldBeDeletedSuccessfully()
        {
            string deleteLanguage = languagePageObj.alertWindow();
            Assert.That(deleteLanguage == "Nepali has been deleted from your languages", "Failed to add language");
            
        }

        [AfterScenario]

        public void Teardown()
        {
            driver.Quit();
        }


    }
}
