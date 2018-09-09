using System;
using System.Collections.Generic;
using System.Text;
using Driver;
using OpenQA.Selenium;

namespace NewBoot
{
   public class Login
   {
        private IWebDriver _driver;

        public Login(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Start()
        {
            Selector.UserName.Element(_driver).SendKeys("petra");
            Selector.Password.Element(_driver).SendKeys("petra321");
            Selector.LoginButton.Element(_driver).Click();
        }
   }
}
