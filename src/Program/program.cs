using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    /*
     * JUSTIFICACIÓN DE DISEÑO:
     * - SRP (Principio de Responsabilidad Única): Su única responsabilidad es ser el punto de 
     * entrada de la aplicación y coordinar la ejecución continua del juego. No realiza cálculos ni lecturas.
     * - Expert (Experto en Información): Actúa como el controlador principal. Conoce el flujo del 
     * programa y sabe a qué objetos (los verdaderos expertos) delegar cada tarea (leer, calcular, imprimir).
     */
    class Program
    {
        static void Main(string[] args)
        {
            BoardImporter importer = new BoardImporter();
            Motor motor = new Motor();
            BoardPrinter printer = new BoardPrinter();

            Board board = importer.Load("board.txt");

            while (true)
            {
                printer.Print(board);
                board = motor.NextGeneration(board);
                Thread.Sleep(300);
            }
        }
    }
}