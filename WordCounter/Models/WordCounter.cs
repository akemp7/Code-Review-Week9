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

        public bool CheckInput()
        {
            
            if(UserSentence == "")
            {
                return false;
            }
           else
           {
               return true; 
           }
        }

        public void TokenCount()
        {
            List<string> words = new List<string> {};
            string [] wordArray = UserSentence.ToLower().Split(" ");
            for(int i = 0; i<wordArray.Length; i++)
            {
                if(wordArray[i].Length > UserWord.Length)
                {
                      wordArray[i] = "";
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