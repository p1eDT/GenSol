using NUnit.Framework;

namespace Bdd.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        [Given("the first number is (.*)")]
        [Given("the second number is (.*)")]
        public void GetNumberIs(int number)
        {
            Console.WriteLine(number);
        }


        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("Added numbers: ");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(result, 120);
        }
    }
}