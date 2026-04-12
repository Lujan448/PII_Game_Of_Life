using System.Runtime.CompilerServices;
using System;
using System.IO;
using System.Linq;

namespace Ucu.Poo.GameOfLife
{
//clase encargada de cargar el archivo al programa
    public class BoardImporter
    {
        public static bool[,] Load(string filePath)
        {
        //lee el archivo y lo pasa a un string para luego conventir esa sting en un arry con el split
        string ReadFile = File.ReadAllText(filePath);
        string[] fileLines = ReadFile.Split('\n');

        for (int i = 0; i < fileLines.Length; i++)
        {
            fileLines[i] = fileLines[i].Trim();
        }

        fileLines = fileLines.Where(line => line.Length > 0).ToArray();

        //crea la matriz
        bool [,] board = new bool [fileLines[0].Length, fileLines.Length];
        // recorre la matriz fijandose si el caracter es 0 o 1 y los remplaza con false o true respectivamente
        for (int y = 0; y < fileLines.Length ; y++)
            {
                for (int x = 0; x < fileLines[y].Length ; x++)
                {
                 if (fileLines[y][x]=='1')
                    {
                        board [x, y]= true;
                    }
                }
                
            }
            return board;
        }



 
    }
}