using System;
using Gauge.CSharp.Lib.Attribute;


namespace Pages
{
    public class SendPaymentRequestJourney
    {
        private readonly SendPaymentRequestPage sendPaymentRequestPage = new SendPaymentRequestPage();
        [Step("Send a payment request: <email>, <amount>, <due_date>")]
        public void SendPaymentRequest(string email, string amount, string due_date)
        {
            var sentPaymentRequestResults = sendPaymentRequestPage.SubmitPaymentRequest(email, amount, due_date);
            sentPaymentRequestResults.isPaymentRequestSent();
        }
    }
}
