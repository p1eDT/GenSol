
namespace GitHome11Test
{
    [TestFixture]
    public class CalculatorDifferenceTest : BaseTest
    {
        [TestCase(2, -4, -6)]
        [TestCase(4, 3, -1)]
        [TestCase(4, 4, 0)]
        public void DifferenceNegativeNumbersTest(double expected, double operand1, double operand2)
        {
            Assert.That(
                calculator.Subtract(operand1, operand2),
                Is.EqualTo(expected));
        }

        [Test, Description("Test Retry and Random"), Retry(9)]
        public void DifferenceWithRandomOperands([Random(-10.0, 10.0, 7)] double operand1,
              [Random(-1.0, 1.0, 5)] double operand2)
        {
            Assert.DoesNotThrow(() => calculator.Subtract(operand1, operand2));
        }

        [Test, Description("Test Range and Values"), Category("Core")]
        public void DifferenceRangeAndValues([Values(1, 2, 3)] double operand1,
                                       [Range(0.2, 0.9, 0.11)] double operand2)
        {
            Assert.Multiple(() =>
            {
                Assert.Less(calculator.Subtract(operand1, operand2), operand1);
                Assert.Greater(calculator.Subtract(operand1, operand2), operand1-1);
            });
        }
    }
}