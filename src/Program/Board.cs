using System;

namespace Ucu.Poo.GameOfLife
{
    //Es la clase encargada de realizar el tablero.
    // En algunos casos podrá llegar a ser el experto de la información.
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

    //Cell podría ser perfectamente otra clase por SRP.
    //Ya que pueden haber casos en donde se le quiera realizar más de un cambio y, por lo tanto, 
    //tendría que estar en otra clase por separado.
    //Sin embargo, como el ejercicio no solicita nada de ello, decidimos que lo mejor era hacer Cell y Board juntos.
    

    //En esta parte del código se va a verificar que células están vivas.
    // Este metodo va a ser posteriormente llamado por la clase Rules para agregar más especificaciónes 
    // de su estado de vida.
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
