using System.Collections.Generic;
using System;

namespace WordCount.Models
{
    public class RepeatCounter
    {
        public string UserSentence { get; set; }
        public string UserWord { get; set; }

        public int TokensCount { get; set; }

        public RepeatCounter(string sentence, string word)
        {
            UserSentence = sentence; 
            UserWord = word; 
            TokensCount = 0; 
        }

        // public void GetValidInput()
        // {
        //     int userInput = int.Parse(UserSentence);
        //     if(userInput > 0 || userInput <= 0)
        //     {
        //         Console.WriteLine("Please enter a sentence and word.");
        //     }
        //     else
        //     {
        //         TokenCount();
    
        //     }
        // }

        public void TokenCount()
        {
            List<string> words = new List<string> {};
            string [] wordArray = UserSentence.ToLower().Split(" ");
            for(int i = 0; i<wordArray.Length; i++)
            {
                if(i > UserWord.Length)
                {
                      wordArray[i] = " ";
                }
                else if(wordArray[i].Contains(UserWord))
                {
                    words.Add(wordArray[i]);
                }
               
            }
           foreach(string word in words)
             {
               TokensCount = words.Count;
             }
        } 
    }
}