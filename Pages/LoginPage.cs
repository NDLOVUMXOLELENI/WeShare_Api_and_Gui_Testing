using FluentAssertions;
using OpenQA.Selenium;


namespace Pages
{
    public class LoginPage
    {
        private const string Url = "http://localhost:5050/";
        private static readonly IWebDriver Driver = GaugeSupport.Driver;
        private static IWebElement emailField => Driver.FindElement(By.Id("email"));
        private static IWebElement loginSubmitButton => Driver.FindElement(By.Id("submit"));


        public LoginPage OpenLoginPage()
        {
            Driver.Navigate().GoToUrl(Url);
            var result = GaugeSupport.Driver.FindElement(By.TagName("p")).Text;
            result.Should().Be("You are not logged in!");
            return this;
        }


        public ResultsPage LoginUsingEmail(string email)
        {
            emailField.SendKeys(email);
            loginSubmitButton.Click();
            return new ResultsPage();
        }
    }
}
