using System;
using System.Linq;
using Driver;
using DataAccessLayer;
using System.Threading;
using OpenQA.Selenium;
using Exatensions;

namespace Execute
{
    class Program
    {

        static void Main(string[] args)
        {
            var driverNew = LoginToNewApp();

            using (var db = new CompanyContext())
            {
                var companies = db.Company.Where(comp => comp.AprStatus == "Aktivan" 
                                                         && (comp.PhoneNumber != null || comp.Email != null) 
                                                         && comp.NotExist == null)
                                          .OrderByDescending(x => x.NumberOfEmployees);

                foreach (var company in companies)
                {
                    Console.WriteLine(company.CompanyName.Replace('-', ' '));
                    Console.WriteLine("------------------------------------------------------------------");
                    var be = company.CompanyName.StringFilter().Replace('-', ' ');
                    SelectorNew.SearchBox.Element(driverNew).SendKeys(company.CompanyName.StringFilter().Replace('-',' '));
                    ClickWait(driverNew);
                    var existingCompanies = SelectorNew.ExistingCompanies.Elements(driverNew);

                    if (existingCompanies.Count < 1)
                    {
                        using (var updateDb = new CompanyContext())
                        {
                            var res = updateDb.Company.Where(c => c.CompanyID == company.CompanyID).SingleOrDefault();
                            res.NotExist = true;
                            updateDb.SaveChanges();
                        }
                    }
                    else
                    {
                        using (var updateDb = new CompanyContext())
                        {
                            var res = updateDb.Company.Where(c => c.CompanyID == company.CompanyID).SingleOrDefault();
                            res.NotExist = false;
                            updateDb.SaveChanges();
                        }
                    }

                    SelectorNew.SearchBox.Element(driverNew).Clear();
                }
            }
        }

        public static IWebDriver LoginToNewApp()
        {
            Driver.DriverFactroy newDriver = new DriverFactroy(@"C:\sel");
            var driverNew = newDriver.Create();
            driverNew.Navigate().GoToUrl("http://boost-crm.konsera.hr/");

            //------Login to the new database------//
            SelectorNew.UserName.Element(driverNew).SendKeys("petra");
            SelectorNew.Password.Element(driverNew).SendKeys("petra321");
            SelectorNew.LoginButton.Element(driverNew).Click();

            return driverNew;
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
