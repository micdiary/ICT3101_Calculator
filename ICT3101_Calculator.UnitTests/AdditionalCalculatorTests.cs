using Moq;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<FileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<FileReader>();
            _mockFileReader.Setup( fr =>
               fr.Read("MagicNumbers.txt")).Returns(new string[]{"42","-42"});
            _calculator = new Calculator();
        }

        [Test]
        [TestCase(0)]
        [TestCase(1)]
        public void GenMagicNum_PositiveInput_ReturnsMockDouble(double input)
        {
            double result = _calculator.GenMagicNum(input, _mockFileReader.Object);
            Assert.AreEqual(84, result);
        }

        [Test]
        public void GenMagicNum_NegativeInput_ReturnsMockZero()
        {
            double result = _calculator.GenMagicNum(-3, _mockFileReader.Object);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void GenMagicNum_OutOfBoundsInput_ReturnsMockZero()
        {
            double result = _calculator.GenMagicNum(10, _mockFileReader.Object);
            Assert.AreEqual(0, result);
        }

    }
}