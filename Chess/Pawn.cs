using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Pawn : Pieces
    {
        public static bool Move(int startingLine, int startingColumn, int inputLine, int inputColumn, Array[,] board)
        {
            if (startingLine == 1)
            {
                if (inputLine == 2 || inputLine == 3)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else if(startingLine == 6)
            {
                if (inputLine == 5 || inputLine == 4)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
