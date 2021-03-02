using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using WebDriverTest.Pages;

namespace WebDriverTest
{
    [TestClass()]
    public class WebDriverTests
    {
        const string userNameTutBY = "CAutomation";
        const string passWordTutBy = "IUbj^hg75H";
        IWebDriver _driver = new ChromeDriver();

        [TestMethod()]

        public void LoginTutBy()
        {
            TutByLogIn tutByLogIn = new TutByLogIn(_driver);
            LoginProcessTutBy loginProcessTutBy = tutByLogIn.Login(userNameTutBY, passWordTutBy);
            Assert.IsTrue(loginProcessTutBy.IsFound());
            _driver.Close();
        }
    }
}
