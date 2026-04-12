using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    /*
     * JUSTIFICACIÓN DE DISEÑO:
     * - SRP (Principio de Responsabilidad Única): Creamos esta clase con el proposito de inicializar los objetos 
     *  y coordinar como va a funcionar la simulación.
     * - Si además tuviera la lógica que tienen las otras clases, Program tendría más de una razón de cambio.
     * - Expert (Experto en Información): Actúa como el controlador principal. Conoce el flujo del 
     * programa y sabe a qué objetos (los verdaderos expertos) delegar cada tarea (leer, calcular, imprimir).
     */
    class Program
    {
        static void Main(string[] args)
        {
            Motor motor = new Motor();
            Printer printer = new Printer();
          
            BoardImporter importer = new BoardImporter("board.txt");
            Board board = new Board(importer.Load());

            while (true)
            {
                printer.Print(board);
                board = motor.NextGeneration(board);
                Thread.Sleep(300);
            }
        }
    }
}
