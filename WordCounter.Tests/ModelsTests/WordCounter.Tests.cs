using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount.Models;

namespace WordCount.Test
{
    [TestClass]

    public class RepeatCounterTest
    {
        [TestMethod]
        public void RepeatCounter_ValidInput_None()
        {
            RepeatCounter newCount = new RepeatCounter("8", "8");
            string validCount = newCount.GetValidInput();
            Assert.AreEqual(validCount, "Please enter a sentence and word.");
        }

        [TestMethod]
        public void RepeatCounter_LowerCaseSentence_lowercasesentence()
        {
            RepeatCounter newCount = new RepeatCounter("THE CAT SLEEPS.", "cat");
            string lowerSentence = newCount.TokenCount();
            Assert.AreEqual(lowerSentence, "the cat sleeps.");
        }

        [TestMethod]
        public void RepeatCounter_AllTokens_catcat()
        {
            RepeatCounter newCount = new RepeatCounter("The cat made a cat friend.", "cat");
            newCount.TokenCount();
            string output = newCount.NewString;
            Assert.AreEqual("token token", output);
        }
    }
}