using System;
using System.Collections.Generic;
namespace unit03_jumper
{
    public class Board
    {

        public Terminal terminal = new Terminal(); //creates instance of our terminal service

        private Word word = new Word(); //creates instance of word

        private List<string> guesses = new List<string>();

        // private char[] wordChars = new char[64];

        public int dashNum = 0;
        private string gameword;

        public Board()
        {
            gameword = word.PickWord();
        }

        public void DisplayWord() 
        {
            foreach (char letter in gameword)
            {
                string s = letter.ToString();
                if (guesses.Contains(s))
                {
                    terminal.WriteText(s);
                }

                else
                {
                    terminal.WriteText("-");
                }
            }

        }
        public void GetGuess()
        {
            string guess = "";
            terminal.WriteChar("Guess one letter of the word: ");
            terminal.ReadText(guess);
            guesses.Add(guess);    

        }

        

        
    }     
}