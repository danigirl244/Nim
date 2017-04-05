using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    public class Engine
    {
        public static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Board board = new Board();
            while (board.totalCount > 0)
            {
                bool validP1Input = false, validP2Input = false;
                Console.WriteLine();
                board.displayBoard();
                Console.WriteLine("\nPlayer 1");

                validP1Input = board.takePieces(p1.takeTurn());
                while (!validP1Input)
                {
                    Console.WriteLine("Invalid selection. Try again");
                    validP1Input = board.takePieces(p1.takeTurn());
                }

                if (board.totalCount == 0)
                {
                    p2.won = true;
                }
                if (board.totalCount > 0)
                {
                    Console.WriteLine();
                    board.displayBoard();
                    Console.WriteLine("\nPlayer 2");

                    validP2Input = board.takePieces(p2.takeTurn());
                    while (!validP2Input)
                    {
                        Console.WriteLine("Invalid selection. Try again");
                        validP2Input = board.takePieces(p2.takeTurn());

                    }
                    if (board.totalCount == 0)
                    {
                        p1.won = true;
                    }
                }
            }

            if(p1.won == true)
            {
                Console.WriteLine("Player 1 won!");
            }
            else if(p2.won == true)
            {
                Console.WriteLine("Player 2 won!");
            }
        }
    }
}
