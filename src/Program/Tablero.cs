namespace Ucu.Poo.GameOfLife;

public class Tablero
{
    private bool[,] GameBoard;
    public int boardWidth
    {
        get { return GameBoard.GetLength(0); }
    }
    
    public int boardHeigth
    {
        get { return GameBoard.GetLength(1); }
    }
    
    public bool[,] GetGameBoard
    {
        get
        {
            return this.GameBoard;
        }
        set
        {
            this.GameBoard = value;
        }
    }
    public Tablero(bool [,] matriz)
    {
        this.GameBoard = matriz;
    }
    
}