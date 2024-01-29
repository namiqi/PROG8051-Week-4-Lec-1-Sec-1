using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loops
            int x1 = 2;

            while (x1 >= 0)
            {
                for(int y = 2; y >=0; y--)
                {
                    Console.WriteLine(x1 + y);
                }
                x1 = x1 - 1;
            }

            // While Loop

            /*
             while (condition)
            {
                // code you want to repeat
            }

            */
            /*int x1 = 0;

            while (x1 < 3)
            {
                Console.WriteLine("Test");
                x1 = x1 + 1;
            }
*/

            // break and continue


            Random r = new Random();
            int guessnumber = r.Next(0, 100);
            int countattempts = 0;
            Console.WriteLine(guessnumber);
            bool result = true;

            while (result)
            {
                Console.WriteLine("Enter input");
                int usernum = Convert.ToInt32(Console.ReadLine());

                if(usernum == guessnumber)
                {
                    result = false;
                    Console.WriteLine("Yay! you guessed it right");
                }
                else if(guessnumber>usernum){
                    continue;
                    Console.WriteLine("Go up");
                }
                else if (guessnumber < usernum)
                {
                    Console.WriteLine("Go down");
                }
                countattempts++;
            }
            Console.WriteLine($"It took you {countattempts} attempts");

            // Explore Do While loop

            // For Loop
            /*
                       for(statment 1; statment 2; statment 3 )
                            {
                            // code that you want to repeat
                        }
            */
            // statement 1 = starting point  int x = 0;
            // statement 2 = end point, condition  x<5;
            // statement 3 = how the x will change x = x+1;

            // Counting
            int count = 0;

            // Totalling
            int p1points = 0; //points
            int p2points = 0;
            // Rock Paper Scissort updated
            for (int x = 0; x <= 5; x += 1)
            {

                Console.WriteLine("Player 1: ");
                string p1 = Console.ReadLine();

                Console.WriteLine("Player 2: ");
                string p2 = Console.ReadLine();

                if (p1 == p2)
                {
                    Console.WriteLine("draw");
                }

                else if ((p1 == "R" && p2 == "S") || (p1 == "P" && p2 == "R") || (p1 == "S" && p2 == "P"))
                {
                    Console.WriteLine("P1 wins");
                    count++; // count = count + 1
                    p1points = p1points + 5;
                }

                else if ((p1 == "R" && p2 == "P") || (p1 == "P" && p2 == "S") || (p1 == "S" && p2 == "R"))
                {
                    Console.WriteLine("P2 wins");
                    p2points = p2points + 5;
                }

                else
                {
                    Console.WriteLine("Bad input");
                }
               
            }
            Console.WriteLine(count);
            Console.WriteLine($"P1 has {p1points} points and P2 has {p2points} points");


            // Exercise
            // Print all the even numbers from 1 to 20
            /*  for (int x = 0; x <= 20; x +=1 )
              {
                 // % - remainder function
                 if(x%2== 1)
                  {
                      Console.WriteLine(x);
                  }
              }


              int usernum = Convert.ToInt32(Console.ReadLine());

              for (int x = 0; x <= usernum; x +=2)
              {
                  Console.WriteLine(x);
              }

              */

            /* infinite loop
            int usernum = Convert.ToInt32(Console.ReadLine());

            for (int x = 0; x <= usernum; x = x - 1)
            {
                Console.WriteLine(x);
            }

            */

        }
    }
}