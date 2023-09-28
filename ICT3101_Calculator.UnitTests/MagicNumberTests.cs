namespace ICT3101_Calculator.UnitTests
{
    public class MagicNumbersTests
    {
        private Calculator _calculator;
        private FileReader _fileReader;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
            _fileReader = new FileReader();
        }

        [Test]
        // magic number test case
        public void GenMagicNum_PositiveInput_ReturnsDouble()
        {
            double result = _calculator.GenMagicNum(2, _fileReader);
            Assert.AreEqual(60, result);
        }

        [Test]
        public void GenMagicNum_NegativeInput_ReturnsZero()
        {
            double result = _calculator.GenMagicNum(-3, _fileReader);
            Assert.AreEqual(0, result);
        }

        [Test]
        public void GenMagicNum_OutOfBoundsInput_ReturnsZero()
        {
            double result = _calculator.GenMagicNum(10, _fileReader);
            Assert.AreEqual(0, result);
        }
    }
}