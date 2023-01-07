using OpenQA.Selenium;

namespace Pages
{
    public class ExpensePage
    {
        private static readonly IWebDriver Driver = GaugeSupport.Driver;
        public static IWebElement totalBefore() => Driver.FindElement(By.Id("grand_total"));

        private static IWebElement addNewexpenselink => Driver.FindElement(By.Id("add_expense"));
        private static IWebElement descriptionField => Driver.FindElement(By.Id("description"));
        private static IWebElement dateField => Driver.FindElement(By.Id("date"));
        private static IWebElement amountField => Driver.FindElement(By.Id("amount"));
        private static IWebElement submitExpense => Driver.FindElement(By.Id("submit"));


        public ResultsPage AddNewExpense(string description, string date, string amount)
        {
            addNewexpenselink.Click();
            descriptionField.SendKeys(description);
            dateField.SendKeys(date);
            amountField.SendKeys(amount);
            submitExpense.Click();
            return new ResultsPage();
        }
    }
}
