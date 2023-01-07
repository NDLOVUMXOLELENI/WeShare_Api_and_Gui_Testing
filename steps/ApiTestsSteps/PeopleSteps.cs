using FluentAssertions;
using Gauge.CSharp.Lib.Attribute;
using Applications.WeShare.Swagger.Api;
using Applications.WeShare.Swagger.Model;


namespace steps
{
    public class PeopleSteps
    {
        private readonly PeopleApi peopleApi = new PeopleApi(StepsHelper.BasePath);

        [Step("Login to WeShare with email <email>")]
        public void LoginTOWeShare(string email)
        {
            LoginDTO loginDTO = new LoginDTO(email);
            var loginResponse = peopleApi.Login(loginDTO);
            loginResponse.Email.Should().Be(email);
        }


        [Step("Find person by id, <personId>")]
        public void FindPersonById(int personId)
        {
            var person = peopleApi.FindPersonById(personId);
            person.Email.Should().Be("student1@wethinkcode.co.za");
        }
    }
}
