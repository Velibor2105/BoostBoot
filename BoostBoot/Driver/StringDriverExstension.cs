using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Driver
{
    public static class StringDriverExstension
    {
        public static IWebElement Element(this String element,IWebDriver driver)
                                  => driver.FindElement(By.CssSelector(element));
        
        public static ReadOnlyCollection<IWebElement> Elements(this String element, IWebDriver driver)
                                  => driver.FindElements(By.CssSelector(element));
    }
}
