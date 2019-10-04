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
            RepeatCounter newCount = new RepeatCounter("10", "10");
            string validCount = newCount.GetValidCount();
            Assert.AreEqual(validCount, 0);
        }
    }
}