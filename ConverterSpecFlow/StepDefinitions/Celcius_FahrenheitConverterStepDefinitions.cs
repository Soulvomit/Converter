using System;
using TechTalk.SpecFlow;

namespace ConverterSpecFlow.StepDefinitions
{
    [Binding]
    public class Celcius_FahrenheitConverterStepDefinitions
    {
        [Given(@"celsius input is (.*)")]
        public void GivenCelsiusInputIs(Decimal p0)
        {
            Assert.IsTrue((float)p0 == 50.00f);
            //Assert.Fail();
            //throw new PendingStepException()
        }

        [When(@"toFahrenhiet button is pressed")]
        public void WhenToFahrenhietButtonIsPressed()
        {
            Assert.IsTrue(true);
            //Assert.Fail();
            //throw new PendingStepException();
        }

        [Then(@"fahrenhiet output should be (.*)")]
        public void ThenFahrenhietOutputShouldBe(Decimal p0)
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToFahrenheit(50);

            if (f != null)
                Assert.IsTrue((float)Math.Round(p0, 3, MidpointRounding.ToZero) == (float)Math.Round((decimal)f, 3, MidpointRounding.ToZero));
            else
                Assert.Fail();
            //throw new PendingStepException();
        }

        [Given(@"celsius input is below absolute zero in fahrenheit")]
        public void GivenCelsiusInputIsBelowAbsoluteZeroInFahrenheit()
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToFahrenheit(-10000);

            if (f != null)
                Assert.IsTrue((float)f > -15000.0f);
            else
                Assert.Fail();
            //throw new PendingStepException();
        }

        [Then(@"fahrenheit output should be absolute zero")]
        public void ThenFahrenheitOutputShouldBeAbsoluteZero()
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToFahrenheit(-10000);

            if (f != null)
                Assert.IsTrue((float)f == -459.67f);
            else
                Assert.Fail();
            //throw new PendingStepException();
        }

        [Given(@"celsius input is invalid number")]
        public void GivenCelsiusInputIsInvalidNumber()
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToNumeric("sjsj");
            if (f != null)
                Assert.Fail();
            //throw new PendingStepException();
        }

        [Given(@"fahrenhiet output or celsius input is above a floats max value")]
        public void GivenFahrenhietOutputOrCelsiusInputIsAboveAFloatsMaxValue()
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToFahrenheit((float)c.ToNumeric("123412341234123412341234123412341234123412341234123412341234123412341234.123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234"));
            if (f != float.MaxValue)
                Assert.Fail();
            //throw new PendingStepException();
        }

        [Given(@"fahrenhiet output or celsius input is below a floats min value")]
        public void GivenFahrenhietOutputOrCelsiusInputIsBelowAFloatsMinValue()
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToFahrenheit((float)c.ToNumeric("-123412341234123412341234123412341234123412341234123412341234123412341234.123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234"));
            if (f != -459.67f)
                Assert.Fail();
            //throw new PendingStepException();
        }
    }
}
