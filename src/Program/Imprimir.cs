using System;
using System.Text;
using System.Threading;

namespace Ucu.Poo.GameOfLife;

public class Imprimir_Tablero
{
    public string Imprimir(Tablero tablero)
    {
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < tablero.boardHeigth; y++)
            {
                for (int x = 0; x < tablero.boardWidth; x++)
                {
                    if (tablero.GetGameBoard[x, y])
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
            Logica jugar = new Logica(tablero); 
            jugar.Logicajugar(tablero);
            Thread.Sleep(300);
            
        }
    }
}