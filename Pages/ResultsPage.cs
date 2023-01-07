using FluentAssertions;
using System;
using OpenQA.Selenium;


namespace Pages
{
    public class ResultsPage
    {
        public ResultsPage successfullyLoggedIn(string email)
        {
            var loginResult = GaugeSupport.Driver.FindElement(By.Id("user")).Text;
            loginResult.Equals(email);
            return this;
        }


        public ResultsPage unSuccessfullyLoggedIn()
        {
            var loginResult = GaugeSupport.Driver.FindElement(By.ClassName("message-error")).Text;
            loginResult.Equals("Successfully logged in was unsuccessful. Please correct the errors and try again.");
            return this;
        }


        public ResultsPage OnPaymentRequestsSentPage()
        {
            var paymentRequestsSentResults = GaugeSupport.Driver.FindElement(By.TagName("h2")).Text;
            paymentRequestsSentResults.Should().Be("People that owe me");
            return this;
        }


        public ResultsPage OnPaymentRequestsReceivedPage()
        {
            var paymentRequestsSentResults = GaugeSupport.Driver.FindElement(By.TagName("h2")).Text;
            paymentRequestsSentResults.Should().Be("People that you owe");
            return this;
        }


        public ResultsPage isExpenseAdded()
        {
            var newExpenseResults = GaugeSupport.Driver.FindElement(By.Id("grand_total")).Text;
            (Convert.ToDouble(newExpenseResults.Split(" ")[1])).Should().BeGreaterThan(300);
            return this;
        }


        public ResultsPage isPaymentRequestSent()
        {
            var paymenetSentResults = GaugeSupport.Driver.FindElement(By.TagName("h2")).Text;
            paymenetSentResults.Should().Be("Submit a payment request for the following expense");
            return this;
        }


        public ResultsPage isPaymentRequestReceivedMade()
        {
            var paymenetSentResults = GaugeSupport.Driver.FindElement(By.Id("paid_1")).Text;
            paymenetSentResults.Equals("✅");
            return this;
        }
    }
}
