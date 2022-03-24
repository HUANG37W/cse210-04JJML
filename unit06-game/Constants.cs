using System.Collections.Generic;
using Unit06.Game.Casting;


namespace Unit06
{
    public class Constants
    {
        // ----------------------------------------------------------------------------------------- 
        // GENERAL GAME CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // GAME
        public static string GAME_NAME = "Kingdom Battle";
        public static int FRAME_RATE = 60;

        // SCREEN
        public static int SCREEN_WIDTH = 1040;
        public static int SCREEN_HEIGHT = 680;
        public static int CENTER_X = SCREEN_WIDTH / 2;
        public static int CENTER_Y = SCREEN_HEIGHT / 2;

        // FIELD
        public static int FIELD_TOP = 60;
        public static int FIELD_BOTTOM = SCREEN_HEIGHT;
        public static int FIELD_LEFT = 0;
        public static int FIELD_RIGHT = SCREEN_WIDTH;

        // FONT
        public static string FONT_FILE = "Assets/Fonts/zorque.otf";
        public static int FONT_SIZE = 22;

        // SOUND
        public static string SWORD_CLASH_SOUND = "Assets/Sounds/ENTER NAME";
        public static string WELCOME_SOUND = "Assets/Sounds/start.wav";
        public static string CHEER_SOUND = "Assets/Sounds/over.wav";

        // TEXT
        public static int ALIGN_LEFT = 0;
        public static int ALIGN_CENTER = 1;
        public static int ALIGN_RIGHT = 2;


        // COLORS
        public static Color BLACK = new Color(0, 0, 0);
        public static Color WHITE = new Color(255, 255, 255);
        public static Color PURPLE = new Color(255, 0, 255);
        public static Color GREEN = new Color(87,131,12);

        // Player 1 KEYS
        public static string P1DOWN = "s";
        public static string P1LEFT = "a";
        public static string P1RIGHT = "d";
        public static string P1UP = "w";

        // Player 2 KEYS
        public static string P2DOWN = "k";
        public static string P2LEFT = "j";
        public static string P2RIGHT = "l";
        public static string P2UP = "i";

        //general KEYS
        public static string SPACE = "space";
        public static string ENTER = "enter";
        public static string PAUSE = "p";

        // SCENES
        public static string NEW_GAME = "new_game";
        public static string TRY_AGAIN = "try_again";
        public static string NEXT_LEVEL = "next_level";
        public static string IN_PLAY = "in_play";
        public static string GAME_OVER = "game_over";

        // LEVELS
        public static string LEVEL_FILE = "Assets/Data/level-{0:000}.txt";
        public static int BASE_LEVELS = 5;

        // ----------------------------------------------------------------------------------------- 
        // SCRIPTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // PHASES
        public static string INITIALIZE = "initialize";
        public static string LOAD = "load";
        public static string INPUT = "input";
        public static string UPDATE = "update";
        public static string OUTPUT = "output";
        public static string UNLOAD = "unload";
        public static string RELEASE = "release";

        // ----------------------------------------------------------------------------------------- 
        // CASTING CONSTANTS
        // ----------------------------------------------------------------------------------------- 

        // STATS
        public static string STATS_GROUP = "stats";
        public static int DEFAULT_HEALTH = 100;
        // public static int MAXIMUM_LIVES = 5;

        public static int SWORD_DMG = 10;

        // HUD
        public static int HUD_MARGIN = 15;
        public static string LIVES1_GROUP = "lives1";
        public static string LIVES2_GROUP = "lives2";
        public static string SCORE_GROUP = "score";
        public static string LIVES1_FORMAT = "Player 1 - {0} lives";
        public static string LIVES2_FORMAT = "Player 2 - {0} lives";
        public static string SCORE_FORMAT = "SCORE: {0}";

        // FIGHTERS FOR PLAYER 1
        public static string FIGHTER_GROUP = "fighters";


        public static List<string> FIGHTER_IMAGES
            = new List<string>() {
                "Assets/Images/fighterRectangle.png"
            };
        public static List<string> FIGHTER2_IMAGES
            = new List<string>() {
                "Assets/Images/fighter2Rectangle.png"
            };

        public static int FIGHTER_WIDTH = 28;
        public static int FIGHTER_HEIGHT = 58;
        public static int FIGHTER_RATE = 6;
        public static int FIGHTER_VELOCITY = 3;
        public static int FIGHTER2_VELOCITY = -3;

        
        

       

        // Selector
        public static string SELECTOR_GROUP = "selectors";
        
        public static List<string> SELECTOR_IMAGES
            = new List<string>() {
                // "Assets/Images/100.png",
                // "Assets/Images/101.png",
                // "Assets/Images/102.png",
                "Assets/Images/arrow1.png"
            };
        public static List<string> SELECTOR2_IMAGES
            = new List<string>() {
                // "Assets/Images/100.png",
                // "Assets/Images/101.png",
                // "Assets/Images/102.png",
                "Assets/Images/arrow2.png"
            };

        public static int SELECTOR_WIDTH = 28;
        public static int SELECTOR_HEIGHT = 58;
        public static int SELECTOR_RATE = 6;
        public static int SELECTOR_VELOCITY = 3;

        public static int TOP_TRACK_Y = 540;
        public static int MID_TRACK_Y = 340;
        public static int BOTTOM_TRACK_Y = 140;
        public static int TRACK_DISTANCE = 200;
        

        // BRICK
        public static string BRICK_GROUP = "bricks";
        

        // DIALOG
        public static string DIALOG_GROUP = "dialogs";
        public static string ENTER_TO_START = "PRESS ENTER TO START";
        public static string PREP_TO_LAUNCH = "PREPARE TO FIGHT";
        public static string WAS_GOOD_GAME = "GAME OVER";


        public static int MAX_X = 900;
        public static int MAX_Y = 600;
        public static int MIN_X = 0;
        public static int MIN_Y = 0;
        public static int CELL_SIZE = 1;
        public static string CAPTION = "Fighter";

    }
}