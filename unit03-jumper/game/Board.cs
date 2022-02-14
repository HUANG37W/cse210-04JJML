using System;
using System.Collections.Generic;
namespace unit03_jumper
{
    public class Board
    {
        ///instantiate terminal, guesses list, gameword list, letter, guess
        private Terminal terminal = new Terminal(); //creates instance of our terminal service
        private List<string> guesses = new List<string>();

        private string _gameword;

        private string _letter;
        private string _guess;

        private int _score = 0; //This is the user's score which keeps track of how close to winning

        public static int saveGuy = 0; //IMPORTANT FOR CHECKING IF THE GAME IS WON (Compare score with saveGuy)
        /// <summary>
        /// Create instance of board class.
        /// </summary>
        public Board(string word)
        {
            _gameword = word;
        }
        /// <summary>
        /// Displays the board, replaces letter and displays it, or a dash.
        /// </summary>
        public void DisplayWord()
        {
            foreach (char letters in _gameword)
            {
                _letter = letters.ToString();
                if (guesses.Contains(_letter))
                {
                    terminal.Write(_letter);
                }
                //saying if the letter guess was wrong
                else
                {
                    terminal.Write("_ ");
                }
            }
        }
        public string GetGuess()
        {
            _guess = terminal.ReadText("\n\nGuess a letter of the word: "); //saves the guess in variable "guess"
            terminal.WriteText("\n");
            guesses.Add(_guess);

            return _guess;
        }
        // public bool GetWin(bool true)
        // {
        //     if (String.Equals(letterList, guesses)) 
        //     {
        //         return true;
        //     }
        // }

        /// <summary>
        /// Checks if the game is won (all the blanks filled) and returns a
        /// true or false.
        /// </summary>
        public bool CheckWin(bool gameOn)
        {
            foreach (char letter in _gameword)
            {
                int maxNum = _gameword.Length;
                string s = letter.ToString();
                //if there are "_" still in the list guesses, the word is not filled yet
                if (guesses.Contains(s))
                {
                    _score++;
                }
                if (_score >= maxNum)
                {
                    //FIX THIS: The for each loop racks up points into _score too fast giving an early win.
                    terminal.WriteText("You Win!");
                    gameOn = false;
                }
            }
            return gameOn;
        }   
    }     
}
