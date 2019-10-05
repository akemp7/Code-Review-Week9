using System.Collections.Generic;
using System;

namespace WordCount.Models
{
    public class RepeatCounter
    {
        public string UserSentence { get; set; }
        public string UserWord { get; set; }

        public RepeatCounter(string sentence, string word)
        {
            UserSentence = sentence; 
            UserWord = word; 
        }

        public string GetValidInput()
        {
            if(UserSentence == "0" || UserSentence == "1" || UserSentence == "2" || UserSentence == "3" || UserSentence == "4" || UserSentence == "5" || UserSentence =="6" || UserSentence =="7" || UserSentence == "8" || UserSentence == "9")
            {
                return "Please enter a sentence and word.";
            }
            else
            {
                return "Something";
             
            }
        }

        public string TokenCount()
        {
         
            // string userInput = UserSentence.ToLower();
            string [] wordArray = UserSentence.ToLower().Split(" ");
            for(int i = 0; i<wordArray.Length; i++)
            {
                if(wordArray[i] == UserWord)
                {
                    
                }
            }
        
        } 
    }
}