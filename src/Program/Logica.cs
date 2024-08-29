using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace Ucu.Poo.GameOfLife;

public class Logica
{
    private bool[,] cloneboard;

    public Logica(Tablero tablero)
    {
        this.cloneboard = new bool[tablero.boardWidth, tablero.boardHeigth];
    }

    public bool[,] GetGameBoard
    {
        get
        {
            return this.cloneboard;
        }
    }

    public void Logicajugar(Tablero tablero)
    {
        for (int x = 0; x < tablero.boardWidth; x++)
        {
            for (int y = 0; y < tablero.boardHeigth; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < tablero.boardWidth && j >= 0 && j < tablero.boardHeigth &&
                            tablero.GetGameBoard[i, j])
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (tablero.GetGameBoard[x, y])
                {
                    aliveNeighbors--;
                }

                if (tablero.GetGameBoard[x, y] && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneboard[x, y] = false;
                }
                else if (tablero.GetGameBoard[x, y] && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard[x, y] = false;
                }
                else if (!tablero.GetGameBoard[x, y] && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard[x, y] = true;
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard[x, y] = tablero.GetGameBoard[x, y];
                }
            }
        }
        tablero.GetGameBoard = cloneboard;
    }
}