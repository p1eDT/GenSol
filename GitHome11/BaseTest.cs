using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHome11Test
{
    [TestFixture]
    public class BaseTest
    {
        public Calculator calculator;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            calculator = new Calculator();
            Console.WriteLine("-OneTimeSetUp");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("--SetUp");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("--TearDown");
        }

        [OneTimeTearDown]
        public void OneTImeTearDown()
        {
            Console.WriteLine("-OneTimeTearDown");
        }
    }
}