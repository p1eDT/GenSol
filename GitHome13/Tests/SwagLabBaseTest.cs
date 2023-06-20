using GitHome13.Core;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome13.Tests
{
    internal class SaleforceBaseTest:BaseTest
    {
        [SetUp]
        public void Setup()
        {
            Browser.Instance.NavigateToUrl("https://www.saucedemo.com/");
        }
    }
}
