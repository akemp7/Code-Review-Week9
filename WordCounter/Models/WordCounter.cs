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

        public void GetValidCount()
        {

        }
    }
}