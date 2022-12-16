using System.ComponentModel;

namespace ttt_test2
{

    internal class Program
    {
        /*
        public toZero(int brettspiel)
        {
            brettspiel[0, 0] = 0;
            brettspiel[0, 1] = 0;
            brettspiel[0, 2] = 0;
            brettspiel[1, 0] = 0;
            brettspiel[1, 1] = 0;
            brettspiel[1, 2] = 0;
            brettspiel[2, 0] = 0;
            brettspiel[2, 1] = 0;
            brettspiel[2, 2] = 0;
            //       
                        int[,] brettspiel = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };                                                                                                                                                                     g o d d a m m i t
        }*/
        static int[,] brettspiel = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };// im unsure as to why this isn't w o r k i n g 

        static void BoardGame()
        {

            for (int rounds = 0; rounds < 9;) // MOVE THIS DOWN 
            {


                for (var row = 0; row < brettspiel.GetLength(0); row++)
                {
                    for (var col = 0; col < brettspiel.GetLength(1); col++)
                    {
                        Console.Write($"{brettspiel[row, col]}" + " ");

                    }
                    Console.WriteLine("");
                }
                rounds++;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("To play input the number you want your space to go in");

            bool turn = true;
            bool win = false;
           
            while (win == false)
            {
                BoardGame();
                // finally I did it   YYIIPPPEEEEE . ..  wait how will I change parts to x or o . . . oh no . . .            . . .


                if (turn == true) // turn system
                {

                    Console.WriteLine();
                    Console.WriteLine("1 2 3");
                    Console.WriteLine("4 5 6");
                    Console.WriteLine("7 8 9");
                    Console.WriteLine("player 1 go");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input > 0 || input <= 9)
                    {
                        if (input == 1)//1
                        {
                            brettspiel[0, 0] = 1;
                        }
                        if (input == 1)//2
                        {
                            brettspiel[0, 1] = 1;
                        }
                        if (input == 1)//3
                        {
                            brettspiel[0, 2] = 1;
                        }
                        if (input == 1)//4
                        {
                            brettspiel[1, 0] = 1;
                        }
                        if (input == 1)//5
                        {
                            brettspiel[1, 1] = 1;
                        }
                        if (input == 1)//6
                        {
                            brettspiel[1, 2] = 1;
                        }
                        if (input == 1)//7
                        {
                            brettspiel[2, 0] = 1;
                        }
                        if (input == 1)//8
                        {
                            brettspiel[2, 1] = 1;
                        }
                        if (input == 1)//9
                        {
                            brettspiel[2, 2] = 1;
                        }
                        // end of input number


                    }
                    else
                    {
                        Console.WriteLine("Input was not 1 - 9");
                    }
                    turn = false;
                }       // this looks awful    . .  .                                 my stupid little head is gonna implode
                else
                {

                    Console.WriteLine();
                    Console.WriteLine("1 2 3");
                    Console.WriteLine("4 5 6");
                    Console.WriteLine("7 8 9");
                    Console.WriteLine("player 2 go");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input > 0 || input <= 9)
                    {
                        if (input == 1)//1
                        {
                            brettspiel[0, 0] = 2;
                        }
                        if (input == 1)//2
                        {
                            brettspiel[0, 1] = 2;
                        }
                        if (input == 1)//3
                        {
                            brettspiel[0, 2] = 2;
                        }
                        if (input == 1)//4
                        {
                            brettspiel[1, 0] = 2;
                        }
                        if (input == 1)//5
                        {
                            brettspiel[1, 1] = 2;
                        }
                        if (input == 1)//6
                        {
                            brettspiel[1, 2] = 2;
                        }
                        if (input == 1)//7
                        {
                            brettspiel[2, 0] = 2;
                        }
                        if (input == 1)//8
                        {
                            brettspiel[2, 1] = 2;
                        }
                        if (input == 1)//9
                        {
                            brettspiel[2, 2] = 2;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input was not 1 - 9");
                    }
                        turn = true;
                    
                }
            }
        }
    }
}
        
        
    

/*
    - Needs a 3 by 3 rectangular array of integers /v/
    - Constructor to "initialize" the array to all 0s ( make into an empty board )
    - allow 2 ways to input ( two people ) // plan for ai 
    - place a 1 for the first player's turn
    - place a 2 for the second player's turn
    - each turn must be in a empty square
    - AFTER EVERY MOVE scan to see if the game has been won or is at a draw ( probably use true or false to have a while loop that will last until it hits true ). if nether continue game.
    - EXTRA if ambitious make an ai player. -- my idea is to use a random number generator between 1 and 9 ( of course this ai wouldn't be strategic) 
      and it detects IF a number has already been placed there. if a number has then it would re-roll the random number gen.
*/
/*
    
     bool win = false;
            bool turn = true;
            while(win == false)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (win == true)
                    {
                        win = true;//use later, player __ won
                    }
                    else if (i == 9)
                    {
                        win = true;
                    }
                    else { }
                }
                
*/