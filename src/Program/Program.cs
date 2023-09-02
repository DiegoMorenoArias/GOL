using System;
using Library;
namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board1 = ReadBoard.LeerBoard();
            while (true)
            {
                board1=ShowBoard.DisplayBoard(board1);
            }

        }
    }
}
