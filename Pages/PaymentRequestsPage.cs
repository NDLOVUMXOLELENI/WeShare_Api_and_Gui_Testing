using OpenQA.Selenium;


namespace Pages
{
    public class PaymentRequestsPage
    {
        private static IWebElement requestsSentlink => GaugeSupport.Driver.FindElement(By.Id("paymentrequests_sent"));
        private static IWebElement requestsReceivedlink => GaugeSupport.Driver.FindElement(By.Id("paymentrequests_received"));


        public ResultsPage GotToPaymentRequestsSent()
        {
            requestsSentlink.Click();
            return new ResultsPage();
        }


        public ResultsPage GotToPaymentRequestsReceived()
        {
            requestsReceivedlink.Click();
            return new ResultsPage();
        }
    }
}
