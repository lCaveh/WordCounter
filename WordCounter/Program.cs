using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a word");
      string userWord= Console.ReadLine();
      Console.WriteLine("Enter a sentence");
      string userSentence= Console.ReadLine();
      WordCounter worldCounter= new WordCounter(userWord,userSentence);
      if (worldCounter.IsValid())
      {
        worldCounter.ChangeToLowerCase();
        worldCounter.ChangeSentenceToWords();
        Console.WriteLine("There is "+ worldCounter.HowManyTimesItRepeated()+ " "+ userWord+ " in your sentence.");
      }
      else
      {
        Console.WriteLine("Sorry, your input is not valid.");
        Main();
      }
    }
  }
}
