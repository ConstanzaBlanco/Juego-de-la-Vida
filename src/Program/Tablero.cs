using System.Numerics;

namespace Ucu.Poo.GameOfLife;
//Responsabilidades: 
//-Leer la información brindada por "Lector_archivo"
//-Crear un tablero en base a dicha información
//Collabs: Lector archivo
//Expert: Esta clase tiene la información correcta para crear el tablero que se va a utilizar más adelante

public class Tablero
{
    private bool[,] gameBoard;
    public int boardWidth { get; private set; }
    public int boardHeight { get; private set; }

    public void Crear_Tablero(Lector_Archivo lector)
    {
        gameBoard = lector.ReadArchive();
        boardWidth = gameBoard.GetLength(0);
        boardHeight = gameBoard.GetLength(1);
    }

    public bool[,] Obtener_gameBoard()
    {
        return gameBoard;
    }

    public void Establecer_gameBoard(bool[,] nuevogameBoard)
    {
        gameBoard = nuevogameBoard;
    }
}