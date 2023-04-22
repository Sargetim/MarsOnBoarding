using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsOnBoarding.Utilities;
using System.Security.Cryptography.X509Certificates;

namespace MarsOnBoarding.Pages
{
    public class LoginPage 
    {
        readonly IWebDriver driver;

        public LoginPage(IWebDriver driver) { this.driver = driver; }

        private IWebElement signinButton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        private IWebElement usernameTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        private IWebElement passwordTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        private IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
        public void LoginActions()
        {
            
            driver.Manage().Window.Maximize();

            //turnup portal
            driver.Navigate().GoToUrl("http://localhost:5000/");

            Thread.Sleep(1000);

            //driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a")).Click();
            signinButton.Click();
            //  try
            //  {
            //  driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"))
            usernameTextbox.SendKeys("timalasaujan@gmail.com");
            //}
            //catch (Exception ex)
            // {
            // Assert.Fail("Home Page did not launch", ex.Message);
            //}
            //Identify Password textbox and enter password

            passwordTextbox.SendKeys("InternShip18");

            //Identify Login button and click on login button
            // driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"))
            loginButton.Click();
            Wait.WaitForELementToExist(driver, "XPath", "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span", 5);
            Thread.Sleep(1000);


        }
    }
}