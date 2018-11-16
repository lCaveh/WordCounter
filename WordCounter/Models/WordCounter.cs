using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
  public class WordCounter
  {
    //Theses two praperties keep user's word and sentence.
    private string MainWord;
    private string MainSentence;
    //This list keep the words in the user sentence.
    private List<string> WordsOfSentence= new List<string>{};
    //Constructor
    public WordCounter(string userWord, string userSentence)
    {
      MainWord=userWord;
      MainSentence=userSentence;
    }
    //This method will check the word's and number's validaty.
    public bool IsValid()
    {
      if (MainWord.Count()>0 && MainSentence.Count()>0)
      {
        char[] wordArray = MainWord.ToCharArray();
        foreach (char character in wordArray)
        {
          if(Char.IsLetter(character) || Char.IsNumber(character))
          {
            //It is good, Don't return false;
          }
          else
          {
            return false;
          }
        }
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
    //This method will chunk sentence into a list of words
    public void ChangeSentenceToWords()
    {
      char[] sentenceArray = MainSentence.ToCharArray();
      string sentenceWords = "";
      for (int i=0;i<sentenceArray.Length;i++)
      {
        //To check if it is not end of a word in sentence.
        if (Char.IsLetter(sentenceArray[i]))
        {
          //Add character to word
          sentenceWords+= Char.ToString(sentenceArray[i]);
        }
        //To check if it is end of a word in sentence.
        if (Char.IsWhiteSpace(sentenceArray[i]) || i==sentenceArray.Length-1)
        {
          //Add the word to list of words and reset the word.
          WordsOfSentence.Add(sentenceWords);
          sentenceWords="";
        }
      }
    }
    //Calculate the result
    public int HowManyTimesItRepeated()
    {
      int counter=0;
      for (int i=0;i<WordsOfSentence.Count;i++)
      {
        if (MainWord==WordsOfSentence[i])
        {
          counter++;
        }
      }
      return counter;
    }
    //Getter methods
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
