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
    }
}
