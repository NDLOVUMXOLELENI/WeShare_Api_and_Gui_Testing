using Gauge.CSharp.Lib.Attribute;
using Pages;

namespace Steps
{
    public class PaymentRequestsJourney
    {
        private readonly LoginPage loginPage = new LoginPage();

        private readonly PaymentRequestsPage paymentRequestSentPage = new PaymentRequestsPage();


        [Step("Click payment requests sent link.")]
        public void ClickOnPaymentRequestsSent()
        {
            var paymentRequestsSentResults = paymentRequestSentPage.GotToPaymentRequestsSent();
            paymentRequestsSentResults.OnPaymentRequestsSentPage();
        }


        [Step("Click payment requests received link.")]
        public void ClickOnPaymentRequestsReceived()
        {
            var paymentRequestsSentResults = paymentRequestSentPage.GotToPaymentRequestsReceived();
            paymentRequestsSentResults.OnPaymentRequestsReceivedPage();
        }

    }
}
