using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates an array of pieces representing the board
            Pieces[,] piece = new Pieces[7, 7];

            //Create the white pawns in the second line
            for (int j = 0; j < 8; j++)
            {
                piece[1, j] = new Pawn { Color = "WHITE" };
            }

            //Create the white rooks
            piece[0, 0] = new Rook { Color = "WHITE" };
            piece[0, 7] = new Rook { Color = "WHITE" };

            //Create the white knights
            piece[0, 1] = new Knight { Color = "WHITE" };
            piece[0, 6] = new Knight { Color = "WHITE" };

            //Create the white bishops
            piece[0, 2] = new Bishop { Color = "WHITE" };
            piece[0, 5] = new Bishop { Color = "WHITE" };

            //Create the white queen
            piece[0, 3] = new Queen { Color = "WHITE" };

            //Create the white king
            piece[0, 4] = new King { Color = "WHITE" };

            //Create the black pawns in the sixth line
            for (int j = 0; j < 8; j++)
            {
                piece[6, j] = new Pawn { Color = "BLACK" };
            }

            //Create the black rooks
            piece[7, 0] = new Rook { Color = "BLACK" };
            piece[7, 7] = new Rook { Color = "BLACK" };

            //Create the black knights
            piece[7, 1] = new Knight { Color = "BLACK" };
            piece[7, 6] = new Knight { Color = "BLACK" };

            //Create the black bishops
            piece[7, 2] = new Bishop { Color = "BLACK" };
            piece[7, 5] = new Bishop { Color = "BLACK" };

            //Create the black queen
            piece[7, 3] = new Queen { Color = "BLACK" };

            //Create the black king
            piece[7, 4] = new King { Color = "BLACK" };


        }
    }
}
