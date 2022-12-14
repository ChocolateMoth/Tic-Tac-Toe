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
            //       int[,] brettspiel = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };                                                                                                                                                                       g o d d a m m i t
        }*/
        static void Main(string[] args)
        {
            Console.WriteLine("To play input the number you want your space to go in");
            int[,] brettspiel = { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            bool turn = true;
            bool win = false;
            // all would have to be in a while loop right ?
            while (win == false)
            {
                for (int rounds = 0; rounds < 9;)
                {


                    for (var row = 0; row < brettspiel.GetLength(0); row++)
                    {
                        for (var col = 0; col < brettspiel.GetLength(1); col++)
                        {
                            Console.Write($"{brettspiel[row, col]}"+ " ");
                            
                        }
                        Console.WriteLine("");
                        // finally I did it   YYIIPPPEEEEE . ..  wait how will I change parts to x or o . . . oh no . . .            . . .

                    }
                    if (turn == true) // turn system
                    {
                        
                        Console.WriteLine();
                        Console.WriteLine("1 2 3");
                        Console.WriteLine("4 5 6");
                        Console.WriteLine("7 8 9");
                        Console.WriteLine("player 1 go");
                        int input = Convert.ToInt32(Console.ReadLine());
                        
                        turn = false;
                    }       // this looks awful
                    else
                    {
                     
                        Console.WriteLine();
                        Console.WriteLine("1 2 3");
                        Console.WriteLine("4 5 6");
                        Console.WriteLine("7 8 9");
                        Console.WriteLine("player 2 go");
                        int input = Convert.ToInt32(Console.ReadLine());
                        turn = true;
                    }

                }
            }
        }
        
    }
}
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