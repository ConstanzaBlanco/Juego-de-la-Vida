using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class Imprimir_Tablero
{
    bool[,] b = Tablero.Gameboard; //variable que representa el tablero
    int width = Tablero.boardWidth; //variabe que representa el ancho del tablero
    int height = Tablero.boardHeight; //variabe que representa altura del tablero

    public string Imprimir()
    {
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (b[x, y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
            }

            s.Append("\n");

            Console.WriteLine(s.ToString());
            //=================================================
            //Invocar método para calcular siguiente generación
            //=================================================
            Thread.Sleep(300);
        }
    }
}

