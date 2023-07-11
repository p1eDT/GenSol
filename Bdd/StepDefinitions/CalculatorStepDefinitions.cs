using NUnit.Framework;

namespace Bdd.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        public int firstNumber;
        public int secondNumber;

        [Given("the first number is (.*)")]
        public void GetFirstNumber(int number)
        {
            firstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GetSecondNumber(int number)
        {
            secondNumber = number;
        }


        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("Added numbers: ");

        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, firstNumber + secondNumber);
        }

        [Given(@"the following users exist:")]
        public void GivenUsersExist(Table table)
        {
            Console.WriteLine(table.ToString());
        }
    }
}