using TechTalk.SpecFlow;
using NUnit.Framework;
using SpecFlowTests.Contexts;

namespace SpecFlowTests.Steps
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        private readonly CalculatorContext _calculatorContext;

        public CalculatorStepDefinitions(CalculatorContext calculatorContext)
        {
            _calculatorContext = calculatorContext;
        }

        [Given("the first number is (.*)")]
        public void GivenFirstNumberIs(int firstNumber)
        {
            _calculatorContext.FirstNumber = firstNumber;
        }

        [Given("the second number is (.*)")]
        public void GivenSecondNumberIs(int secondNumber)
        {
            _calculatorContext.SecondNumber = secondNumber;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _calculatorContext.Result = _calculatorContext.FirstNumber + _calculatorContext.SecondNumber;
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _calculatorContext.Result = _calculatorContext.FirstNumber - _calculatorContext.SecondNumber;
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _calculatorContext.Result = _calculatorContext.FirstNumber * _calculatorContext.SecondNumber;
        }

        [When("the first number is divided by the second number")]
        public void WhenTheFirstNumberIsDividedByTheSecondNumber()
        {
            _calculatorContext.Result = _calculatorContext.FirstNumber / _calculatorContext.SecondNumber;
        }

        [Then("the result should be (.*)")]
        public void ThenResultShouldBe(int expectedResult)
        {
            Assert.AreEqual(expectedResult, _calculatorContext.Result);
        }
    }
}
