using System;
using System.Threading;
using Library;
namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board1 = ReadBoard.LeerBoard(); // Lee el tablero, ésta será la primera generación.
            while (true) // Luego se mantiene en un loop infinito que va de ShowBoard a GameLogic constantemente pasando de generación en
            //generación de forma constante.
            {
                ShowBoard.DisplayBoard(board1);
                board1=GameLogic.BoardConReglas(board1);
                Thread.Sleep(100);
            }

        }
    }
}
