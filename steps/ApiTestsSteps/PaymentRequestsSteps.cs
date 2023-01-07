using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Model;
using NUnit.Framework;


namespace steps
{
    public class paymentRequestsSteps
    {
        private readonly PaymentRequestsApi paymentRequestsApi = new PaymentRequestsApi(StepsHelper.BasePath);

        [Step("Find all payments requests")]
        public void FindAllPaymentRequests() => paymentRequestsApi.FindAllPaymentRequests()
                .Should()
                .NotBeEmpty();


        [Step("Create a new payment request using: <expenseId>, <fromPersonId>, <toPersonId>, <date>, <amount>")]
        public void CreatePaymentRequest(int expenseId, int fromPersonid, int toPersonId, string date, long amount)
        {
            NewPaymentRequestDTO newPaymentRequestDTO = new NewPaymentRequestDTO(expenseId, fromPersonid, toPersonId, date, amount);
            var newPaymentRequest = paymentRequestsApi.CreatePaymentRequest(newPaymentRequestDTO);
            newPaymentRequest.Should().NotBeNull();
        }


        [Step("Find payments requests received empty by a person with id: <personId>")]
        public void FindPaymentRequestsReceivedByPersonEmpty(int personId)
        {
            var paymentRequests = paymentRequestsApi.FindPaymentRequestsReceived(personId);
            paymentRequests.Should().BeEmpty();
        }


        [Step("Find payments requests received not empty by a person with id: <personId>")]
        public void FindPaymentRequestsReceivedByPersonNotEmpty(int personId)
        {
            var paymentRequests = paymentRequestsApi.FindPaymentRequestsReceived(personId);
            paymentRequests.Should().NotBeEmpty();
        }


        [Step("Find payments requests sent empty by a person with id: <personId>")]
        public void FindPaymentRequestsSentByPersonEmpty(int personId)
        {
            var paymentRequests = paymentRequestsApi.FindPaymentRequestsSent(personId);
            paymentRequests.Should().BeEmpty();
        }


        [Step("Find payments requests sent not empty by a person with id: <personId>")]
        public void FindPaymentRequestsSentByPersonNotEmpty(int personId)
        {
            var paymentRequests = paymentRequestsApi.FindPaymentRequestsSent(personId);
            paymentRequests.Should().NotBeEmpty();
        }


        [Step("Get payment request by id: <Id>")]
        public void GetPaymentRequestById(int Id)
        {
            var paymentRequest = paymentRequestsApi.GetPaymentRequestById(Id);
            paymentRequest.Amount.Should().Be(100);
            paymentRequest.ExpenseId.Should().Be(1);
            paymentRequest.Id.Should().Be(1);
            paymentRequest.Paid.Should().BeTrue();
        }


        [Step("Delete payment with payment request id: <paymentRequestId>.")]
        public void DeleteAPaymentRequestById(int paymentRequestId)
        {
            paymentRequestsApi.RecallUnpaidPaymentRequest(paymentRequestId);
            Assert.Throws<Applications.WeShare.Swagger.Client.ApiException>(() => paymentRequestsApi.GetPaymentRequestById(paymentRequestId));
        }
    }
}
