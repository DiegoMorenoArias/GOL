using System;
using System.Text;
using System.Threading; // Agrega la directiva using para Thread

namespace Library
{
    public class ShowBoard
    {


        public static void DisplayBoard(Board board) // Imprime el tablero ingresado
        {
            bool[,] b = board.gameBoard; // variable que representa el tablero
            int width = b.GetLength(0); // variable que representa el ancho del tablero
            int height = b.GetLength(1); // variable que representa la altura del tablero
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (b[x, y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
        }
    }
}
