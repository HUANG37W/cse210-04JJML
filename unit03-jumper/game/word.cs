using System;
using System.Collections.Generic;

namespace unit03_jumper
{
    public class Word 
    {

        public Word()
        {
            SetWord();
        }
        private string gameWord;

        public int scoreGoal; //will be set to the number of characters of chosen word
        private Terminal terminal = new Terminal();
        private List<string> LotrWords = new List<string>
        {
            "sauron", "frodo", "gollum", "gandalf", "legolas"
        };

         private List<string> starWords = new List<string>
        {
            "blaster", "vader", "fives", "anakin", "kenobi"
        };
         private List<string> marvelWords = new List<string>
        {
            "stark", "thanos", "peter", "america", "winter"
        };

        private List<string> harryPotter = new List<string>
        {
            "harry", "weasley", "hermione", "malfoy", "voldemort"
        };
        private List<string> gameWords;

        public string GetWord()
        {
            terminal.WriteText($"\tPssst! The word is: {gameWord}"); //THIS IS SPOILERS
            return gameWord;
        }
        public void SetWord() 
        {
            Random random = new Random();
            int rnd = random.Next(1,5);

            switch (rnd)
            {
                case 1:
                    gameWords = LotrWords;
                    terminal.WriteText("\nLotr words selected.");
                    break;
                case 2:
                    gameWords = marvelWords;
                    terminal.WriteText("\nMarvel words selected.");
                    break;
                case 3:
                    gameWords = starWords;
                    terminal.WriteText("\nStar Wars words selected.");
                    break;
                case 4:
                    gameWords = harryPotter;
                    terminal.WriteText("\nHarry Potter words selected.");
                    break;
                default:
                    terminal.WriteText("\nSomething went wrong with the random.");
                    break;
            }
            
            rnd = random.Next(0, 5);
            gameWord = gameWords[rnd];

            
        }

        public bool CheckGuess(string guess)
        {
            //returns true or false depending on if the gameWord contains our guess
            return gameWord.Contains(guess);
        }
        
    }
}