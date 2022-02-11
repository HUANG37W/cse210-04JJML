using System;
using System.Collections.Generic;
namespace unit03_jumper
{
    public class Board
    {

        private Terminal terminal = new Terminal(); //creates instance of our terminal service

        private Word word = new Word(); //creates instance of word
        private SkyGuy sky = new SkyGuy();

        private List<string> guesses = new List<string>();

        private string gameword;

        private string s;
        private string guess;

        public Board()
        {
            gameword = word.PickWord();
        }

        public void DisplayWord()
        {
            foreach (char letter in gameword)
            {
                s = letter.ToString();
                if (guesses.Contains(s))
                {
                    terminal.Write(s);
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
            if (guess != s)
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