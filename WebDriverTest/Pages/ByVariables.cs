using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverTest.Pages
{
    class ByVariables
    {
        private By CssSelector = By.CssSelector("input[name = 'str']");
        private By Id = By.Id("search_from_str");
        private By ClassName = By.ClassName("topbar__li b-topbar-aside");
        private By LinkText = By.LinkText("Каталог цен");
        private By PartialLinkText = By.PartialLinkText("Каталог");
        private By Name = By.Name("search");
        private By TagName = By.TagName("h1");
        private By TagNameTwo = By.TagName("h1");
    }
}
