using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    public class Player
    {
        public bool won = false;
        public Tuple<int, int> takeTurn()
        {
            int row, numberOfPieces;
            Console.WriteLine("Enter row number");

            row = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Enter number of O's to take");
            numberOfPieces = int.Parse(Console.ReadLine());
            return new Tuple<int,int>(row, numberOfPieces);
        }
        
    }
}
