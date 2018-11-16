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
  }
}
