using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Model;


namespace steps
{
    public class PaymentsSteps
    {
        private readonly PaymentsApi paymentsApi = new PaymentsApi(StepsHelper.BasePath);

        [Step("Pay a payment request <expenseId>, <paymentRequestId>, <payingPersonId>")]
        public void PayPayment(int expenseId, int paymentRequestId, int payingPersonId)
        {
            NewPaymentDTO newPayment = new NewPaymentDTO(expenseId, paymentRequestId, payingPersonId);
            var payPayment = paymentsApi.PayPaymentRequest(newPayment);
            payPayment.PayingPersonId.Should().Be(payingPersonId);
            payPayment.PaymentRequestId.Should().Be(paymentRequestId);
        }


        [Step("Find payments made by a person with personId, <personId> empty")]
        public void FindPaymentsMadeByPersonEmpty(int personId)
        {
            var payPayment = paymentsApi.FindPaymentsMadeByPerson(personId);
            payPayment.Should().BeEmpty();
        }


        [Step("Find payments made by a person with personId, <personId> not empty")]
        public void FindPaymentsMadeByPersonNotEmpty(int personId)
        {
            var payPayment = paymentsApi.FindPaymentsMadeByPerson(personId);
            payPayment.Should().NotBeEmpty();
        }

    }
}
