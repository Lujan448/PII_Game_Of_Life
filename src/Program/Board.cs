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
    
    }
}
