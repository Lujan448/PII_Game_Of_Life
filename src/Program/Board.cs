using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    //Es la clase encargada de representar el tablero.
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


    //Por SRP, la célula debería tener su propia clase con sus responsabilidades correspondientes.
    //Sin embargo, como el ejercicio no solicita nada de ello, decidimos colocar la lógica de Cell dentro
    //de la clase Board.
    

        public void SetCellState(int x, int y, bool state)
        {
            cells[x,y] = state;
        }

        public void ChangeCellState(int x, int y)
        {
            cells[x,y] = !cells[x, y];
        }
    }
}
