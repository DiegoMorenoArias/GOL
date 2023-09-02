using System;

namespace Library
{
    public class Board
    {
        public bool[,] gameBoard {get; set;} // Una matriz bidimensional que representa el tablero del juego.


        public Board(bool[,] Matriz) // Matriz booleana que representa el estado inicial del tablero.
        {
            this.gameBoard = Matriz; // Inicializa el tablero con la configuración proporcionada.
        }
    }
}
