using System;
using System.Collections.Generic;


namespace unit03_jumper
{
    class Director
    {   
        private SkyGuy skyguy = new SkyGuy();
        private bool isPlaying = true;
        ///word is instantiated and sets gameword
        
        private Terminal terminal = new Terminal();

        private Board board = new Board();

        private string userInput = "Y";
        

        //set up the game: pick a random word, display the initial look of the board.
        public void SetupGame()
        {
            skyguy.PrintParachute();
            skyguy.PrintGuy();
            board.DisplayWord();
            board.GetGuess();
       }

        //start the actual game, looping through all the functions until the game is over
        public void StartGame()
        {
            SetupGame();
            while (isPlaying == true)
            {
                DoInput();
                DoUpdate();
                DoOutput();
            }
        }

        public void DoInput()
        {
            //ask the user for their letter guess
            board.GetGuess();
        }

        public void DoUpdate()
        {   

            if (skyguy.IsDead())
                isPlaying = false;
            
            if (isPlaying == false)
            {
                terminal.WriteText("Do you want to play again? y/n");
                terminal.ReadText(userInput);
                userInput = userInput.ToUpper();
                if (userInput == "Y")
                {
                    isPlaying = true;
                }
                else
                {
                    isPlaying = false;
                }

            }
            
        }

        public void DoOutput()
        {
            //Displays the paracute, then the guy attatched to the parachute,
            //and then the spaces where the word needs to filled.
            skyguy.PrintParachute();
            skyguy.PrintGuy();
            board.KillSkyGuy();
            terminal.WriteText(" \n");
            board.DisplayWord();
            
        }
    }
}

               