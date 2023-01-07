using Gauge.CSharp.Lib.Attribute;


namespace Pages
{
    public class ExpenseJoruney
    {
        private readonly ExpensePage expensePage = new ExpensePage();
        [Step("Click add expense and enter expense details: <description>, <date>, <amount>.")]
        public void AddExpense(string description, string date, string amount)
        {
            // var totalBefore = ExpensePage.totalBefore();
            var newExpenseResults = expensePage.AddNewExpense(description, date, amount);
            newExpenseResults.isExpenseAdded();
            // newExpenseResults.isExpenseAdded((Convert.ToDouble(totalBefore.Text.Split(" ")[1])));
        }
    }
}
