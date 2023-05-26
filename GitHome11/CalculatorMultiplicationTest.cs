
namespace GitHome11Test
{
    [TestFixture]
    public class CalculatorMultiplicationTest : BaseTest
    {
        [TestCase(12, -2, -6)]
        [TestCase(-4, 8, -0.5)]
        [TestCase(0, -4, 0)]
        public void MultiplicationNegativeNumbersTest(double expected, double operand1, double operand2)
        {
            Assert.That(
                calculator.Multiply(operand1, operand2),
                Is.EqualTo(expected));
        }

        [Test, Description("Test Retry and Random"), Retry(5)]
        public void MultiplicationWithRandomOperands([Random(-10.0, 10.0, 5)] double operand1,
                      [Random(-1.0, 1.0, 5)] double operand2)
        {
            Assert.DoesNotThrow(() => calculator.Multiply(operand1, operand2));
        }

        [Test, Description("Test Range and Values"), Category("Core")]
        public void MultiplicationRangeAndValues([Values(1, 2, 3)] double operand1,
                                       [Range(0.2, 0.9, 0.11)] double operand2)
        {
            Assert.Multiple(() =>
            {
                Assert.Less(calculator.Multiply(operand1, operand2), operand1);
                Assert.GreaterOrEqual(calculator.Multiply(operand1, operand2), operand2);
            });
        }
    }
}