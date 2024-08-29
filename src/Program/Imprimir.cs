namespace Ucu.Poo.GameOfLife;
using System; //Importa Console,String y Math
using System.Text;//Importa StringBuilder
using System.Threading;//Importa Thread y Thread.Sleep
public class Imprimir
{
    private Tablero tablero;
    private Logica logica;//Instancia de la clase Logica

    public Imprimir(Tablero tablero,Logica logica)
    {
        this.tablero = tablero;
        this.logica = logica;
    }

    public void ImprimirTablero()
    {
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            bool[,] b = tablero.Obtener_gameBoard(); //b obtiene el nuevo estado del tablero
            for (int y = 0; y < tablero.boardHeight; y++)
            {
                for (int x = 0; x < tablero.boardWidth; x++)
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
            Thread.Sleep(300);
        }
    }
}