namespace Ucu.Poo.GameOfLife
{
    /*
     * JUSTIFICACIÓN DE DISEÑO:
     * - SRP : La única responsabilidad de esta clase es 
     * conocer y aplicar las reglas de supervivencia del Juego de la Vida. Su única razón 
     * de cambio sería si las reglas del juego cambian.
     * - Expert : Es el experto en la lógica del negocio. Recibe el 
     * estado actual (Board) y tiene la información del algoritmo para procesar quién vive 
     * y quién muere, devolviendo un tablero nuevo.
     */
    public class Motor
    {
        public Board CalcularSiguienteGeneracion(Board tableroActual)
        {
            int width = tableroActual.Width;
            int height = tableroActual.Height;
            
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
                            if (i >= 0 && i < width && j >= 0 && j < height && tableroActual.IsAlive(i, j))
                            {
                                aliveNeighbors++;
                            }
                        }
                    }

                    bool isAlive = tableroActual.IsAlive(x, y);
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