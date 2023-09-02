using System;
using System.IO;
namespace Library
{

    public class GameLogic
        {
            public static Board BoardConReglas(Board board)
            {
                bool[,] currentBoard = board.gameBoard;
                int boardWidth = currentBoard.GetLength(0);
                int boardHeight = currentBoard.GetLength(1);
                bool[,] cloneboard = new bool[boardWidth, boardHeight];

                for (int x = 0; x < boardWidth; x++)
                {
                    for (int y = 0; y < boardHeight; y++)
                    {
                        int aliveNeighbors = 0;

                        for (int i = x - 1; i <= x + 1; i++)
                        {
                            for (int j = y - 1; j <= y + 1; j++)
                            {
                                if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight && currentBoard[i, j])
                                {
                                    aliveNeighbors++;
                                }
                            }
                        }

                        if (currentBoard[x, y])
                        {
                            aliveNeighbors--;
                        }

                        if (currentBoard[x, y] && aliveNeighbors < 2)
                        {
                            // Célula muere por baja población
                            cloneboard[x, y] = false;
                        }
                        else if (currentBoard[x, y] && aliveNeighbors > 3)
                        {
                            // Célula muere por sobrepoblación
                            cloneboard[x, y] = false;
                        }
                        else if (!currentBoard[x, y] && aliveNeighbors == 3)
                        {
                            // Célula nace por reproducción
                            cloneboard[x, y] = true;
                        }
                        else
                        {
                            // Célula mantiene el estado que tenía
                            cloneboard[x, y] = currentBoard[x, y];
                        }
                    }
                }

                return new Board(cloneboard); // Devuelve un nuevo tablero con las reglas aplicadas
            }
        }
}
