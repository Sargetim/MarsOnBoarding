using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsOnBoarding.Utilities;

namespace MarsOnBoarding.Pages
{
    public class LoginPage : CommonDriver
    {
        IWebElement signinButton => driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a"));
        IWebElement usernameTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
        IWebElement passwordTextbox => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
        IWebElement loginButton => driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));

        public void LoginActions(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();

            // Launch Mars portal
            driver.Navigate().GoToUrl("http://localhost:5000/Home");
            Thread.Sleep(1000);

            // Click on Sign in button
            driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a")).Click();
            

            try
            {
                // Identify the username textbox and enter valid username
                driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input")).SendKeys("timalasaujan@gmail.com");
                
            }
            catch (Exception ex)
            {
                Assert.Fail("Mars portal home page did not launch.", ex.Message);
            }

            // Identify the password textbox and enter valid password
            
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input")).SendKeys("InternShip18");

            // Identify login button and click on it
            
            driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")).Click();
            Thread.Sleep(1500);
        }
    }
}
