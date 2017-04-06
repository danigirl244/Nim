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
                board.displayBoard();
                Console.WriteLine("\nPlayer 1");

                TakeTurn(p1,p2,board);

                if (board.totalCount > 0)
                {
                    board.displayBoard();
                    Console.WriteLine("\nPlayer 2");
                    TakeTurn(p2, p1, board);
                    
                }
            }
            string won = p1.won ?  "Player 1 Won" : "Player 2 Won";
            Console.WriteLine(won);
        }

        public static void TakeTurn(Player p, Player opponent, Board b)
        {
            bool validP1Input = b.takePieces(p.takeTurn());
            while (!validP1Input)
            {
                Console.WriteLine("Invalid selection. Try again");
                validP1Input = b.takePieces(p.takeTurn());
            }
            if (b.totalCount == 0)
            {
                opponent.won = true;
            }
        }
    }
}
