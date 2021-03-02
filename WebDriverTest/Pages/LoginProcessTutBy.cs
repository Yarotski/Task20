using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverTest.Pages
{
    class LoginProcessTutBy
    {
        protected IWebDriver _driver;
        private string _userName;
        By loggedInUserName = By.XPath("//*[@id='authorize']/div[2]/a/span[2]");

        public LoginProcessTutBy(IWebDriver driver, string userName)
        {
            _driver = driver;
            _userName = userName;
        }

        public bool IsFound()
        {
            string UserNameText = _driver.FindElement(loggedInUserName).Text;
            return UserNameText.Contains(_userName);
        }
    }
}
