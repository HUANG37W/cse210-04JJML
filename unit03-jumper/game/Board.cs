using System;
using System.Collections.Generic;
namespace unit03_jumper
{
    public class Board
    {

        private Terminal terminal = new Terminal(); //creates instance of our terminal service

    
        private SkyGuy sky = new SkyGuy();

        private List<string> guesses = new List<string>();
        private Word word = new Word();

        private string gameword;

        private string letter;
        private string guess;

        public Board()
        {
            gameword = word.GetWord();
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
        public void GetGuess()
        {
            guess = "";
            terminal.Write("\nGuess a letter of the word: ");
            terminal.ReadText(guess);
            guesses.Add(guess);
        }
        public void KillSkyGuy()
        {
            if (guess != letter)
            {
                sky.UpdateParachute();
            }
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