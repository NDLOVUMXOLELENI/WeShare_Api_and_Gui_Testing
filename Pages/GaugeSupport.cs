using System;
using Gauge.CSharp.Lib.Attribute;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Pages
{
    public class GaugeSupport
    {
        private static IWebDriver _driver;

        public static IWebDriver Driver
        {
            get => _driver;
            private set => _driver = value;
        }


        [BeforeSuite]
        public void BeforeSpec()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }


        [AfterSuite]
        public void AfterSpec()
        {
            _driver.Close();
            _driver.Quit();
        }
    }
}
