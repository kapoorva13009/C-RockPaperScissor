using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissor
{
    internal class Program
    {
        static void Main()
        {
            int player, computer, p=0,c=0;
            bool again = true;
            string a;
            Console.WriteLine("Hello Welcome to the Game");
            do
            {
                Random rand = new Random();
                computer = rand.Next(1,4);
                Console.WriteLine("\n Choose Your option ( Rock : 1, Paper : 2, Scissor : 3) -> ");
                player = Convert.ToInt32(Console.ReadLine());
                switch (player)
                {
                    case 1: Console.WriteLine("Generating Result");
                        if (computer == 1)
                            Console.WriteLine("Draw!!!!!");
                        else if (computer == 2)
                        {
                            Console.WriteLine("Computer Win !!");
                            c++;
                        }
                        else
                        {
                            Console.WriteLine("You Win !!");
                            p++;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Generating Result");
                        if (computer == 1)
                        {
                            Console.WriteLine("You Win !!");
                            p++;
                        }
                        else if (computer == 2)
                            Console.WriteLine("Draw!!!!!");
                        else
                        {
                            Console.WriteLine("Computer Win !!");
                            c++;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Generating Result");
                        if (computer == 1)
                        {
                            Console.WriteLine("Computer Win !!");
                            c++;
                        }
                        else if (computer == 2)
                        {
                            Console.WriteLine("You Win !!");
                            p++;
                        }
                        else
                            Console.WriteLine("Draw!!!!!");
                        break;
                    default: Console.WriteLine("\n Choose the Right Option ");
                        break;

                }
                Console.WriteLine("\n Score Player = {0}, Computer = {1} \n", p, c);
                Console.WriteLine("\n Want to play again (y/n) : \n");
                a = Console.ReadLine();
                if(a=="y")
                    again= true;
                else
                    again= false;
            }while(again);
        }
    }
}
