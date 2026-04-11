namespace Ucu.Poo.GameOfLife
{
    /*
     * JUSTIFICACIÓN DE DISEÑO:
     * - SRP : conocer y aplicar las reglas de supervivencia del algoritmo de Conway. Al poder tener más de una 
     * razón de cambio, se realiza la clase motor por separado para poder cumplir con sus responsabilidades correspondientes.
     * - Expert : Es el experto en la lógica del juego. Recibe el 
     * estado actual (Board) y tiene la información del algoritmo para procesar quién vive 
     * y quién muere, devolviendo un tablero nuevo.
     */
    public class Motor
    {
        public Board NextGeneration(Board ActualBoard)
        {
            int width = ActualBoard.Width;
            int height = ActualBoard.Height;
            
            bool[,] cloneboard = new bool[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    int aliveNeighbors = 0;
                    
                    for (int i = x - 1; i <= x + 1; i++)
                    {
                        for (int j = y - 1; j <= y + 1; j++)
                        {
                            if (i >= 0 && i < width && j >= 0 && j < height && ActualBoard.CellEstate(i, j))
                            {
                                aliveNeighbors++;
                            }
                        }
                    }

                    bool isAlive = ActualBoard.CellEstate(x, y);
                    if (isAlive)
                    {
                        aliveNeighbors--;
                    }

                    // Reglas de Conway
                    if (isAlive && aliveNeighbors < 2)
                    {
                        cloneboard[x, y] = false;
                    }
                    else if (isAlive && aliveNeighbors > 3)
                    {
                        cloneboard[x, y] = false;
                    }
                    else if (!isAlive && aliveNeighbors == 3)
                    {
                        cloneboard[x, y] = true;
                    }
                    else
                    {
                        cloneboard[x, y] = isAlive;
                    }
                }
            }

            return new Board(cloneboard);
        }
    }
}
