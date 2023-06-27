using _Core;
using GitHome13.Core;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tests.TestsSwaglab
{
    public class SaleforceBaseTest : BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Browser.Instance.NavigateToUrl("https://www.saucedemo.com/");
        }
    }
}
