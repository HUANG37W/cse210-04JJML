using System;
using System.Collections.Generic;


namespace unit03_jumper
{
    class Director
    {   
        private SkyGuy skyguy = new SkyGuy();
        private bool isPlaying = true;
        ///word is instantiated and sets the gameword
        
        private Terminal terminal = new Terminal();

        private Board board;
        private Word word = new Word();

        private string _userInput = " ";

        private string _guess;

        private bool _replay = false;

        public Director()
        {
            board = new Board(word.GetWord());

        }
        

        //set up the game: pick a random word, display the initial look of the board.
        public void SetupGame()
        {
            isPlaying = true;
            skyguy.SetupParachute();
            skyguy.PrintParachute();
            skyguy.PrintGuy();
            board.DisplayWord();
       }

        //start the actual game, looping through all the functions until the game is over
        public void StartGame()
        {
            SetupGame();
            while (isPlaying == true)
            {
                if (_replay)
                {
                    SetupGame(); //resets the board for the next game
                    word.SetWord(); //picks a new word for the next game
                    _replay = false; //sets replay back to 0 so SetupGame isn't called multiple times
                }
                DoInput();
                DoOutput();
                DoUpdate();
            }
        }

        public void DoInput()
        {
            //ask the user for their letter guess
            _guess = board.GetGuess();
        }

        public void DoUpdate()
        {   
            //check if the game should still be going on
            //THIS DOESN'T WORK YET FOR SOME REASON
            isPlaying = board.CheckWin(isPlaying);

            if (skyguy.IsDead())
            {
                isPlaying = false;
                terminal.WriteText("\n\nBetter luck next time!");
            }

            if (!word.CheckGuess(_guess))
            {
                skyguy.UpdateParachute();
            }
            
            //if the game is over, ask user if they want to play again.
            if (isPlaying == false)
            {
                _userInput = terminal.ReadText("\nDo you want to play again? y/n?\n");
                terminal.WriteText($"\tUserInput was saved as: {_userInput}");
                _userInput = _userInput.ToUpper();
                if (_userInput == "Y")
                {
                    isPlaying = true;
                    _replay = true; //keep track that we are playing again
                    terminal.WriteText($"\tisPlaying saved as: {isPlaying}");
                }
                else
                {
                    isPlaying = false;
                    terminal.WriteText($"\tisPlaying saved as: {isPlaying}");
                }
            }
        }

        public void DoOutput()
        {
            //Displays the paracute, then the guy attatched to the parachute,
            //and then the spaces where the word needs to filled.
            skyguy.PrintParachute();
            skyguy.PrintGuy();
            terminal.WriteText(" \n");
            board.DisplayWord();
            
        }
    }
}

               