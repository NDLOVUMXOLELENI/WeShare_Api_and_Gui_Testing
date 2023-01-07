using System;
using Gauge.CSharp.Lib.Attribute;


namespace Pages
{
    public class PayPaymentRequestReceivedJourney
    {
        private readonly PayPaymentRequestReceivedPage payPaymentRequestReceivedPage = new PayPaymentRequestReceivedPage();
        [Step("Pay a payment request received.")]
        public void PayAPaymentRequestReceived()
        {
            var payPaymentRequestReceivedResults = payPaymentRequestReceivedPage.MakeAPaymentRequestReceived();
            payPaymentRequestReceivedResults.isPaymentRequestReceivedMade();
        }
    }
}
