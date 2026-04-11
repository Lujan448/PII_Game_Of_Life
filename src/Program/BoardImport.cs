using System.Runtime.CompilerServices;
using System;
namespace Ucu.Poo.GameOfLife
{
//clase encargada de cargar el archivo al programa
    public class BoardImporter
    {
        public static bool[,] Load()
        {
        //lee el archivo y lo pasa a un string para luego conventir esa sting en un arry con el split
        string ReadFile = File.ReadAllText("board.txt");
        string[] FileLines = ReadFile.Split('\n');
        //crea la matriz
        bool [,] board = new bool [FileLines.Length , FileLines[0].Length];
        // recorre la matriz fijandose si el caracter es 0 o 1 y los remplaza con false o true respectivamente
        for (int y = 0; y < FileLines.Length ; y++)
            {
                for (int x = 0; x < FileLines[0].Length ; x++)
                {
                 if (FileLines[y][x]=='1')
                    {
                        board [y,x]= true;
                    }
                    else
                    {
                        board[y,x]= false;
                    }
                }
                
            }
            return board;
        }



 
    }
}