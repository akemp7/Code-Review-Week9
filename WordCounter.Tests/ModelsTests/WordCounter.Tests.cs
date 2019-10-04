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
            Assert.AreEqual(validCount, "Invalid input");
        }

        // [TestMethod]
        // public void RepeatCounter_AllTokens_Two()
        // {
        //     RepeatCounter newCount = new RepeatCounter("The cat was friends with another cat", "")
        // }
    }
}