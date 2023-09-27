namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        // subtract test case
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToSubtract()
        {
            // Act
            double result = _calculator.Subtract(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        // multiply test case
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMultiply()
        {
            // Act
            double result = _calculator.Multiply(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(200));
        }

        // divide test case
        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToDivide()
        {
            // Act
            double result = _calculator.Divide(20, 10);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        // divide with 0 numerator test case
        [Test]
        [TestCase(0, 10)]
        public void Divide_WithZeroNumerator_ResultEqualToZero(double a, double b)
        {
            // Act
            double result = _calculator.Divide(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        // divide with 0 denominator test case
        [Test]
        [TestCase(0, 0, 1)]
        [TestCase(10, 0, null)]
        [TestCase(0, 10, 0)]

        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b, double? ans)
        {
            try
            {
                // Act
                double result = _calculator.Divide(a, b);
                // Assert
                Assert.That(result, Is.EqualTo(ans));
            }
            catch (ArgumentException e)
            {
                Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
            }

        }

        // factorial test case
        [Test]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(5, 120)]
        public void Factorial_WithPositiveInputs_ResultEqualToFactorial(double a, double b)
        {
            // Act
            double result = _calculator.Factorial(a);
            // Assert
            Assert.That(result, Is.EqualTo(b));
        }

        // factorial with negative test case
        [Test]
        [TestCase(-1)]
        [TestCase(-5)]
        public void Factorial_WhenFactorialNegativeNumber_ResultEqualToNaN(double a)
        {
            // Assert
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }

        // factorial with decimal test case
        [Test]
        [TestCase(0.5)]
        [TestCase(1.5)]
        public void Factorial_WhenFactorialDecimalNumber_ResultEqualToNaN(double a)
        {
            // Assert
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }

        // triangle test case
        [Test]
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 0.5)]
        [TestCase(2, 2, 2)]
        public void AreaOfTriangle_WithPositiveInputs_ResultEqualToAreaOfTriangle(double a, double b, double c)
        {
            // Act
            double result = _calculator.AreaOfTriangle(a, b);
            // Assert
            Assert.That(result, Is.EqualTo(c));
        }

        // triangle with negative test case
        [Test]
        [TestCase(-1, 1)]
        [TestCase(1, -1)]
        [TestCase(-1, -1)]
        public void AreaOfTriangle_WithNegativeInputs_ResultThrowArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.AreaOfTriangle(a, b), Throws.ArgumentException);
        }

        // circle test case
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 3.142)]
        [TestCase(2, 12.568)]
        public void AreaOfCircle_WithPositiveInputs_ResultEqualToAreaOfCircle(double a, double b)
        {
            // Act
            double result = _calculator.AreaOfCircle(a);
            // Assert
            Assert.That(result, Is.EqualTo(b));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }

    }
}