using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Driver;

namespace OldBoot
{
    class Login
    {
        private IWebDriver _driver;

        public Login(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Start()
        {
            Selector.UserName.Element(_driver).SendKeys("danijela");
            Selector.Password.Element(_driver).SendKeys("danijela123");
            Selector.LoginButton.Element(_driver).Click();
        }
    }
}
