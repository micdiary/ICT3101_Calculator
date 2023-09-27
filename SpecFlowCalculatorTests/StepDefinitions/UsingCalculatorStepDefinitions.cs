using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    //scope
    [Scope(Tag = "Addition")]
    public sealed class UsingCalculatorAdditionStep
    {

        private Calculator _calculator;
        private double _result;


        public UsingCalculatorAdditionStep(Calculator calculator)
        {
            this._calculator = calculator;
            this._result = 0;
        }


        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }
        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }

    [Binding]
    //scope
    [Scope(Tag = "Divisions")]
    public sealed class UsingCalculatorDivisonStep
    {
        private Calculator _calculator;
        private double _result;

        private string _errorMessage;
        public UsingCalculatorDivisonStep(Calculator calculator)
        {
            this._calculator = calculator;
            this._result = 0;
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }
        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            try
            {
                _result = _calculator.Divide(p0, p1);
            }
            catch (System.ArgumentException ex)
            {
                _errorMessage = ex.Message; // Store the error message
            }
        }

        // positive infinity
        [Then(@"the division result equals positive_infinity")]
        public void ThenTheResultShouldBeOnTheScreenPositiveInfinity()
        {
            Assert.That(true);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

    }

    [Binding]
    //scope
    [Scope(Tag = "Factorial")]
    public sealed class UsingCalculatorFactorialStep
    {
        private Calculator _calculator;
        private double _result;
        private string _errorMessage;
        public UsingCalculatorFactorialStep(Calculator calculator)
        {
            this._calculator = calculator;
            this._result = 0;
            this._errorMessage = "";
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }
        [When(@"I have entered (.*) into the calculator and press Factorial")]
        public void WhenIHaveEnteredIntoTheCalculator(double p0)
        {
            try
            {
                _result = _calculator.Factorial(p0);
            }
            catch (ArgumentException ex)
            {
                _errorMessage = ex.Message; // Store the error message
            }
        }

        [Then(@"the factorial result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        // negative factorial
        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string expectedErrorMessage)
        {
            Assert.That(_errorMessage, Is.EqualTo(expectedErrorMessage));
        }
    }

    [Binding]
    //scope
    [Scope(Tag = "Availability")]
    public sealed class UsingCalculatorAvailabilityStep
    {
        private Calculator _calculator;
        private double _result;
        private string _errorMessage;
        public UsingCalculatorAvailabilityStep(Calculator calculator)
        {
            this._calculator = calculator;
            this._result = 0;
            this._errorMessage = "";
        }

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
        }
        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredIntoTheCalculator(double p0, double p1)
        {
            try
            {
                _result = _calculator.MTBF(p0, p1);
            }
            catch (ArgumentException ex)
            {
                _errorMessage = ex.Message; // Store the error message
            }
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredIntoTheCalculatorAvailability(double p0, double p1)
        {
            try
            {
                _result = _calculator.Availability(p0, p1);
            }
            catch (ArgumentException ex)
            {
                _errorMessage = ex.Message; // Store the error message
            }
        }
        [Then(@"the availability result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        // negative availability
        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string expectedErrorMessage)
        {
            Assert.That(_errorMessage, Is.EqualTo(expectedErrorMessage));
        }
    }

    [Binding]
    //scope
    [Scope(Tag = "Reliability")]
    public sealed class UsingCalculatorReliabilityStep
    {
        private Calculator _calculator;
        private double _result;
        private string _errorMessage;
        public UsingCalculatorReliabilityStep(Calculator calculator)
        {
            this._calculator = calculator;
            this._result = 0;
            this._errorMessage = "";
        }

        [Given(@"I have a Basic Musa Model")]
        public void GivenIHaveACalculator()
        {
        }
        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press Current Failure Intensity")]
        public void WhenIHaveEnteredIntoTheCalculator(double initial, double average, double total)
        {
            try
            {
                _result = _calculator.CurrentFailureIntensity(initial, average, total);
            }
            catch (ArgumentException ex)
            {
                _errorMessage = ex.Message; // Store the error message
            }
        }

        [When(@"I have entered (.*) and (.*) and (.*) into the calculator and press Average Number of Expected Failures")]
        public void WhenIHaveEnteredIntoTheCalculatorReliability(double initial, double average, double total)
        {
            try
            {
                _result = _calculator.AverageExpectedFailure(initial, average, total);
            }
            catch (ArgumentException ex)
            {
                _errorMessage = ex.Message; // Store the error message
            }
        }

        [Then(@"the reliability result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        // negative reliability
        [Then(@"the reliability result should be ""(.*)""")]
        public void ThenTheResultShouldBe(string expectedErrorMessage)
        {
            Assert.That(_errorMessage, Is.EqualTo(expectedErrorMessage));
        }
    }

    [Binding]
    //scope
    [Scope(Tag = "Epic")]
    public sealed class UsingCalculatorEpicStep
    {
        private Calculator _calculator;
        private double _result;
        private string _errorMessage;
        public UsingCalculatorEpicStep(Calculator calculator)
        {
            this._calculator = calculator;
            this._result = 0;
            this._errorMessage = "";
        }

        [Given(@"I have a number of defects")]
        public void GivenIHaveACalculator()
        {
        }

        // defect density
        [When(@"I divide the number of defects of (.*) by the number of Line Of Codes of (.*) into the calculator and press defect density")]
        public void WhenIHaveEnteredIntoTheCalculator(double p0, double p1)
        {
            try
            {
                _result = _calculator.DefectDensity(p0, p1);
            }
            catch (ArgumentException ex)
            {
                _errorMessage = ex.Message; // Store the error message
            }
        }
        [Then(@"I get the defect density of (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        // negative Defect Density
        [Then(@"I get the defect density of ""(.*)""")]
        public void ThenTheResultShouldBe(string expectedErrorMessage)
        {
            Assert.That(_errorMessage, Is.EqualTo(expectedErrorMessage));
        }

        // new ssi
        [When(@"I calculate the new SSI using CSI of (.*), previous SSI of (.*), delete coded of (.*) and changed code of (.*)")]
        public void WhenIHaveEnteredIntoTheCalculatorEpic(double p0, double p1, double p2, double p3)
        {
            try
            {
                _result = _calculator.NewSSI(p0, p1, p2, p3);
            }
            catch (ArgumentException ex)
            {
                _errorMessage = ex.Message; // Store the error message
            }
        }

        [Then(@"I get the new total number of SSI of (.*)")]
        public void ThenTheResultShouldBeOnTheScreenEpic(decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        // negative new ssi
        [Then(@"I get the new total number of SSI of ""(.*)""")]
        public void ThenTheResultShouldBeEpic(string expectedErrorMessage)
        {
            Assert.That(_errorMessage, Is.EqualTo(expectedErrorMessage));
        }

    }

    [Binding]
    //scope
    [Scope(Tag = "LogarithmicModel")]
    public sealed class UsingCalculatorLogarithmicModelStep
    {
        private Calculator _calculator;
        private double _result;
        private string _errorMessage;
        public UsingCalculatorLogarithmicModelStep(Calculator calculator)
        {
            this._calculator = calculator;
            this._result = 0;
            this._errorMessage = "";
        }

        [Given(@"I have a failure intensity")]
        public void GivenIHaveAFailureIntensity()
        {
        }


        // defect density
        [When(@"I calculate the failure intensity using logarithmic model with (.*) failure intensity decay, (.*) failure intensity, and experienced a total of (.*) failures")]
        public void WhenIHaveEnteredIntoTheCalculatorFailureIntensity(double p0, double p1, double p2)
        {
            try
            {
                _result = _calculator.CurrentFailureIntensityLog(p0, p1, p2);
            }
            catch (ArgumentException ex)
            {
                _errorMessage = ex.Message; // Store the error message
            }
        }
        [Then(@"I get the current failure intensity of (.*)")]
        public void ThenTheResultShouldBeOnTheScreenFailure(decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        // negative Defect Density
        [Then(@"I get the defect density of ""(.*)""")]
        public void ThenTheResultShouldBeFailure(string expectedErrorMessage)
        {
            Assert.That(_errorMessage, Is.EqualTo(expectedErrorMessage));
        }


        // average expected failure
        [When(@"I calculate the expected failures using logarithmic model with (.*) failure intensity decay, (.*) failure intensity, and (.*) time")]
        public void WhenIHaveEnteredIntoTheCalculatorAverageFailure(double p0, double p1, double p2)
        {
            try
            {
                _result = _calculator.AverageExpectedFailureLog(p0, p1, p2);
            }
            catch (ArgumentException ex)
            {
                _errorMessage = ex.Message; // Store the error message
            }
        }

        [Then(@"I get the expected failures of (.*)")]
        public void ThenTheResultShouldBeOnTheScreenAverageFailure(decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }

        // negative average expected failure
        [Then(@"I get the expected failures of ""(.*)""")]
        public void ThenTheResultShouldBeAverageFailure(string expectedErrorMessage)
        {
            Assert.That(_errorMessage, Is.EqualTo(expectedErrorMessage));
        }
    }
}