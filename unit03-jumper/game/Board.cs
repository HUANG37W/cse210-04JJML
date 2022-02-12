using System;
using System.Collections.Generic;
namespace unit03_jumper
{
    public class Board
    {

        private Terminal terminal = new Terminal(); //creates instance of our terminal service

    
        private SkyGuy sky = new SkyGuy();

        private List<string> guesses = new List<string>();

        private string gameword;

        private string letter;
        private string guess;

        private int score = 0; //This is the user's score which keeps track of how close to winning

        public static int saveGuy = 0; //IMPORTANT FOR CHECKING IF THE GAME IS WON (Compare score with saveGuy)

        public Board(string word)
        {
            gameword = word;
        }

        /// <summary>
        /// This will get our word and let us compare it to the game word to then display.
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
            }

        }

        /// <summary>
        /// Allows us to get the guess and adds the guess to a list. 
        /// </summary>
        public string GetGuess()
        {
            guess = terminal.ReadText("\nGuess a letter of the word: "); //saves the guess in variable "guess"
            terminal.WriteText("\n");
            guesses.Add(guess);

            return guess;
        }
        
            
    

        
        // MOST LIKELY DELETE THIS
        // public bool CheckWin(bool gameOn)
        // {
        //     foreach (char letter in gameword)
        //     {
        //         // string s = letter.ToString();
        //         // if (guesses != "_")
        //         // {
        //         //     gameOn = true;
        //         // }
        //         // else
        //         // {
        //         //     gameOn = false;
        //         // }
        //     }
        //     //if word blanks full then gameOn = false
        //     //else if all the lives are lost then gameOn = false
        //     return gameOn;
        // }
        
    }     
}