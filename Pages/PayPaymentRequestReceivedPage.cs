using OpenQA.Selenium;


namespace Pages
{
    public class PayPaymentRequestReceivedPage
    {
        private static readonly IWebDriver Driver = GaugeSupport.Driver;
        private static IWebElement clickPaymentRequestsReceived => Driver.FindElement(By.Id("paymentrequests_received"));
        private static IWebElement clickPayButton => Driver.FindElement(By.Id("submit"));


        public ResultsPage MakeAPaymentRequestReceived()
        {
            clickPaymentRequestsReceived.Click();
            clickPayButton.Click();
            return new ResultsPage();
        }
    }
}
