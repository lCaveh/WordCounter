using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void IsValid_WordandSentence_True()
    {
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(true, testWordCounter.IsValid());
    }
  }
}
