using System;
using System.Collections.Generic;
namespace unit03_jumper
{
    public class Board
    {
        ///instantiate terminal, guesses list, gameword list, letter, guess
        private Terminal terminal = new Terminal(); //creates instance of our terminal service

    
        // private SkyGuy sky = new SkyGuy();

        private List<string> guesses = new List<string>();

        private string gameword;

        private string letter;
        private string guess;

        private int score = 0; //This is the user's score which keeps track of how close to winning

        public static int saveGuy = 0; //IMPORTANT FOR CHECKING IF THE GAME IS WON (Compare score with saveGuy)
        /// <summary>
        /// Create instance of board class.
        /// </summary>
        public Board(string word)
        {
            gameword = word;
        }
        /// <summary>
        /// Displays the board, replaces letter and displays it, or a dash.
        /// </summary>
        public void DisplayWord()
        {
            foreach (char letters in gameword)
            {
                letter = letters.ToString();
                if (guesses.Contains(letter))
                {
                    terminal.Write(letter);
                    score++; //increases the score if the guess is correct
                }
                //saying if the letter guess was wrong
                else
                {
                    terminal.Write("_ ");
                }
                // terminal.Write( letter);
            }
        }
        

        public string GetGuess()
        {
            guess = terminal.ReadText("\n\nGuess a letter of the word: "); //saves the guess in variable "guess"
            terminal.WriteText("\n");
            guesses.Add(guess);

            return guess;
        }
       
       /// <summary>
        /// Checks if the game is won (all the blanks filled) and returns a
        /// true or false.
        /// </summary>
        public bool CheckWin(bool gameOn)
        {
            foreach (char letter in gameword)
            {
                int num = 0;
                int maxNum = gameword.Length;
                string s = letter.ToString();
                //if there are "_" still in the list guesses, the word is not filled yet
                if (guesses.Contains(s))
                {
                    num++;
                }
                if (num >= maxNum)
                {
                    gameOn = false;
                }
            }
            return gameOn;
        }   

        
    }     
}