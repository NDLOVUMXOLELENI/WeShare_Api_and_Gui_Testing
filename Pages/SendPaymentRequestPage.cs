using OpenQA.Selenium;


namespace Pages
{
    public class SendPaymentRequestPage
    {
        private static readonly IWebDriver Driver = GaugeSupport.Driver;
        private static IWebElement clickOnExpense => Driver.FindElement(By.Id("payment_request_1"));
        private static IWebElement emailField => Driver.FindElement(By.Id("email"));
        private static IWebElement amountField => Driver.FindElement(By.Id("amount"));
        private static IWebElement dueDateField => Driver.FindElement(By.Id("due_date"));
        private static IWebElement submitPaymentRequest => Driver.FindElement(By.Id("submit"));


        public ResultsPage SubmitPaymentRequest(string email, string amount, string due_date)
        {
            clickOnExpense.Click();
            emailField.SendKeys(email);
            amountField.SendKeys(amount);
            dueDateField.SendKeys(due_date);
            submitPaymentRequest.Click();
            return new ResultsPage();
        }
    }
}
