using System.Runtime.CompilerServices;
using System;
using System.IO;
namespace Ucu.Poo.GameOfLife
{
//clase encargada de cargar el archivo al programa
    public class BoardImporter
    {
        public static bool[,] Load(string filePath)
        {
        //lee el archivo y lo pasa a un string para luego conventir esa sting en un arry con el split
        string readFile = File.ReadAllText(filePath);
        string[] fileLines = readFile.Split('\n');

        for (int i = 0; i < fileLines.Length; i++)
            {
                fileLines[i] = fileLines[i].Trim();
            }
        //crea la matriz
        bool [,] board = new bool [fileLines.Length , fileLines[0].Length];
        // recorre la matriz fijandose si el caracter es 0 o 1 y los remplaza con false o true respectivamente
        for (int y = 0; y < fileLines.Length ; y++)
            {
                for (int x = 0; x < fileLines[0].Length ; x++)
                {
                 if (fileLines[y][x]=='1')
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