using System;
using System.Text;
using Ucu.Poo.GameOfLife;

namespace Ucu.Poo.GameOfLife
{
    //En esta clase pasa lo mismo que con Motor o BoardImporter.
    //Si la responsabilidad de imprimir estuviera en Board,
    //tendría más de una razón de cambio,
    //por eso se separa en Printer para realizar los cambios correspondientes aquí.

    //Es la clase experta en como imprimir (en este caso por consola) el juego.
    //Va a recibir el tablero y según sus medidas lo va a imprimir de cierta forma.

    public class Printer
    {
        public void Print(Board board)
        {
            Console.Clear();

            StringBuilder s = new StringBuilder();

            for (int y = 0; y < board.Height; y++)
            {
                for (int x = 0; x < board.Width; x++)
                {
                    if (board.CellEstate(x, y))
                        s.Append("|X|");
                    else
                        s.Append("___");
                }

                s.Append("\n");
            }

            Console.WriteLine(s.ToString());
        }
    }
}