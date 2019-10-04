using System.Collections.Generic;
using System;

namespace WordCount.Models
{
    public class RepeatCounter
    {
        public string userSentence { get; set; }
        public string userWord { get; set; }

        public RepeatCounter(string sentence, string word)
        {
            userSentence = sentence; 
            userWord = word; 
        }

        public string GetValidInput()
        {
            if(userSentence == "0" || userSentence == "1" || userSentence == "2" || userSentence == "3" || userSentence == "4" || userSentence == "5" || userSentence =="6" || userSentence =="7" || userSentence == "8" || userSentence == "9")
            {
                return "Invalid input";
            }
            else
            {
               return TokenCount();
            }
        }

        public string TokenCount()
        {
            string userInput = userSentence.ToLower();
            return userInput;
        }
    }
}