using System;

namespace Ucu.Poo.GameOfLife
{
    //Es la clase encargada de realizar el tablero.
    //Tiene la responsabilidad de conocer la posición de las células, además del alto y ancho para hacer la tabla.
    public class Board
    {
        public int Width { get; set; }
        public int Height { get; set; }
        private bool[,] cells;

        public Board(bool[,] initialCells)
        {
            this.Width = initialCells.GetLength(0);
            this.Height = initialCells.GetLength(1);
            this.cells = initialCells;
        }

        public bool CellEstate(int x, int y)
        {
            return cells[x,y];
        }


    //Cell podría ser perfectamente otra clase por SRP.
    //Ya que pueden haber casos en donde se le quiera realizar más de un cambio y, por lo tanto, 
    //tendría que estar en otra clase por separado.
    //Sin embargo, como el ejercicio no solicita nada de ello, decidimos que lo mejor era hacer Cell y Board juntos.
        public void SetCellState(int x, int y, bool state)
        {
            cells[x,y] = state;
        }

        public void ChangeCellState(int x, int y, bool state)
        {
            cells[x,y] = state;
        }
    

    //En esta parte del código se va a verificar que células están vivas.
    // Este metodo va a ser posteriormente llamado por la clase Rules para agregar más especificaciónes 
    // de su estado de vida.
        public int CellNeighbors(int x, int y)
        {
            int aliveNeighbors = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (i >= 0 && i < Width && j >= 0 && j < Height && cells[i, j])
                    {
                        aliveNeighbors++;
                    }
                }
            }
            return aliveNeighbors;
        } 
    }
}
