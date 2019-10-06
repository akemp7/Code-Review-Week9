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
            newCount.GetValidInput();
            Assert.AreEqual("Please enter a sentence and word.", "Please enter a sentence and word.");
        }

        [TestMethod]
        public void RepeatCounter_LowerCaseSentence_lowercasesentence()
        {
            RepeatCounter newCount = new RepeatCounter("THE CAT SLEEPS.", "cat");
            newCount.TokenCount();
            Assert.AreEqual("the cat sleeps", "the cat sleeps");
        }

        [TestMethod]
        public void RepeatCounter_AllTokens_catcat()
        {
            RepeatCounter newCount = new RepeatCounter("The cat made a cat friend.", "cat");
            newCount.TokenCount();
            Assert.AreEqual("cat cat", "cat cat");
        }

        [TestMethod]
        public void RepeatCounter_Plural_catcats()
        {
            RepeatCounter newCount = new RepeatCounter("Cats made a cat friend.", "cat");
            newCount.TokenCount();
            Assert.AreEqual("cats cat", "cats cat");
        }

        [TestMethod]
        public void RepeatCounter_NoCathedral_cat()
        {
            RepeatCounter newCount = new RepeatCounter("Cat made a cathedral friend.", "cat");
            newCount.TokenCount();
            Assert.AreEqual("cat", "cat");
        }

        [TestMethod]
        public void RepeatCounter_HowManyCats_ThreeCats()
        {
            RepeatCounter newCount = new RepeatCounter("Cat made a cathedral friend but not friends with other cats and one more cat.", "cat");
            newCount.TokenCount();
            int result = newCount.TokensCount;
            Assert.AreEqual(result, 3);
        }
    }
}