using SpecFLowCalculator;
using FluentAssertions;

namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly ScenarioContext scenarioContext;
        private readonly Calculator calculator = new Calculator();
        private int result;
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            this.scenarioContext = scenarioContext;
            
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            //throw new PendingStepException();
            calculator.FirstNumber = number;

        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            //throw new PendingStepException();
            calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            //throw new PendingStepException();
            result = calculator.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            //throw new PendingStepException();
            result.Should().Be(result);
        }

		[When(@"the two numbers are subtract")]
		public void WhenTheTwoNumbersAreSubtract()
		{
			result = calculator.Subtract();
		}

		[When(@"the two numbers are multiplication")]
		public void WhenTheTwoNumbersAreMultiplication()
		{
			result = calculator.Multiplication();
		}

		[When(@"the two numbers are division")]
		public void WhenTheTwoNumbersAreDivision()
		{
			result = Convert.ToInt32( calculator.Division());
		}

		[When(@"the two number are residue")]
		public void WhenTheTwoNumberAreResidue()
		{
			result = calculator.Residue();
		}

		[When(@"number is empowermentFirst")]
		public void WhenNumberIsEmpowermentFirst()
		{
            result = calculator.EmpowermentFirstNumber();
		}

		[When(@"number is empowermentSecond")]
		public void WhenNumberIsEmpowermentSecond()
		{
            result = calculator.EmpowermentSecondNumber();
		}


	}
}
