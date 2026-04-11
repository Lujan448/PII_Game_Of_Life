using System;
using System.Text;
using Ucu.Poo.GameOfLife;

namespace Ucu.Poo.GameOfLife
{
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