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

        public static int saveGuy = 0; //IMPORTANT FOR CHECKING IF THE GAME IS WON

        public Board(string word)
        {
            gameword = word;
        }

        public void DisplayWord()
        {
            foreach (char letters in gameword)
            {
                letter = letters.ToString();
                if (guesses.Contains(letter))
                {
                    terminal.Write(letter);
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
            guess = terminal.ReadText("\nGuess a letter of the word: "); //saves the guess in variable "guess"
            guesses.Add(guess);

            return guess;
        }
        
            
    

        

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