using System;
using System.IO;

namespace Library
{
    public class ReadBoard
    {
        public static Board LeerBoard() // Lee el tablero por primera vez
        {
            string url = @".\..\..\assets\board.txt"; // Puede probarse cambiando por board2, board3 y board4 que utilicé una secuencia distinta
            //para probar distintas animaciones
            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            
            for (int y = 0; y < contentLines.Length; y++)
            {
                for (int x = 0; x < contentLines[y].Length; x++)
                {
                    if (contentLines[y][x] == '1')
                    {
                        board[y, x] = true;
                    }
                }
            }
            
            return new Board(board);
        }
    }
}