using DataAccessLayer;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Driver;
using Exatensions;
using System.Threading;

namespace NewBoot
{
    public class BussinesLogic
    {

        private IWebDriver _driver;
        private Login _login;
        private List<Company> companies = new List<Company>();

        public BussinesLogic(IWebDriver driver)
        {
            _driver = driver;
            _login = new Login(driver);
        }

        public void Start()
        {
            _driver.Navigate().GoToUrl("http://boost-crm.konsera.hr/");
            _login.Start();

            using (var db = new CompanyContext())
            {
                var companies = db.Company.OrderByDescending(x => x.NumberOfEmployees).Skip(0).Take(100);
                foreach (var company in companies)
                {
                    Selector.SearchBox.Element(_driver).SendKeys(company.CompanyName.StringFilter());
                    ClickWait(_driver);
                    var existingCompanies = Selector.ExistingCompanies.Elements(_driver);

                    if (existingCompanies.Count < 1)
                        Console.WriteLine(company.CompanyName);

                    Selector.SearchBox.Element(_driver).Clear();
                }
            }

            
        }

        public static void ClickWait(IWebDriver driver)
        {
            try
            {
                driver.FindElement(By.CssSelector("div.desktop-bar > ul > li:nth-child(3) > form > div > span > button")).Click();
            }
            catch (Exception)
            {
                Thread.Sleep(10000);
                Console.WriteLine("excption");
                ClickWait(driver);
            }
        }
    }
}
