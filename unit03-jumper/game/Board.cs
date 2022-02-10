using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    public class Board
    {

        public Terminal terminal = new Terminal(); //creates instance of our terminal service

        private Word word = new Word(); //creates instance of word

        private List<string> wordChars = new List<string>(); 

        public int dashNum = 0;

        public Board()
        {
            //Board constructor method
        }

        //public static string ToNonDashed(this string input)
         //return input?.Replace("-", string.Empty);

        // This might need to be changed to a string
        public void InitDashes() 
        {
            string gameWord = word.PickWord();
            dashNum = gameWord.Length;

            for (int j = 0; j < dashNum; j++)
            {
                //fill the wordChars string list with underscore at start of game
                wordChars.ToString() += "_";
            }
        }

        public void DisplayDashes()
        {
            for (int i = 0; i < dashNum; i++)  
            {
                //displays each part of wordChars string list
                terminal.WriteChar(wordChars[i]);
            }
        }

        public void GetGuess()
        {
            string guess = "";
            terminal.WriteChar("Guess a letter: ");
            terminal.ReadText(guess);

            for (int k = 0; k < dashNum; k++)
            {
                if (wordChars[k] == guess)
                {
                    wordChars[k] = guess;
                }
            }
        }

        public void ReplaceDash()
        {
            string gameWord = word.PickWord();
            foreach (letter in gameWord)
            {
                wordChars.add(letter);
            }
        }    
    }     
}