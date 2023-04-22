using MarsOnBoarding.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsOnBoarding.Pages
{
    public class LanguagePage 
    {
        private readonly IWebDriver driver;

        public LanguagePage(IWebDriver driver) { this.driver = driver; }

        private IWebElement addNewLanguageButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private IWebElement addLanguageTextbox => driver.FindElement(By.Name("name"));
        private IWebElement languageLevelDropdown => driver.FindElement(By.Name("level"));
        private IWebElement languageLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
        private IWebElement addLanguangeButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        public void AddLanguages()
        {

            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 4);

            addNewLanguageButton.Click();

            addLanguageTextbox.SendKeys("English");

            languageLevelDropdown.Click();

            languageLevel.Click();

            addLanguangeButton.Click();

        }

        private IWebElement editLanguageButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
        private IWebElement editLanguageTextbox => driver.FindElement(By.Name("name"));

        private IWebElement editedLanguageLevelDropdown => driver.FindElement(By.Name("level"));
        private IWebElement editedLanguageLevel => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[5]"));
        private IWebElement updateLanguageButton => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
        public void EditLanguages()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 5);

            editLanguageButton.Click();

            editLanguageTextbox.Clear();
            editLanguageTextbox.SendKeys("Nepali");

            editedLanguageLevelDropdown.Click();

            editedLanguageLevel.Click();

            updateLanguageButton.Click();

        }

        private IWebElement deleteLanguage => driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
        public void DeleteLanguage()
        {
            Wait.WaitToBeClickable(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div", 5);

            deleteLanguage.Click();
        }

        public string alertWindow()
        {

            Wait.WaitForELementToExist(driver, "CssSelector", "[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]", 3);

            IWebElement confirmationAlert = driver.FindElement(By.CssSelector("[class=\"ns-box ns-growl ns-effect-jelly ns-type-success ns-show\"]"));
            return confirmationAlert.Text;

        }

    }
}
