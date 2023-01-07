using Gauge.CSharp.Lib.Attribute;
using Pages;

namespace Steps
{
    public class LoginPageJourney
    {
        private readonly LoginPage loginPage = new LoginPage();


        [Step("Open Login page for WeShare")]
        public void GoToLoginPage() => loginPage.OpenLoginPage();


        [Step("Login using email: <email>.")]
        public void EnterEmailAndLogin(string email)
        {
            var loginResults = loginPage.LoginUsingEmail(email);
            loginResults.successfullyLoggedIn(email);
        }
    }
}
