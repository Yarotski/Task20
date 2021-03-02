using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WebDriverTest.Pages
{
    class TutByLogIn
    {
        protected IWebDriver _driver;

        private By authorizeLink = By.XPath("//a[@data-target-popup='authorize-form']");
        private By userNameBy = By.XPath("//input[@name='login']");
        private By passwordBy = By.XPath("//input[@name='password']");
        private By loginButtonBy = By.XPath("//input[@value ='Войти']");
        
        public TutByLogIn(IWebDriver driver)
        {
            _driver = driver;
            _driver.Navigate().GoToUrl("http:\\www.tut.by");
        }

        public LoginProcessTutBy Login(string userName, string password)
        {
            _driver.FindElement(authorizeLink).Click();
            Thread.Sleep(1000);
            _driver.FindElement(userNameBy).SendKeys(userName);
            _driver.FindElement(passwordBy).SendKeys(password);
            _driver.FindElement(loginButtonBy).Click();
            return new LoginProcessTutBy(_driver, userName);
        }
    }
}
