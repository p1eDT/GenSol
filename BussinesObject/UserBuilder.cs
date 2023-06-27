using Bogus;
using NUnit.Framework;
using SeleniumTests.SwagLabs;

namespace GitHome13.Core
{
    public class UserBuilder
    {
        public static UserModel GetStandartUser()
        {
            return new UserModel
            (
                name: TestContext.Parameters.Get("StandartUserName"),
                password: TestContext.Parameters.Get("StandartUserPassword")
            );
        }

        public static UserModel GetSalesforceUser()
        {
            return new UserModel
            (
                name: TestContext.Parameters.Get("SalesforceUserName"),
                password: TestContext.Parameters.Get("SalesforceUserPassword")
            );
        }

        public static UserModel GetFakerUser()
        {
            Faker faker = new Faker();
            return new UserModel
            (
                name: faker.Name.FirstName(),
                password: faker.Internet.Password()
            );
        }
    }
}
