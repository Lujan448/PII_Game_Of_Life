using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    //JUSTIFICACIÓN DE DISEÑO:
    //-SRP: se encarga únicamente de representar y conocer el estado del tablero.
    //-Expert: es el experto en la información del tablero, conoce la posición de las células, el alto y ancho.
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
