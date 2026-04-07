using System;

namespace Ucu.Poo.GameOfLife
{
    //Es la clase encargada de realizar el tablero
    public class Board
    {
        private bool[,] grid;
        private int width;
        private int height;


    //Recibe de la clase que lee el archivo una matriz en donde se va a obtener el largo y ancho de esta misma.
        public Board(bool[,] matriz)
        {
            grid = matriz;
            width = matriz.GetLength(0);
            height = matriz.GetLength(1);
        }

        private int Cell(int x, int y)
        {
            int aliveNeighbors = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i >= 0 && i < width && j >= 0 && j < height && grid[i, j])
                    {
                        aliveNeighbors++;
                    }
                }
            }
            return aliveNeighbors;
        } 
    }
}
