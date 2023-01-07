using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Model;


namespace steps
{
    public class ExpensesSteps
    {
        private ExpenseDTO expenses;
        private readonly ExpensesApi expensesApi = new ExpensesApi(StepsHelper.BasePath);

        [Step("Get an expense with id <expenseId>")]
        public void GetExpense(int expenseId)
        {
            expenses = expensesApi.FindExpenseById(expenseId);
            expenses.Should().NotBeNull();
            expenses.ExpenseId.Equals(1);
        }


        [Step("Get expense with personId <personId>")]
        public void GetExpenseWithPersonId(int personId)
        {
            var expenses = expensesApi.FindExpensesByPerson(personId);
            expenses.Should().NotBeNull();
            expenses[0].PersonId.Equals(personId);
        }


        [Step("Get all expenses")]
        public void GetAllExpenses()
        {
            var expenses = expensesApi.FindAllExpenses();
            expenses.Should().NotBeNull();
            expenses[0].ExpenseId.Equals(1);
        }


        [Step("Create a new expense with <personId>, <date>, <description>, <amount>")]
        public void CreateANewExpense(int personId, string date, string description, long amount)
        {
            NewExpenseDTO newExpenseDTO = new NewExpenseDTO(personId, date, description, amount);

            var expenses = expensesApi.CreateExpense(newExpenseDTO);
            expenses.Should().NotBeNull();
            expenses.PersonId.Equals(personId);
        }
    }
}
