using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Driver.Contracts
{
    public interface IFactory
    {
        IWebDriver Create();
    }
}
