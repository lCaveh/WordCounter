using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void IsValid_WordandSentence_True()
    {
      WordCounter testWordCounter = new WordCounter("Hi","How are you.");
      Assert.AreEqual(true, testWordCounter.IsValid());
      WordCounter test2WordCounter = new WordCounter("Hey you","How are you.");
      Assert.AreEqual(false, test2WordCounter.IsValid());
    }
    [TestMethod]
    public void ChangeToLowerCase_WordandSentence_SpecificAmount()
    {
      WordCounter testWordCounter = new WordCounter("Hi","How are you.");
      testWordCounter.ChangeToLowerCase();
      Assert.AreEqual("hi", testWordCounter.GetWord());
      Assert.AreEqual("how are you.", testWordCounter.GetSentence());
    }
    [TestMethod]
    public void ChangeSentenceToWords_Sentence_ListOfWords()
    {
      WordCounter testWordCounter = new WordCounter("Hi","How are you.");
      List<string> resultList = new List<string> {"how", "are", "you"};
      testWordCounter.ChangeToLowerCase();
      testWordCounter.ChangeSentenceToWords();
      CollectionAssert.AreEqual(resultList, testWordCounter.GetWordsOfSentence());
    }
    [TestMethod]
    public void HowManyTimesItRepeated_WordandSentence_Result()
    {
      WordCounter testWordCounter = new WordCounter("a","Pick a random string from a string array");
      testWordCounter.ChangeToLowerCase();
      testWordCounter.ChangeSentenceToWords();

      Assert.AreEqual(2, testWordCounter.HowManyTimesItRepeated());
    }
  }
}
