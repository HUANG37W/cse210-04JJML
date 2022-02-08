using System;

namespace unit03_jumper
{
    public class Board
    {
        public Board()
        {
           
        }

        public static string ToNonDashed(this string input)
    {
        return input?.Replace("-", string.Empty);
    }  
        

      

        
    }
    
}