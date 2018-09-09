using Driver.Contracts;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Driver
{
    public class DriverFactroy : IFactory
    {
        private readonly string _driverPath;
        private readonly ChromeOptions _options;

        public DriverFactroy(string driverPath)
        {
            _driverPath = driverPath;
            _options = new ChromeOptions();
            _options.AddArguments("--start-maximized");
        }

        public IWebDriver Create()
        {
            return new ChromeDriver(_driverPath, _options);
        }
    }
}
