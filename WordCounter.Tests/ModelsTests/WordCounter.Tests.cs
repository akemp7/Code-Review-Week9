using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount.Models;

namespace WordCount.Test
{
    [TestClass]

    public class RepeatCounterTest
    {
        [TestMethod]
        public void RepeatCounter_CheckInput_None()
        {
            RepeatCounter newCount = new RepeatCounter("", "cat");
            bool inputCheck = newCount.CheckInput();
            Assert.AreEqual(inputCheck, false);
        }

        [TestMethod]
        public void RepeatCounter_LowerCaseSentence_lowercasesentence()
        {
            RepeatCounter newCount = new RepeatCounter("THE CAT SLEEPS", "cat");
            newCount.TokenCount();
            string lowerCase = newCount.UserSentence.ToLower();
            Assert.AreEqual(lowerCase, "the cat sleeps");
        }

        [TestMethod]
        public void RepeatCounter_AllTokens_catcat()
        {
            RepeatCounter newCount = new RepeatCounter("The cat made a cat friend.", "cat");
            newCount.TokenCount();
            int result = newCount.TokensCount;
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void RepeatCounter_Plural_OneCat()
        {
            RepeatCounter newCount = new RepeatCounter("Cats made a cat friend.", "cat");
            newCount.TokenCount();
            int result = newCount.TokensCount;
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void RepeatCounter_NoCathedral_cat()
        {
            RepeatCounter newCount = new RepeatCounter("Cat made a cathedral friend.", "cat");
            newCount.TokenCount();
            int result = newCount.TokensCount;
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void RepeatCounter_HowManyCats_ThreeCats()
        {
            RepeatCounter newCount = new RepeatCounter("Cat made a cathedral friend but not friends with other cats and one more cat", "cat");
            newCount.TokenCount();
            int result = newCount.TokensCount;
            Assert.AreEqual(result, 2);
        }
    }
}