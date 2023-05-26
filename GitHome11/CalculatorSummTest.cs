namespace GitHome11Test
{
    [TestFixture]
    public class CalculatorSummTest:BaseTest
    {
        [Description("Summ Negative Numbers Test")]
        [TestCase(4, 0, 4)]
        [TestCase(4, -1, 5)]
        [TestCase(4, -4, 8)]
        public void SummNegativeNumbersTest(double expected, double operand1, double operand2)
        {
            Assert.AreEqual(calculator.Add(operand1, operand2),expected);
        }

        [Test, Description("Test Retry and Random"), Retry(5)]
        public void SummRetryWithRandomOperands([Random(-10.0, 10.0, 5)] double operand1,
                              [Random(-1.0, 1.0, 5)] double operand2)
        {
            Assert.DoesNotThrow(()=>calculator.Add(operand1, operand2));
        }

        [Test, Description("Summ Range and Values"), Category("Core")]
        public void SummRangeAndValues([Values(1, 2, 3)] double operand1,
                                       [Range(0.2, 0.9, 0.11)] double operand2)
        {
            Assert.Multiple(() =>
            {
                Assert.Less(calculator.Add(operand1, operand2), operand1 + 1);
                Assert.Greater(calculator.Add(operand1, operand2), operand1);
            });
        }
    }
}