using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BaigiamasisDarbas.Drivers
{
    public static class CustomDrivers
    {
        public static IWebDriver GetChromeDriver()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return driver;
        }

    }
}
