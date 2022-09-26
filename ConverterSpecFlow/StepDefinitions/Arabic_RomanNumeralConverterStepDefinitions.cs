using System;
using TechTalk.SpecFlow;

namespace ConverterSpecFlow.StepDefinitions
{
    [Binding]
    public class Arabic_RomanNumeralConverterStepDefinitions
    {
        [Given(@"integar input is (.*)")]
        public void GivenIntegarInputIs(int p0)
        {;
            Assert.AreEqual(p0, 10);
            //Assert.Fail();
            //throw new PendingStepException();
        }

        [When(@"toRoman button is pressed")]
        public void WhenToRomanButtonIsPressed()
        {
            //Assert.Fail();
            //throw new PendingStepException();
        }

        [Then(@"roman numeral output should be ""([^""]*)""")]
        public void ThenRomanNumeralOutputShouldBe(string roman)
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            string s = c.ToRoman(10);
            Assert.AreEqual(s, roman);
            //Assert.Fail();
            //throw new PendingStepException();
        }

        [Given(@"integer input is an invalid integer")]
        public void GivenIntegerInputIsAnInvalidInteger()
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            float? f = c.ToNumeric("sjsj");
            if (f != null)
                Assert.Fail();
            //throw new PendingStepException();
        }

        [Given(@"arabic numeral input is above max roman numeral")]
        public void GivenArabicNumeralInputIsAboveMaxRomanNumeral()
        {

            ConverterProject.Converter c = new ConverterProject.Converter();
            string s = c.ToRoman(5000);
            Assert.AreEqual(s, "MMMCMXCIX");
            //Assert.Fail();
            //throw new PendingStepException();
        }

        [When(@"output is written on screen")]
        public void WhenOutputIsWrittenOnScreen()
        {
            //Assert.Fail();
            //throw new PendingStepException();
        }

        [Given(@"arabic numeral input is below min roman numeral")]
        public void GivenArabicNumeralInputIsBelowMinRomanNumeral()
        {
            ConverterProject.Converter c = new ConverterProject.Converter();
            string s = c.ToRoman(-5000);
            Assert.AreEqual(s, "-MMMCMXCIX");
            //Assert.Fail();
            //throw new PendingStepException();
        }
    }
}
