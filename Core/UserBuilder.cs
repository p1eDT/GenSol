using Bogus;
using SeleniumTests.SwagLabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
