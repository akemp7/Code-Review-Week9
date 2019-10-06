using System;
using WordCount.Models;

namespace WordCount
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Type in a sentence.");
            string userSentence = Console.ReadLine();
            Console.WriteLine("What is the word you are interested in counting?");
            string userWord = Console.ReadLine();
            
             RepeatCounter newCounter = new RepeatCounter(userSentence, userWord);
            newCounter.TokenCount();
            Console.WriteLine(newCounter.TokensCount);

            }
        }
    }