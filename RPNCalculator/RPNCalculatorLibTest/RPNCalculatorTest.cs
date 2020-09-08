using NUnit.Framework;

namespace TekTutor
{
    public class RPNCalculatorTest
    {
        private RPNCalculator rpnCalculator;
        private double actualResult, expectedResult;

        [SetUp]
        public void Setup()
        {
            rpnCalculator = new RPNCalculator();
        }

        [Test]
        public void TestSimpleAddition()
        {
            actualResult = rpnCalculator.evaluate("10 15 +");
            expectedResult = 25.0;
            Assert.AreEqual(expectedResult, actualResult, 0.001);

            actualResult = rpnCalculator.evaluate("10 115 +");
            expectedResult = 125.0;
            Assert.AreEqual(expectedResult, actualResult, 0.001);

        }

        [Test]
        public void TestSimpleSubtraction()
        {
            actualResult = rpnCalculator.evaluate("100 15 -");
            expectedResult = 85.0;
            Assert.AreEqual(expectedResult, actualResult, 0.001);

            actualResult = rpnCalculator.evaluate("10.0 5.0 -");
            expectedResult = 5.0;
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [Test]
        public void TestSimpleMultiplication()
        {
            actualResult = rpnCalculator.evaluate("100 15 *");
            expectedResult = 1500.0;
            Assert.AreEqual(expectedResult, actualResult, 0.001);

            actualResult = rpnCalculator.evaluate("10.0 5.0 *");
            expectedResult = 50.0;
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [Test]
        public void TestSimpleDivision()
        {
            actualResult = rpnCalculator.evaluate("100 25 /");
            expectedResult = 4.0;
            Assert.AreEqual(expectedResult, actualResult, 0.001);

            actualResult = rpnCalculator.evaluate("10.0 5.0 /");
            expectedResult = 2.0;
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

        [Test]
        public void TestComplexRPNMathExpression()
        {
            actualResult = rpnCalculator.evaluate("100 20 / 80.0 50.0 - +");
            expectedResult = 35.0;
            Assert.AreEqual(expectedResult, actualResult, 0.001);
        }

    }
}