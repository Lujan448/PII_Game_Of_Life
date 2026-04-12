using System.Threading;

namespace Ucu.Poo.GameOfLife
{
    /*
     * JUSTIFICACIÓN DE DISEÑO:
     * - SRP (Principio de Responsabilidad Única): Realizamos un main aparte que es el program que por separado como crear los objetos,
     * -  que son cosas independientes por lo tanto lo hacemos en esta clase , asi si tenemos que modificar algo solo tenemos que cambiar esta clase. 
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
