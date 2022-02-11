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
        private string getword;
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
            return getword;
        }
        public void SetWord() 
        {
            Random random = new Random();
            int rnd = random.Next(1,4);
            string gameWord;

            switch (rnd)
            {
                case 1:
                    gameWords = LotrWords;
                    terminal.WriteText("Lotr words selected.");
                    break;
                case 2:
                    gameWords = marvelWords;
                    terminal.WriteText("Marvel words selected.");
                    break;
                case 3:
                    gameWords = starWords;
                    terminal.WriteText("Star Wars words selected.");
                    break;
                case 4:
                    gameWords = harryPotter;
                    terminal.WriteText("Harry Potter words selected.");
                    break;
                default:
                    terminal.WriteText("Something went wrong with the random.");
                    break;
            }
            
            rnd = random.Next(0, 4);
            gameWord = gameWords[rnd];

            
        }
        
    }
}