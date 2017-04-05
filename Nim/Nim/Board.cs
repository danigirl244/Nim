using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    public class Board
    {
        public int[] board;
        public int totalCount
        {
            get
            {
                int sum = 0;
                foreach (int i in board)
                {
                    sum += i;
                }
                return sum;
            }
            set
            {
                
            }
        }

        public void displayBoard()
        {
            for (int i = 0; i < board.Length; i++)
            {
                Console.WriteLine(new String('O', board[i]));
            }
        }

        public Board()
        {
            board = new int[] { 3, 5, 7 };
            
        }

        public bool takePieces(Tuple<int, int> pieces)
        {
            if(pieces.Item1 >=0 && pieces.Item1 < board.Length)
            {
                if(pieces.Item2 > 0 && pieces.Item2 <= board[pieces.Item1])
                {
                    board[pieces.Item1] -= pieces.Item2;
                    return true;
                }
            }

            return false;
        }

    }
}
