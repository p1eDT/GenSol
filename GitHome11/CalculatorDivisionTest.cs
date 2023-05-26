
namespace GitHome11Test
{
    [TestFixture]
    public class CalculatorDivisionTest : BaseTest
    {
        [TestCase(2, -12, -6)]
        [TestCase(-4, 4, -1)]
        [TestCase(0, 0, 4)]
        public void DivisionNegativeNumbersTest(double expected, double operand1, double operand2)
        {
            Assert.That(
                calculator.Divide(operand1, operand2),
                Is.EqualTo(expected));
        }

        [Test, Description("Test Retry and Random"), Retry(5)]
        public void DivisionWithRandomOperands([Random(-10.0, 10.0, 5)] double operand1,
              [Random(-1.0, 1.0, 5)] double operand2)
        {
            Assert.DoesNotThrow(() => calculator.Divide(operand1, operand2));
        }

        [Test, Description("Test Range and Values"), Category("Core")]
        public void DivisionRangeAndValues([Values(1, 2, 3)] double operand1,
                                       [Range(-0.2, 0.9, 0.11)] double operand2)
        {
            Assert.Multiple(() =>
            {
                Assert.DoesNotThrow(() => calculator.Divide(operand1, 0));
                Assert.Greater(Math.Abs(calculator.Divide(operand1, operand2)), operand1);
            });
        }
    }
}