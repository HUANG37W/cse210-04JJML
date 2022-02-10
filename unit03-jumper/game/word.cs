using System;

namespace unit03_jumper
{
    public class Word 
    {

        public Word()
        {
            
        }

        private Terminal terminal = new Terminal();
        private string[] LotrWords = new string[5]
        {
            "sauron", "frodo", "gollum", "gandalf", "legolas"
        };

         private string[] starWords = new string[5]
        {
            "blaster", "vader", "fives", "anakin", "kenobi"
        };
         private string[] marvelWords = new string[5]
        {
            "stark", "thanos", "peter", "america", "winter"
        };

        private string[] harryPotter = new string[5]
        {
            "harry", "weasley", "hermione", "malfoy", "voldemort"
        };
        private string[] gameWords = new string[5];

        public string PickWord()
        {
            Random random = new Random();
            int rnd = random.Next(1, 4);
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
                    Console.WriteLine("Something went wrong with the random.");
                    break;
            }

            rnd = random.Next(0, 4);

            gameWord = gameWords[rnd];

            return gameWord;
        }

        public bool CheckWin(bool gameOn)
        {
            //if word blanks full then gameOn = false
            //else if all the lives are lost then gameOn = false
            return gameOn;
        }

        
    }
}