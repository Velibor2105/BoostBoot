using DataAccessLayer;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace OldBoot
{
    public class BusinessLogic
    {
        private IWebDriver _driver;
        private Login _login;
        private List<Company> companies = new List<Company>();

        public BusinessLogic(IWebDriver driver)
        {
            _driver = driver;
            _login = new Login(driver);
        }

        public void Start()
        {
            _driver.Navigate().GoToUrl("http://novisad.protokol.hr/index.php?module=Users&action=Login");
            _login.Start();
        }
    }
}
