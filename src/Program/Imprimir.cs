namespace Ucu.Poo.GameOfLife;
using System.Numerics;
using System.IO;
using System; //Importa Console,String y Math
using System.Text;//Importa StringBuilder
using System.Threading;//Importa Thread y Thread.Sleep
public class Imprimir
{
    private bool[,] b; //variable que representa el tablero
    private int width; //variabe que representa el ancho del tablero
    private int height; //variabe que representa altura del tablero
    private Logica logica;//Instancia de la clase Logica

    public Imprimir(bool [,] tablero,int ancho,int alto,Logica logicainstancia)
    {
        b = tablero;
        width = ancho;
        height = alto;
        logica = logicainstancia;
    }

    public void ImprimirTablero()
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

                s.Append("\n");
            }

            Console.WriteLine(s.ToString());
            //=================================================
            //Invocar método para calcular siguiente generación
            //=================================================
            logica.Jugar();
            Thread.Sleep(5000);
        }
    }
}