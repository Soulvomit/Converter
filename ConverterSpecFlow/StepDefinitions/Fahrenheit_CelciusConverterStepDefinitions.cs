using System;
using TechTalk.SpecFlow;

namespace ConverterSpecFlow.StepDefinitions
{
    [Binding]
    public class Fahrenheit_CelciusConverterStepDefinitions
    {
        [Given(@"fahrenhiet input is (.*)")]
        public void GivenFahrenhietInputIs(Decimal p0)
        {
            Assert.IsTrue((float)p0 == 50.00f);
            //Assert.Fail();
            //throw new PendingStepException();
        }

        [When(@"toCelsius button is pressed")]
        public void WhenToCelsiusButtonIsPressed()
        {
            Assert.IsTrue(true);
            //Assert.Fail();
            //throw new PendingStepException();
        }

        [Then(@"celsius output should be (.*)")]
        public void ThenCelsiusOutputShouldBe(Decimal p0)
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToCelsius(50);

            if (f != null)
                Assert.IsTrue((float)Math.Round(p0, 3, MidpointRounding.ToZero) == (float)Math.Round((decimal)f, 3, MidpointRounding.ToZero));
            else
                Assert.Fail();
            //throw new PendingStepException();
        }

        [Given(@"fahrenhiet input is below absolute zero in celsius")]
        public void GivenFahrenhietInputIsBelowAbsoluteZeroInCelsius()
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToCelsius(-10000);

            if (f != null)
                Assert.IsTrue((float)f > -5000.0f);
            else
                Assert.Fail();
            //throw new PendingStepException();
        }

        [Then(@"celsius output should be absolute zero")]
        public void ThenCelsiusOutputShouldBeAbsoluteZero()
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToCelsius(-10000);

            if (f != null)
                Assert.IsTrue((float)f == -273.15f);
            else
                Assert.Fail();
            //throw new PendingStepException();
        }

        [Given(@"fahrenhiet input is invalid number")]
        public void GivenFahrenhietInputIsInvalidNumber()
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToNumeric("sjsj");
            if (f != null)
                Assert.Fail();
            //throw new PendingStepException();
        }

        [Then(@"write an invalid number error message")]
        public void ThenWriteAnInvalidNumberErrorMessage()
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToNumeric("1234");
            if (f != null)
                Assert.IsTrue(f == 1234.00f);
            else
                Assert.Fail();
            //throw new PendingStepException();
        }

        [Given(@"celsius output or fahrenhiet input is above a floats max value")]
        public void GivenCelsiusOutputOrFahrenhietInputIsAboveAFloatsMaxValue()
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToCelsius((float)c.ToNumeric("123412341234123412341234123412341234123412341234123412341234123412341234.123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234"));
            if(f != float.MaxValue)
                Assert.Fail();
            //throw new PendingStepException();
        }

        [Then(@"write an above max value error message")]
        public void ThenWriteAnAboveMaxValueErrorMessage()
        {
            //Assert.Fail();
            //throw new PendingStepException();
        }

        [Given(@"celsuis output or fahrenhiet input is below a floats min value")]
        public void GivenCelsuisOutputOrFahrenhietInputIsBelowAFloatsMinValue()
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToCelsius((float)c.ToNumeric("-123412341234123412341234123412341234123412341234123412341234123412341234.123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234123412341234"));
            if (f != -273.15f)
                Assert.Fail();
            //Assert.Fail();
            //throw new PendingStepException();
        }

        [Then(@"write an below min value error message")]
        public void ThenWriteAnBelowMinValueErrorMessage()
        {
            //Assert.Fail();
            //throw new PendingStepException();
        }
    }
}
