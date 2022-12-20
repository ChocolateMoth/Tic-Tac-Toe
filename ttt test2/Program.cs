using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ttt_test2
{// IM SURE THERE IS A WAY EASIER WAY TO WRITE THIS BUT IM NOT SMART AND DON'T REALLY KNOW WHAT IM DOING SO     OH WELL . . . 

    internal class Program
    {
       
        static int[,] brettspiel = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };// im unsure as to why this isn't w o r k i n g ... now it is working yay

        static void BoardGame() // is the board. fun fact brettspiel is german for board game. I'm bad at german so hopefully I spelled that right
        {

  
                for (var row = 0; row < brettspiel.GetLength(0); row++)
                {
                    for (var col = 0; col < brettspiel.GetLength(1); col++)
                    {
                        Console.Write($"{brettspiel[row, col]}" + " ");

                    }
                    Console.WriteLine("");
                }
               
            
        }
        static void winCheck(bool win, int play)
        {
            if (brettspiel[0, 0] == 1 && brettspiel[0, 1] == 1 && brettspiel[0, 2] == 1)
            {
                win = true;
                play = 1;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("To play input the number you want your space to go in");

            int turn = 1; // lets turn into a int instead of a bool
            bool win = false;
            int play = 0;
            // bool GameRun = false;

            while (win == false)
            {
                for (int rounds = 0; rounds <= 9;) // MOVE THIS DOWN ... COMPLETE 
                {
                    BoardGame();
                    // finally I did it   YYIIPPPEEEEE . ..  wait how will I change parts to x or o . . . oh no . . .            . . .

                    if (turn == 1) // turn system
                    {

                        Console.WriteLine();
                        Console.WriteLine("1 2 3");
                        Console.WriteLine("4 5 6");
                        Console.WriteLine("7 8 9");
                        Console.WriteLine();
                        Console.WriteLine("player 1 go");
                        int input = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");
                        if (input > 0 || input <= 9)
                        {
                            if (input == 1)//1
                            {
                                if (brettspiel[0, 0] == 2 || brettspiel[0, 0] == 1)
                                {
                                    turn = 1;
                                }
                                else
                                {
                                    brettspiel[0, 0] = 1;
                                    turn = 2;
                                }
                                //////////////////////////
                            }
                            if (input == 2)//2
                            {
                                if (brettspiel[0, 1] == 2 || brettspiel[0, 1] == 1)
                                {
                                    turn = 1;
                                }
                                else
                                {
                                    brettspiel[0, 1] = 1;
                                    turn = 2;
                                }
                                ////////////////////////////////////////////////////
                            }
                            if (input == 3)//3
                            {
                                if (brettspiel[0, 2] == 2 || brettspiel[0, 2] == 1)
                                {
                                    turn = 1;
                                }
                                else
                                {
                                    brettspiel[0, 2] = 1;
                                    turn = 2;
                                }
                                //////////////////////////
                            }
                            if (input == 4)//4
                            {
                                if (brettspiel[1, 0] == 2 || brettspiel[1, 0] == 1)
                                {
                                    turn = 1;
                                }
                                else
                                {
                                    brettspiel[1, 0] = 1;
                                    turn = 2;
                                }
                                ////////////////////////////////////////////////////
                            }
                            if (input == 5)//5
                            {
                                if (brettspiel[1, 1] == 2 || brettspiel[1, 1] == 1)
                                {
                                    turn = 1;
                                }
                                else
                                {
                                    brettspiel[1, 1] = 1;
                                    turn = 2;
                                }
                                //////////////////////////
                            }
                            if (input == 6)//6
                            {
                                if (brettspiel[1, 2] == 2 || brettspiel[1, 2] == 1)
                                {
                                    turn = 1;
                                }
                                else
                                {
                                    brettspiel[1, 2] = 1;
                                    turn = 2;
                                }
                                ////////////////////////////////////////////////////
                            }
                            if (input == 7)//7
                            {
                                if (brettspiel[2, 0] == 2 || brettspiel[2, 0] == 1)
                                {
                                    turn = 1;
                                }
                                else
                                {
                                    brettspiel[2, 0] = 1;
                                    turn = 2;
                                }
                                //////////////////////////
                            }
                            if (input == 8)//8
                            {
                                if (brettspiel[2, 1] == 2 || brettspiel[2, 1] == 1)
                                {
                                    turn = 1;
                                }
                                else
                                {
                                    brettspiel[2, 1] = 1;
                                    turn = 2;
                                }
                                ////////////////////////////////////////////////////
                            }
                            if (input == 9)//9
                            {
                                if (brettspiel[2, 2] == 2 || brettspiel[2, 2] == 1)
                                {
                                    turn = 1;
                                }
                                else
                                {
                                    brettspiel[2, 2] = 1;
                                    turn = 2;
                                }

                                //////////////////////////
                            }



                            else if (input > 0 || input <= 9)
                            {
                                Console.Clear();

                            }
                            // end of input number


                        }
                        else
                        {
                            Console.Clear(); // clears things


                        }


                    }       // this looks awful    . .  .                                 my stupid little head is gonna implode
                    else if(turn == 2)
                    {


                        Console.WriteLine();
                        Console.WriteLine("1 2 3");
                        Console.WriteLine("4 5 6");
                        Console.WriteLine("7 8 9");
                        Console.WriteLine();
                        Console.WriteLine("player 2 go");
                        int input = Convert.ToInt32(Console.ReadLine());
                        if (input > 0 || input <= 9)
                        {
                            if (input == 1)//1
                            {
                                if (brettspiel[0, 0] == 1 || brettspiel[0, 0] == 2)
                                {
                                    turn = 2;
                                }
                                else
                                {
                                    brettspiel[0, 0] = 2;
                                    turn = 1;
                                }
                                ////////////////////////////////////////////////////
                            }
                            if (input == 2)//2
                            {
                                if (brettspiel[0, 1] == 1 || brettspiel[0, 1] == 2)
                                {
                                    turn = 2;
                                }
                                else
                                {
                                    brettspiel[0, 1] = 2;
                                    turn = 1;
                                }
                                //////////////////////////
                            }
                            if (input == 3)//3
                            {
                                if (brettspiel[0, 2] == 1 || brettspiel[0, 2] == 2)
                                {
                                    turn = 2;
                                }
                                else
                                {
                                    brettspiel[0, 2] = 2;
                                    turn = 1;
                                }
                                ////////////////////////////////////////////////////
                            }
                            if (input == 4)//4
                            {
                                if (brettspiel[1, 0] == 1 || brettspiel[1, 0] == 2)
                                {
                                    turn = 2;
                                }
                                else
                                {
                                    brettspiel[1, 0] = 2;
                                    turn = 1;
                                }
                                //////////////////////////
                            }
                            if (input == 5)//5
                            {
                                if (brettspiel[1, 1] == 1 || brettspiel[1, 1] == 2)
                                {
                                    turn = 2;
                                }
                                else
                                {
                                    brettspiel[1, 1] = 2;
                                    turn = 1;
                                }
                                ////////////////////////////////////////////////////
                            }
                            if (input == 6)//6
                            {
                                if (brettspiel[1, 2] == 1 || brettspiel[1, 2] == 2)
                                {
                                    turn = 2;
                                }
                                else
                                {
                                    brettspiel[1, 2] = 2;
                                    turn = 1;
                                }
                                //////////////////////////
                            }
                            if (input == 7)//7
                            {
                                if (brettspiel[2, 0] == 1 || brettspiel[2, 0] == 2)
                                {
                                    turn = 2;
                                }
                                else
                                {
                                    brettspiel[2, 0] = 2;
                                    turn = 1;
                                }
                                ////////////////////////////////////////////////////
                            }
                            if (input == 8)//8
                            {
                                if (brettspiel[2, 1] == 1 || brettspiel[2, 1] == 2)
                                {
                                    turn = 2;
                                }
                                else
                                {
                                    brettspiel[2, 1] = 2;
                                    turn = 1;
                                }
                                //////////////////////////
                            }
                            if (input == 9)//9
                            {
                                if (brettspiel[2, 2] == 1 || brettspiel[2, 2] == 2)
                                {
                                    turn = 2;
                                }
                                else
                                {
                                    brettspiel[2, 2] = 2;
                                    turn = 1;
                                }
                            }
                            else
                            {
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.Clear();
                        }///// WIN FINDER UNDER HERE


                        rounds++;
                    }
                    
                        
                     
                }
               
                //
                if(win == true)
                {
                    if(play == 1)
                    {
                        Console.WriteLine("Player 1 has won");
                    }
                    else if(play == 2)
                    {
                        Console.WriteLine("Player 2 has won");
                    }

                }
                
            }// end of the win while loop

            

           
        }

    }
}




/*
    - Needs a 3 by 3 rectangular array of integers /v/
    - Constructor to "initialize" the array to all 0s ( make into an empty board )
    - allow 2 ways to input ( two people ) // plan for ai if want to
    - place a 1 for the first player's turn
    - place a 2 for the second player's turn
    - each turn must be in a empty square 
    - AFTER EVERY MOVE scan to see if the game has been won or is at a draw ( probably use true or false to have a while loop that will last until it hits true ). if nether continue game.
    - EXTRA if ambitious make an ai player. -- my idea is to use a random number generator between 1 and 9 ( of course this ai wouldn't be strategic) 
      and it detects IF a number has already been placed there. if a number has then it would re-roll the random number gen.
*/
/*
     // lets turn into a int instead of a bool
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