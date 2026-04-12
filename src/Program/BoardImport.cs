using System.Runtime.CompilerServices;
using System;
using System.IO;
using System.Linq;

namespace Ucu.Poo.GameOfLife
{
//Esta es la clase encargada de cargar el archivo al programa.
    public class BoardImporter
    {
        //Tiene la responsabilidad de conocer el nombre del archivo
        private string filePath;
        public BoardImporter(string filePath)
        {
            this.filePath = filePath;
        }
        public bool[,] Load()
        {
        //En esta parte obtiene el archivo, lo lee y lo convierte en un string
        //para después separarlo en un array con Split.
        string ReadFile = File.ReadAllText(filePath);
        string[] fileLines = ReadFile.Split('\n');

        for (int i = 0; i < fileLines.Length; i++)
        {
            //En esta parte colocamos Trim() para eliminar aquellos espacios en blanco al inicio y al final de un string
            //que pudieran alterar el resultado 
            fileLines[i] = fileLines[i].Trim();
        }


        //Se crea la matriz
        bool [,] board = new bool [fileLines[0].Length, fileLines.Length];
        //Se recorre la matriz fijandose si el caracter es 0 o 1 y los remplaza con false o true respectivamente
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

//En este caso, nosotros aplicamos SRP, creando una clase por separado, ya que aunque la clase Board podría 
//cumplir con la responsabilidad de cargar el archivo, si en algún momento se quiere cambiar la fuente de como obtener los datos
//Board tendría más de una razón de cambio.
//Entonces, si surge algún tipo de cambio que tenga que ver con la importación del archivo,
//se realiza directamente aquí. 

 
    }
}