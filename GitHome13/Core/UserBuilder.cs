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
    }
}
