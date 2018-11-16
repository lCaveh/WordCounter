using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
  public class WordCounter
  {
    private string MainWord;
    private string MainSentence;
    private List<string> WordsOfSentence= new List<string>{};

    public WordCounter(string userWord, string userSentence)
    {
      MainWord=userWord;
      MainSentence=userSentence;
    }
    public bool IsValid()
    {
      if (MainWord.Count()>0 && MainSentence.Count()>0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public void ChangeToLowerCase()
    {
      MainWord= MainWord.ToLower();
      MainSentence= MainSentence.ToLower();
    }
    public void ChangeSentenceToWords()
    {
      char[] sentenceArray = MainWord.ToCharArray();
      string sentenceWords = "";
      for (int i=0;i<sentenceArray.Length;i++)
      {
        if (Char.IsLetter(sentenceArray[i]))
        {
          sentenceWords+= Char.ToString(sentenceArray[i]);
        } else if (Char.IsWhiteSpace(sentenceArray[i]) || i==sentenceArray.Length-1)
        {
          WordsOfSentence.Add(sentenceWords);
          sentenceWords="";
        }
      }
    }
    public string GetWord()
    {
      return MainWord;
    }
    public string GetSentence()
    {
      return MainSentence;
    }
    public List<string> GetWordsOfSentence()
    {
      return WordsOfSentence;
    }
  }
}
